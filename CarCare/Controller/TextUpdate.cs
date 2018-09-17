using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarCare.Model;

namespace CarCare.Controller
{
    static class TextUpdate
    {
        private static Dictionary<string, TextBox> txtDict;
        private static Label iDLabel;
        private static ComboBox typeCb;
        private static Dictionary<string, string> vehicle;
        private static string id = "0";

        public static Dictionary<string, string> Vehicle
        {            
            get
            {
                //FillTextBoxes();
                return vehicle;
            }
        }

        public static string Id
        {
            set
            {
                id = value;
                FillTextBoxes();
            }
        }
        public static Dictionary<string, TextBox> TxtDict { set => txtDict = value; }
        public static Label IDLabel { set => iDLabel = value; }
        public static ComboBox TypeCb { set => typeCb = value; }

        private static void FillTextBoxes()
        {
            Text text = new Text(int.Parse(id), 0);
            text.RetrieveData();//No need for DataTable Object
            vehicle = text.Vehicle;            

            txtDict["model"].Text = vehicle["model"];
            txtDict["manufacturer"].Text = vehicle["manufacturer"];
            txtDict["plate"].Text = vehicle["plate"];
            txtDict["year"].Text = vehicle["year"];
            iDLabel.Text = vehicle["id"];
            
            typeCb.SelectedIndex = typeCb.FindString(vehicle["type"]);
            
        }
    }
}
