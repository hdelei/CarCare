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
            query = @"SELECT * FROM Vehicle WHERE id = "+ dict["id"] +";";
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
            query = @"SELECT * FROM Service WHERE vehicleID = " + dict["id"] + ";";
            //Connection conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;            
        }

        /// <summary>
        /// Update data with current dict information
        /// </summary>
        /// <returns>number of rows affected</returns>
        public int Update()
        {
            query = "UPDATE " + dict["table"] +
                    " SET " + ColumnValues() + 
                    " WHERE id = " + dict["id"] + ";";           

            return conn.Execute(query);           
        }

        /// <summary>
        /// Filter dictionary joining strings for sqlite format
        /// </summary>
        /// <returns>String. Example "table1='value1', table2='value2'"</returns>
        private string ColumnValues()
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

        public int Insert()
        {
            //use dict object to fill query
            return 0;
        }

        public int Delete()
        {
            //use dict object to fill query
            return 0;
        }


    }
}
