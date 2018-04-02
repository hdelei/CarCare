using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarCare
{
    /// <summary>
    /// Esta classe tem por finalidade iniciar o banco de dados padrão
    /// no primeiro uso do sistema
    /// </summary>
    static class SQLiteDB
    {
        /// <summary>
        /// Método responsável por criar um banco de dados automaticamente, caso não 
        /// encontre nenhum na pasta do aplicativo
        /// </summary>
        /// <param name="connectionString">Passar a string de conexão faz com que 
        /// o método verifique se o arquivo existe. O padrão em Properties.Settings é:
        /// "SQLiteDB.db"</param>
        /// <returns>Retorna uma mensagem de sucesso ou de erro como resultado</returns>
        public static string Create(string connectionString)
        {
            string returnStr = string.Empty;
            if (!File.Exists(connectionString))
            {
                System.Windows.Forms.MessageBox.Show("Banco de dados não encontrado. " +
                    "Um novo BD foi criado automaticamente!", "Informação");
                try
                {
                    SQLiteConnection.CreateFile("CarCare.db");
                    SQLiteConnection m_dbConnection;
                    m_dbConnection = new SQLiteConnection("Data Source=CarCare.db;Version=3;");
                    m_dbConnection.Open();
                    string sql = CreateQuery();
                    SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    sql = InsertQuery();
                    command = new SQLiteCommand(sql, m_dbConnection);
                    command.ExecuteNonQuery();
                    m_dbConnection.Close();

                    //Se um novo BD for gerado, a string de conexão volta ao padrão
                    Properties.Settings.Default.connectionString = "CarCare.db";

                    returnStr = "New DB Created successfuly!";
                }
                catch (Exception e)
                {
                    returnStr = e.Message;
                }
            }
            return returnStr;
        }
        /// <summary>
        /// Método auxiliar que organiza a query de criação das tabelas
        /// </summary>
        /// <returns>Retorna a query pronta para o BD</returns>
        private static string CreateQuery()
        {
            string query = @"CREATE TABLE          Vehicle (
                id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
                type            TEXT NOT NULL DEFAULT carro,
                model                         TEXT NOT NULL,
                manufacturer                           TEXT,
                plate                                  TEXT,
                year             NUMERIC DEFAULT (2000));" ;

            query += @"CREATE TABLE                Service (
                id INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE,
                vehicleID   INTEGER REFERENCES Vehicle (id),
                exec_date                              DATE,
                description                   TEXT NOT NULL,
                executor                               TEXT,
                current_km                          NUMERIC,
                value                               NUMERIC,
                next_km                             NUMERIC,
                next_date                              DATE,
                status                              TEXT);";

            return query;
        }
        /// <summary>
        /// Método auxiliar que organiza a query de criação das tabelas
        /// </summary>
        /// <returns>Retorna a query pronta para o BD</returns>
        private static string InsertQuery()
        {
            string query = @"
                   INSERT INTO Vehicle
                   ( id, 
                     type, 
                     model,
                     manufacturer, 
                     plate, 
                     year )
                   VALUES  
                   ( null, 
                     'Carro', 
                     'Grand Siena', 
                     'Fiat',
                     'DEV 4242', 
                     '2014' );";            

            return query;
        }
    }
}
