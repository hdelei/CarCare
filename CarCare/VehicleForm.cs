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
        DynamicButton dynButton;
        int vehicleId;

        public delegate void CloseDelegate();

        public VehicleForm(int vehicleId)
        {
            InitializeComponent();
            this.vehicleId = vehicleId;            
            dynButton = new DynamicButton(lblID, this);
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

            Context.VehicleFormContext = AccessibleName;

            ActiveControl = txtModel;

            ShareControls();           
            
            Text txt = new Text(vehicleId, 0);
            DataTable dt = txt.RetrieveAllVehicles();           
            
            dynButton.CreateButtons(dt);            
            flowLayoutPanel1.Controls.AddRange(dynButton.Controls);



            //if (Controls.Find(vehicleId.ToString(), true).FirstOrDefault() is Button currentButton)
            //{
            //    //currentButton.PerformClick();
            //}

            SetInitialContext();
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

            dynButton.CreateOneButton(test);

            flowLayoutPanel1.Controls.AddRange(dynButton.Controls);            
        }

        private void SetInitialContext()
        {
            if (Context.VehicleFormContext != "open")
            {
                if (Controls.Find(vehicleId.ToString(), true).FirstOrDefault() is Button currentButton)
                {
                    currentButton.PerformClick();
                }
            }
            
            //1 open the vehicle
            //Textboxes disabled
            //enabled icons click

            //2 edit the vehicle
            //Controls enabled and editabled

            //3 new vehicle
            //No Icon selected
            //Textboxes empty
            switch (this.AccessibleName)
            {
                case "open":
                    LockControls();
                    //Debug.WriteLine(AccessibleName);
                    break;
                case "edit":
                    txtModel.Focus();
                    //Debug.WriteLine(AccessibleName);
                    break;
                default:
                    ClearText();
                    //Debug.WriteLine(AccessibleName);
                    break;
            }
        }

        private void LockControls()
        {
            foreach (Control item in panelControls.Controls)
            {
                item.Enabled = false;
            }
        }

        private void UnlockControls()
        {
            foreach (Control item in panelControls.Controls)
            {
                item.Enabled = true;
            }
        }

        private void ClearText()
        {
            foreach (Control item in panelControls.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            txtModel.Focus();
        }

    }
}
