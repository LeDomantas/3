using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class DataPuller
    {
      
        public DataPuller()
        {
        }

        public static DataSet PullData(string dataSetName, params string[] tableNames)
        {
            DataSet dataSet = new DataSet(dataSetName);
            
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leDomce\Desktop\RepairSho.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);

            DataTable dataTable;
            SqlDataAdapter dataAdapter;
            SqlCommand command;
            string query;
            conn.Open();
            foreach (string tableName in tableNames)
            {
                dataTable = new DataTable(tableName);
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
