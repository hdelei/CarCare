﻿using System;
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
            vehicle["id"] = vehicleID.ToString();
            service["id"] = serviceID.ToString();
        }

        private Dictionary<String, String> vehicle = new Dictionary<String, String>()
        {
            { "type", "Carro" },
            { "model", "Grand Siena" },
            { "manufacturer", "Fiat" },
            { "year", "2014" },
            { "plate", "FMH0842" },
            { "id", "10" },
            { "table", "Vehicle" }
        };

        private Dictionary<String, String> service = new Dictionary<String, String>()
        {
            {"description", "teste"},
            {"exec_date", "10/03/1981"},
            {"next_date", "10/03/2015"},
            {"current_km", "111000"},
            {"value", "0"},
            {"next_km", "10000"},
            {"executor", "vanderlei"},
            {"status", "ok"},
            {"missing_days", "10"},
            {"missing_km", "200"},
            { "id", "10" },
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
        /// <param name="queryType"> 1 = insert, 2 = update, 3 = delete</param>
        /// <param name="objType">1 = vehicle, 2 = service</param>
        public void PersistsData(byte queryType, byte objType)
        {
            Sql sql = CreateSql(objType);

            switch (queryType)
            {
                case 1:
                    sql.VehicleID = vehicleID;
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

        private Sql CreateSql(byte objType)
        {
            if (objType == 1)
                return new Sql(vehicle);
            return new Sql(service);
        }

        /// <summary>
        /// Retrieves data based on current object state
        /// </summary>        
        public DataTable RetrieveData()
        {
            Sql sql = new Sql(vehicle);
            DataTable dtVehicle = sql.SelectVehicle();
            UpdateVehicle(dtVehicle);

            DataTable dtService = sql.SelectServices();

            int valueColumnIndex = dtService.Columns["value"].Ordinal;
            //Console.WriteLine(Monetary.DtColumnIntToDecimal(dtService, valueColumnIndex));

            DataTable newDtService = Monetary.DtColumnIntToDecimal(dtService, valueColumnIndex);

            return newDtService;
        }

        private void UpdateVehicle(DataTable dtVehicle)
        {
            vehicle["id"] = dtVehicle.Rows[0][0].ToString();
            vehicle["type"] = dtVehicle.Rows[0][1].ToString();
            vehicle["model"] = dtVehicle.Rows[0][2].ToString();
            vehicle["manufacturer"] = dtVehicle.Rows[0][3].ToString();
            vehicle["plate"] = dtVehicle.Rows[0][4].ToString();
            vehicle["year"] = dtVehicle.Rows[0][5].ToString();            
        }
    }
}
