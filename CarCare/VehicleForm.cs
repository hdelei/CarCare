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
        DynamicButton dn = new DynamicButton();

        public VehicleForm()
        {
            InitializeComponent();            
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            Text txt = new Text(0, 0);
            DataTable dt = txt.RetrieveAllVehicles();           
            
            dn.CreateButtons(dt);            
            flowLayoutPanel1.Controls.AddRange(dn.Controls);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            List<string> test = new List<string>(new string[] { "1","carro","Grand Siena", "Fiat","FMH0842", "2014" });
            dn.CreateOneButton(test);

            flowLayoutPanel1.Controls.AddRange(dn.Controls);
            
        }



        
    }
}
