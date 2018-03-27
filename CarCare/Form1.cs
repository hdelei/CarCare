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

            IntToMonetary();

        }

        private void RenderVehicleAndService()
        {
            gbVehicle.Text = txt.Vehicle["type"];
            lblModel.Text = txt.Vehicle["model"];
            lblMaker.Text = txt.Vehicle["manufacturer"];
            lblMakeYear.Text = txt.Vehicle["year"];
            lblPlate.Text = txt.Vehicle["plate"];

            tbDescription.Text = txt.Service["description"];
            tbDate.Text = txt.Service["date"];
            tbNextDate.Text = txt.Service["nextDate"];
            tbKm.Text = txt.Service["km"];
            tbNextKm.Text = txt.Service["nextKm"];
            tbCost.Text = txt.Service["value"];
            tbExecutor.Text = txt.Service["executor"];
            lblStatus.Text = txt.Service["status"];
            lblMissDays.Text = txt.Service["missingDays"];
            lblMissKm.Text = txt.Service["missingKm"];
            //Calcular missing days
            //Calcular MissingKm

            DgvFormat();

        }

        private void DgvMain_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

            txt.Service["id"] = dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt.Service["date"] = dgvMain.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt.Service["description"] = dgvMain.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt.Service["executor"] = dgvMain.Rows[e.RowIndex].Cells[4].Value.ToString();            
            txt.Service["km"] = dgvMain.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt.Service["value"] = dgvMain.Rows[e.RowIndex].Cells[6].Value.ToString();//aply format
            txt.Service["nextKm"] = dgvMain.Rows[e.RowIndex].Cells[7].Value.ToString();
            txt.Service["nextDate"] = dgvMain.Rows[e.RowIndex].Cells[8].Value.ToString();
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
        }

        private void IntToMonetary()
        {            
            //TODO: utilizar a classe pronta que fiz no stackoverflow
            int costColumn = 6;
            foreach (DataGridViewRow row in dgvMain.Rows){
                
                decimal currentCost = Convert.ToDecimal(row.Cells[costColumn].Value) / 100;
                Console.WriteLine(currentCost.ToString("C2"));
            }
        }
    }
}
