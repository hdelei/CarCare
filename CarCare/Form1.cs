using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarCare.Controller;
using CarCare.Model;

namespace CarCare
{
    public partial class Form1 : Form
    {        
        static int vehicleID = Properties.Settings.Default.vehicleID;
        static int serviceID = Properties.Settings.Default.vehicleID;

        const byte VEHICLE = 1;
        const byte SERVICE = 2;
        const byte INSERT = 1;
        const byte UPDATE = 2;
        const byte DELETE = 3;
        //byte action;//insert, update, delete
        //byte target;//vehicle, service

        Text txt = new Text(VehicleID, ServiceID);

        bool isTextEditable = false;

        public Form1()
        {
            InitializeComponent();
            SQLiteDB.Create(Properties.Settings.Default.connectionString);            
        }

        public static int VehicleID
        {
            get => vehicleID;
            set
            {
                vehicleID = value;
                Properties.Settings.Default.vehicleID = value;
                Properties.Settings.Default.Save();
            }
        }
        public static int ServiceID
        {
            get => serviceID;
            set
            {
                serviceID = value;
                Properties.Settings.Default.serviceID = value;
                Properties.Settings.Default.Save();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReloadDataGridView();            

            dgvMain.AllowUserToAddRows = false;
        }

        private void ReloadDataGridView()
        {
            DataTable dt = txt.RetrieveData();

            dgvMain.Columns.Clear();
            dgvMain.DataSource = dt;

            RenderVehicleAndService();
        }

        private void RenderVehicleAndService()
        {
            gbVehicle.Text = txt.Vehicle["type"];
            lblModel.Text = txt.Vehicle["model"];
            lblMaker.Text = txt.Vehicle["manufacturer"];
            lblMakeYear.Text = txt.Vehicle["year"];
            lblPlate.Text = txt.Vehicle["plate"];

            tbDescription.Text = txt.Service["description"];
            tbDate.Text = txt.Service["exec_date"];
            tbNextDate.Text = txt.Service["next_date"];
            tbKm.Text = txt.Service["current_km"];
            tbNextKm.Text = txt.Service["next_km"];
            
            //decimal auxValue = Convert.ToDecimal(txt.Service["value"]);
            //if (auxValue > 0)            
            //    auxValue /= 100;
            
            double aux = double.Parse(txt.Service["value"]);
            tbCost.Text = aux.ToString("F");
            tbExecutor.Text = txt.Service["executor"];
            lblStatus.Text = txt.Service["status"];
            lblMissDays.Text = txt.Service["missing_days"];
            lblMissKm.Text = txt.Service["missing_km"];
            //Calcular missing days
            //Calcular MissingKm

            DgvFormat();

        }

        private void DgvMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            VehicleID = Convert.ToInt16(dgvMain.Rows[e.RowIndex].Cells[1].Value);

            txt.Service["id"] = dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt.Service["exec_date"] = dgvMain.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt.Service["description"] = dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt.Service["executor"] = dgvMain.Rows[e.RowIndex].Cells[4].Value.ToString();            
            txt.Service["current_km"] = dgvMain.Rows[e.RowIndex].Cells[5].Value.ToString();

            object auxValue = dgvMain.Rows[e.RowIndex].Cells[6].Value;
            //txt.Service["value"] = Monetary.DecimalObjectToIntString(auxValue);
            txt.Service["value"] = auxValue.ToString();
            txt.Service["next_km"] = dgvMain.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt.Service["next_date"] = dgvMain.Rows[e.RowIndex].Cells[8].Value.ToString();
            txt.Service["status"] = dgvMain.Rows[e.RowIndex].Cells[9].Value.ToString();
            //txt.Service["missingDays"] = dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString();
            //txt.Service["missingKm"] = dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString();

            RenderVehicleAndService();
        }

