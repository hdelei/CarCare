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

        public DataTable Select()
        {            
            String query = @"SELECT * FROM " + dict["table"] + " LIMIT 30;";
            Connection conn = new Connection();
            conn.Execute(query);
            return conn.DtTable;

            //Console.WriteLine(conn.Execute(query));
            //Console.WriteLine(conn.DtTable.Rows[0][2].ToString());
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
