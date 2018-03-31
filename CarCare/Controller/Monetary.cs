using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CarCare.Controller
{
    class Monetary
    {
        private static decimal valorTotal;

        public static decimal ValorTotal
        {
            get { return valorTotal; }
        }

        public static DataTable DtColumnIntToDecimal(DataTable dt, int column)
        {
            List<decimal> price = new List<decimal>();
            //Gerar lista de valores em decimal
            foreach (DataRow row in dt.Rows)
            {   
                price.Add((decimal)row[column]/100);
            }

            //clonar o datatable, transformando a coluna em decimal
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[column].DataType = typeof(decimal);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }

            //Inserir valores em decimal
            for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
            {
                dtCloned.Rows[rowIndex][column] = price[rowIndex];
            }

            //gera a soma de todos os valores 
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

    }
}
