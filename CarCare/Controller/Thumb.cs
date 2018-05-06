using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CarCare.Controller
{
    class Thumb
    {
        DataTable vehicleTable = new DataTable();

        List<string> vehicleList;

        public Thumb(DataTable vehicleData)
        {
            vehicleList = vehicleData.Rows.OfType<DataRow>().Select(k => k[0].ToString()).ToList();
        }

        public Label[] GetLabels()
        {


            return new Label[1];
        }



    }
}
