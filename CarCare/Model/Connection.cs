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
    class Connection
    {
        string connStr = @"Data Source = "
            + Properties.Settings.Default.connectionString
            + ";foreign keys = true;datetimeformat=CurrentCulture;";

        SQLiteConnection conn;
        SQLiteCommand cmd;
        SQLiteDataReader drt;
        DataTable dtTable;

        public DataTable DtTable { get => dtTable; }

        public int Execute(String query)
        {
            int returnValue = -1000;//Error value
            try
            {
                conn = new SQLiteConnection(connStr);
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = query;
                int rowsAffected = cmd.ExecuteNonQuery();

                if (query.Substring(0, 6) == "SELECT")
                {
                    drt = cmd.ExecuteReader();
                    dtTable = new DataTable();
                    dtTable.Load(drt);
                }

                conn.Close();

                return rowsAffected;
            }
            catch (Exception e)
            {
                MessageBox.Show("O seguinte erro está impedindo o correto " +
                    "funcionamento do aplicativo: \r\n" + e.Message);
                return returnValue;
            }
        }
    }
}
