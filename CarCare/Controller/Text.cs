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
    class Text
    {
        private int vehicleID, serviceID;
        
        public Text(int vehicleID, int serviceID)
        {
            this.vehicleID = vehicleID;
            this.serviceID = serviceID;
        }

        private Dictionary<String, String> vehicle = new Dictionary<String, String>()
        {
            { "type", "Carro" },
            { "model", "Grand Siena" },
            { "maker", "Fiat" },
            { "year", "2014" },
            { "plate", "FMH0842" },
            { "id", "1" },
            { "table", "Vehicle" }
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
            {"missingKm", "200"},
            { "id", "1" },
            { "table", "Service" }
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

        public int VehicleID { get => vehicleID; set => vehicleID = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }

        /// <summary>
        /// Requests operations in a database
        /// </summary>
        /// <param name="queryType"> 1 = create, 2 = update, 3 = delete</param>
        /// <param name="objType">1 = vehicle, 2 = service</param>
        public void PersistData(byte queryType, byte objType)
        {
            Sql sql = CreateSql(objType);

            switch (queryType)
            {
                case 1:
                    sql.Insert();
                    break;
                case 2:
                    sql.Update();
                    break;
                case 3:
                    sql.Delete();
                    break;
            }
        }

        /// <summary>
        /// Retrieves data based on current object state
        /// </summary>
        /// <param name="objType">type byte: 1 = vehicle, 2 = service</param>
        public DataTable RetrieveData(byte objType)
        {
            Sql sql = CreateSql(objType);
            DataTable dt = sql.Select();
            return dt;
        }

        /// <summary>
        /// Auxiliary method for PersistData
        /// </summary>
        /// <param name="objType">type byte: 1 = vehicle, 2 = service</param>
        /// <returns>Sql object with suitable parameter </returns>
        private Sql CreateSql(byte objType)
        {
            if (objType == 1)
            {
                return new Sql(vehicle);
            }
            return new Sql(service);
        }
    }
}
