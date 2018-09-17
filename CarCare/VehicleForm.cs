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
    public partial class VehicleForm : Form
    {
        DynamicButton dn;

        public VehicleForm()
        {
            InitializeComponent();            
            dn = new DynamicButton(lblID);
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            ShareControls();           

            Text txt = new Text(0, 0);
            DataTable dt = txt.RetrieveAllVehicles();           
            
            dn.CreateButtons(dt);            
            flowLayoutPanel1.Controls.AddRange(dn.Controls);
            
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
