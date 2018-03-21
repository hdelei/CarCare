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

        public Sql(Dictionary<String, String> dict)
        {
            this.dict = dict;
        }

        public DataTable SelectVehicle()
        {            
            String query = @"SELECT * FROM Vehicle WHERE id = "+ dict["id"] +";";
            Connection conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;            
        }

        public DataTable SelectServices()
        {
            String query = @"SELECT * FROM Service WHERE vehicleID = " + dict["id"] + ";";
            Connection conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;            
        }

        public int Update()
        {
            //use dict object to fill query
            return 0;
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
