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
        static byte vehicleID = Properties.Settings.Default.vehicleID;
        static byte serviceID = Properties.Settings.Default.vehicleID;

        const byte VEHICLE = 1;
        const byte SERVICE = 2;
        const byte INSERT = 1;
        const byte UPDATE = 2;
        const byte DELETE = 3;

        Text txt = new Text(VehicleID, ServiceID);

        public Form1()
        {
            InitializeComponent();
            SQLiteDB.Create(Properties.Settings.Default.connectionString);            
        }

        public static byte VehicleID
        {
            get => vehicleID;
            set
            {
                vehicleID = value;
                Properties.Settings.Default.vehicleID = value;
                Properties.Settings.Default.Save();
            }
        }
        public static byte ServiceID
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
            DataTable dt = txt.RetrieveData();
                        
            dgvMain.Columns.Clear();
            dgvMain.DataSource = dt;           
            

            RenderVehicleAndService();
            dgvMain.AllowUserToAddRows = false;

            //txt.PersistsData(UPDATE, SERVICE);

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
            tbCost.Text = txt.Service["value"];
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

            txt.Service["id"] = dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt.Service["exec_date"] = dgvMain.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt.Service["description"] = dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt.Service["executor"] = dgvMain.Rows[e.RowIndex].Cells[4].Value.ToString();            
            txt.Service["current_km"] = dgvMain.Rows[e.RowIndex].Cells[5].Value.ToString();

            decimal auxValue = (decimal)dgvMain.Rows[e.RowIndex].Cells[6].Value;

            txt.Service["value"] = auxValue.ToString("F");
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
    }
}
