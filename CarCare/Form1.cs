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

namespace CarCare
{
    public partial class Form1 : Form
    {        
        static byte vehicleID = Properties.Settings.Default.vehicleID;
        static byte serviceID = Properties.Settings.Default.vehicleID;

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
            //txt.ExecuteCommand(1, 1);
            RenderVehicleAndService();
        }

        private void RenderVehicleAndService()
        {
            gbVehicle.Text = txt.Vehicle["type"];
            lblModel.Text = txt.Vehicle["model"];
            lblMaker.Text = txt.Vehicle["maker"];
            lblMakeYear.Text = txt.Vehicle["year"];
            lblPlate.Text = txt.Vehicle["plate"];

            tbDescription.Text = txt.Service["description"];
            tbDate.Text = txt.Service["date"];
            tbNextDate.Text = txt.Service["nextDate"];
            tbKm.Text = txt.Service["km"];
            tbNextKm.Text = txt.Service["nextKm"];
            tbExecutor.Text = txt.Service["executor"];
            lblStatus.Text = txt.Service["status"];
            lblMissDays.Text = txt.Service["missingDays"];
            lblMissKm.Text = txt.Service["missingKm"];
            //Calcular missing days
            //Calcular MissingKm

            

        }       
    }
}