        private void DgvFormat()
        {
            dgvMain.RowHeadersVisible = false;
            dgvMain.ColumnHeadersVisible = true;
            dgvMain.Columns[0].Visible = false;
            dgvMain.Columns[1].Visible = false;
            dgvMain.AutoResizeColumns();

            dgvMain.Columns[2].HeaderText = "Data";
            dgvMain.Columns[3].HeaderText = "Serviço";
            dgvMain.Columns[4].HeaderText = "Executor";
            dgvMain.Columns[5].HeaderText = "Km";
            dgvMain.Columns[6].HeaderText = "Custo";
            dgvMain.Columns[7].HeaderText = "Próx. Km";
            dgvMain.Columns[8].HeaderText = "Próx. data";
            dgvMain.Columns[9].HeaderText = "Status";

            dgvMain.Columns["value"].DefaultCellStyle.Format = "F";
            //dgvMain.Columns["current_km"].DefaultCellStyle.Format = "";
        }

        private void TSEditService_Click(object sender, EventArgs e)
        {
            EditTextBoxes();
            Context.SetContext(SERVICE, UPDATE);            
        }

        /// <summary>
        /// Lock or Unlock TextBoxes for edition
        /// </summary>
        private void EditTextBoxes()
        {
            if (!isTextEditable)
            {
                foreach (Control tb in gbDetails.Controls)
                {
                    if (tb is TextBox)
                        ((TextBox)tb).ReadOnly = false;
                    else if (tb is MaskedTextBox)
                        ((MaskedTextBox)tb).ReadOnly = false;
                }
                isTextEditable = true;
                btSave.Enabled = true;                
            }
            else
            {
                foreach (Control tb in gbDetails.Controls)
                {
                    if (tb is TextBox)
                        ((TextBox)tb).ReadOnly = true;
                    else if (tb is MaskedTextBox)
                        ((MaskedTextBox)tb).ReadOnly = true;
                }
                isTextEditable = false;
                btSave.Enabled = false;
            }            
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            PrepareDataBeforePersists();

            txt.PersistsData(Context.Action, Context.Target);

            EditTextBoxes();
            ReloadDataGridView();
        }

        private void PrepareDataBeforePersists()
        {
            Dictionary<string, string> vehicleText = new Dictionary<string, string>();
            Dictionary<string, string> serviceText = new Dictionary<string, string>();

            foreach (Control ct in gbVehicle.Controls)
            {
                if (!ct.Name.Contains("label"))                
                    vehicleText.Add(ct.Name, ct.Text);                
            }
            
            foreach (Control ct in gbDetails.Controls)
            {
                if (!ct.Name.Contains("label"))                
                    serviceText.Add(ct.Name, ct.Text);                
            }
                        
            serviceText["tbCost"] = Monetary.EntryValidate(serviceText["tbCost"]);

            Dictionary<string, string>[] dictList = new Dictionary<string, string>[2];
            dictList[0] = vehicleText;
            dictList[1] = serviceText;

            txt.SetTextFromDicts(dictList);
        }

        private void TSNewEmptyService_Click(object sender, EventArgs e)
        {
            EditTextBoxes();
            Context.SetContext(SERVICE, INSERT);

            foreach (Control ct in gbDetails.Controls)
            {
                if (!ct.Name.Contains("label"))
                {
                    ct.Text = "";
                }
            }
            tbDescription.Focus();
        }

        private void TSNewService_Click(object sender, EventArgs e)
        {
            EditTextBoxes();
            Context.SetContext(SERVICE, INSERT);
            tbDescription.Focus();
            tbDescription.SelectAll();
        }

        private void TSDeleteService_Click(object sender, EventArgs e)
        {
            Context.SetContext(SERVICE, DELETE);
            //TODO: create a warning message before deleting
            string areYouSure = "Certeza que deseja mandar este serviço pro espaço?";
            DialogResult dr = MessageBox.Show(areYouSure, "Aviso:", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                txt.PersistsData(Context.Action, Context.Target);
                ReloadDataGridView();
            }            
        }
    }
}
