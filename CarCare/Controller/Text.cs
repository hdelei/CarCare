using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms;


namespace CarCare.Controller
{
    class Text
    {
        private int vehicleID, serviceID;
        
        public Text(int vehicleID, int serviceID)
        {
            this.VehicleID = vehicleID;
            this.serviceID = serviceID;
        }

        private Dictionary<String, String> vehicle = new Dictionary<String, String>()
        {
            {"type", "Carro"},
            {"model", "Grand Siena"},
            {"maker", "Fiat"},
            {"year", "2014" },
            {"plate", "FMH0842"}
        };

        private Dictionary<String, String> service = new Dictionary<String, String>()
        {
            {"description", "teste"},
            {"date", "10/03/1981"},
            {"nextDate", "10/03/2015"},
            {"km", "111000"},
            {"nextKm", "10000"},
            {"executor", "vanderlei"},
            {"status", "ok"},
            {"missingDays", "10"},
            {"missingKm", "200"}
        };

        public Dictionary<String, String> Vehicle
        {
            get => vehicle;
            set => vehicle = value;
        }
        
        public Dictionary<String, String> Service
        {
            get => service;
            set => service = value;
        }
        public int VehicleID { get => VehicleID1; set => VehicleID1 = value; }
        public int VehicleID1 { get => vehicleID; set => vehicleID = value; }

        /// <summary>
        /// Requests operations in a database
        /// </summary>
        /// <param name="queryType"> 1 = create, 2 = select, 3 = update, 4 = delete</param>
        /// <param name="objType">1 = vehicle, 2 = service</param>
        public void ExecuteCommand(byte queryType, byte objType)
        {
            //Make a database operation
        }        
    }
}
