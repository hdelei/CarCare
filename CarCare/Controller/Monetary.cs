using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CarCare.Controller
{
    class Monetary
    {
        private static double valorTotal;

        public static double ValorTotal
        {
            get { return valorTotal; }
        }

        /// <summary>
        /// Change column type to double and divide the values by 100
        /// </summary>
        /// <param name="dt">Datatable Object with integer values</param>
        /// <param name="column">index of the values column</param>
        /// <returns></returns>
        public static DataTable ValueDividedBy100(DataTable dt, int column)
        {
            List<double> price = new List<double>();
            
            foreach (DataRow row in dt.Rows)
            {               
                price.Add(Convert.ToDouble(row[column]) / 100);                
            }
            
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[column].DataType = typeof(double);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }
            
            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                dtCloned.Rows[rowIndex][column] = price[rowIndex];
            }
            
            valorTotal = price.Sum();

            return dtCloned;
        }
        
        /// <summary>
        /// Valida a entrada de valor do usuário, evitando erros de conversão de
        /// valores
        /// </summary>
        /// <param name="userEntry">Recebe um valor convertido para string. Comumente
        /// vem de um TextBox</param>
        /// <returns>Retorna o valor em string já em um formato válido</returns>
        public static string EntryValidate(string userEntry)
        {
            string validEntry;
            if (userEntry.Contains(",") || userEntry.Contains("."))
            {
                validEntry = userEntry.Replace(",", "").Replace(".", "");
            }
            else
            {
                validEntry = userEntry + "00";
            }
            return validEntry;
        }

        /// <summary>
        /// Transform decimal cell DataGrid value in integer
        /// </summary>
        /// <param name="value">Object in decimal format</param>
        /// <returns>Integer to String parsed</returns>
        public static string DecimalObjectToIntString(object value)
        {
            string valueStr = value.ToString();
            int commaIndex = valueStr.IndexOf(",");

            string subStr = "";
            if (commaIndex > -1)
            {
                subStr = valueStr.Substring(commaIndex + 1);
                if (subStr.Length == 1)
                    valueStr += "0";
            }            

            valueStr = new String(valueStr.Where(Char.IsDigit).ToArray());

            return valueStr;
        }

    }
}
