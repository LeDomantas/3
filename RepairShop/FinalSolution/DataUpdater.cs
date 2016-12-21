using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class DataUpdater
    {
        public DataUpdater()
        {
        }

        //public static void UpdateData(string connString, DataSet dataSet)
        //{

        //    SqlConnection conn = new SqlConnection(connString);

        //    // TODO: DataTable (0,1)
        //    //DataTable dataTable;
        //    // TODO: DataAdapter (0,1)
        //    SqlDataAdapter dataAdapter;
        //    //SqlCommand command;
        //    //string query;
        //    conn.Open();

        //    dataAdapter = new SqlDataAdapter();
        //    dataAdapter.Update(dataSet);
        //    //foreach (string tableName in tableNames)
        //    //{
        //    //    dataTable = new DataTable(tableName);
        //    //    // TODO: Select realizacija (0,1). REIKIA PERVADINTI KLASĘ
        //    //    query = "select * from " + tableName;
        //    //    command = new SqlCommand(query, conn);

        //    //    dataAdapter = new SqlDataAdapter(command);
        //    //    dataAdapter.Fill(dataTable);
        //        dataAdapter.Dispose();
        //    //    dataSet.Tables.Add(dataTable);
        //    //}
        //    conn.Close();
        //}

        //private static void AdapterUpdate(string connectionString, params string[] tablesToUpdate)
        //{
        //    using (SqlConnection connection =
        //               new SqlConnection(connectionString))
        //    {
        //        foreach (string tableName in tablesToUpdate)
        //        {
        //            SqlDataAdapter dataAdpater = new SqlDataAdapter(
        //              "SELECT * FROM " + tableName,
        //              connection);


        //            dataAdpater.UpdateCommand = new SqlCommand(
        //               "UPDATE " + tableName + " SET ClientID = @ClientID " +
        //               "WHERE ClientID = @ClientID", connection);

        //            dataAdpater.UpdateCommand.Parameters.Add(
        //               "@CategoryName", SqlDbType.Int, 15, "CategoryName");

        //            SqlParameter parameter = dataAdpater.UpdateCommand.Parameters.Add(
        //              "@CategoryID", SqlDbType.Int);
        //            parameter.SourceColumn = "CategoryID";
        //            parameter.SourceVersion = DataRowVersion.Original;

        //            DataTable categoryTable = new DataTable();
        //            dataAdpater.Fill(categoryTable);

        //            DataRow categoryRow = categoryTable.Rows[0];
        //            categoryRow["CategoryName"] = "New Beverages";

        //            dataAdpater.Update(categoryTable);

        //            Console.WriteLine("Rows after update.");
        //            foreach (DataRow row in categoryTable.Rows)
        //            {
        //                {
        //                    Console.WriteLine("{0}: {1}", row[0], row[1]);
        //                }
        //            }
        //        }
        //    }
        //}
    }
}
