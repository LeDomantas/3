using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class DataSelecter
    {
      
        public DataSelecter()
        {
        }

        public static DataSet SelectData(string connString, string dataSetName, params string[] tableNames)
        {
            DataSet dataSet = new DataSet(dataSetName);

            SqlConnection conn = new SqlConnection(connString);
           
            // TODO: DataTable (0,1)
            DataTable dataTable;
            // TODO: DataAdapter (0,1)
            SqlDataAdapter dataAdapter;
            SqlCommand command;
            string query;
            conn.Open();
            foreach (string tableName in tableNames)
            {
                dataTable = new DataTable(tableName);
                // TODO: Select realizacija (0,1). REIKIA PERVADINTI KLASĘ
                query = "select * from " + tableName;
                command = new SqlCommand(query, conn);
                
                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                dataAdapter.Dispose();
                dataSet.Tables.Add(dataTable);                
            }
            conn.Close();
            return dataSet;
        }
    }
}
