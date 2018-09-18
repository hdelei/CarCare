using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarCare.Controller;


namespace CarCare
{
    public partial class VehicleForm : Form
    {
        DynamicButton dn;
        int vehicleId;

        public VehicleForm(int vehicleId)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;
            dn = new DynamicButton(lblID);
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            ShareControls();           

            //I must to start with the desired vehicle in the new text() object
            Text txt = new Text(vehicleId, 0);
            DataTable dt = txt.RetrieveAllVehicles();

            //Debug.WriteLine(txt.Vehicle["model"]);
            
            dn.CreateButtons(dt);            
            flowLayoutPanel1.Controls.AddRange(dn.Controls);

            if (Controls.Find(vehicleId.ToString(), true).FirstOrDefault() is Button currentButton)
            {
                currentButton.PerformClick();
            }
        }

        /// <summary>
        /// Share textboxes and label for dynamic update
        /// </summary>
        private void ShareControls()
        {
            TextUpdate.TxtDict = new Dictionary<string, TextBox>() {                
                { "model", txtModel },
                { "manufacturer", txtManufacturer },
                { "plate", txtPlate },
                { "year", txtYear }
            };

            TextUpdate.IDLabel = lblID;
            TextUpdate.TypeCb = cbType;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<string> test = new List<string>(new string[] {
                "1",
                "carro",
                "Grand Siena",
                "Fiat",
                "FMH0842",
                "2014" });

            dn.CreateOneButton(test);

            flowLayoutPanel1.Controls.AddRange(dn.Controls);            
        }
        
    }
}
