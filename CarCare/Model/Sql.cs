using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCare.Model
{
    class Sql
    {
        Dictionary<String, String> dict;
        String query = "";
        Connection conn = new Connection();

        int vehicleID;

        public int VehicleID {
            set => vehicleID = value ;
        }

        public Sql(Dictionary<String, String> dict)
        {
            this.dict = dict;
        }

        /// <summary>
        /// Select database with current vehicle id
        /// </summary>
        /// <returns>Datatable with database information</returns>
        public DataTable SelectVehicle()
        {            
            query = "SELECT * FROM Vehicle WHERE id = "+ dict["id"] +";";
            //conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;            
        }

        /// <summary>
        /// Select database with current service id
        /// </summary>
        /// <returns>Datatable with database information</returns>
        public DataTable SelectServices()
        {
            query = "SELECT * FROM Service WHERE vehicleID = " + dict["id"] + ";";
            //Connection conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;            
        }

        /// <summary>
        /// Update database with current dict information
        /// </summary>
        /// <returns>number of rows affected</returns>
        public int Update()
        {
            query = "UPDATE " + dict["table"] +
                    " SET " + ValuesForUpdate() + 
                    " WHERE id = " + dict["id"] + ";";           

            return conn.Execute(query);           
        }

        /// <summary>
        /// Filter dictionary joining strings for sqlite format
        /// </summary>
        /// <returns>String. Example "table1='value1', table2='value2'"</returns>
        private string ValuesForUpdate()
        {
            string values = "";
            var list = dict.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                if (key != "table" && key != "id"
                    && !key.Contains("missing"))
                {
                    values += key + " = '" + dict[key] + "', ";
                }
            }

            values = values.TrimEnd(' ').TrimEnd(',');            
            
            return values;
        }

        /// <summary>
        /// Create new record in database
        /// </summary>
        /// <returns>Integer rows affected</returns>
        public int Insert()
        {
            var result = ValuesForInsert();

            query = "INSERT INTO " + dict["table"] + 
                    " (" + result["columns"] + ") " + 
                    " VALUES (" + result["values"] + ");";

            return conn.Execute(query);
        }

        private Dictionary<string, string> ValuesForInsert()
        {
            string columns = "vehicleID, ";
            string values = "'" + vehicleID.ToString() + "', ";

            if (!dict.ContainsKey("vehicleID"))
            {
                columns = "";
                values = "";
            }

            var list = dict.Keys.ToList();
            list.Sort();

            foreach (var key in list)
            {
                if (key != "table" && !key.Contains("missing"))
                {
                    columns += key + ", ";
                }
            }
            columns = columns.TrimEnd(' ').TrimEnd(',');
            
            foreach (var key in list)
            {
                if (key != "table" && !key.Contains("missing"))
                {
                    if (key == "id")
                        values += "null, ";                    
                    else
                        values += "'" + dict[key] + "', ";
                }
            }
            values = values.TrimEnd(' ').TrimEnd(',');
            Dictionary<string, string> result = new Dictionary<string, string>
            {
                { "columns", columns },
                { "values", values }
            };
            return result;
        }

        public int Delete()
        {
            query = "DELETE FROM " + dict["table"] + 
                    " WHERE id = " + dict["id"] + ";" ;

            return conn.Execute(query);                      
        }
    }
}
