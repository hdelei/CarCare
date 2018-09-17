using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare.Controller
{
    static class LastDynamicButton
    {
        static Button button = new Button();
        static string dbId;

        public static Button Button
        {
            get => button;
            set
            {
                RemoveBorder();
                button = value;
                button.FlatAppearance.BorderSize = 1;
            }
        }

        public static string DbId
        {
            get => dbId;
            set
            {
                dbId = value;
                TextUpdate.Id = value;                
                //Console.WriteLine("ID: " + value);
            }
        }

        private static void RemoveBorder()
        {
            if (Button != null)
            {
                Button.FlatAppearance.BorderSize = 0;
            }
            
        }
        
    }
}
