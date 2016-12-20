using System;
using System.Data;
using System.Data.SqlClient;


namespace ConsoleApplication1
{
    public class PullDataTest
    {
        // your data table
        private DataTable dataTable = new DataTable();
        private DataSet dataSet = new DataSet();

        public PullDataTest()
        {
        }

        // your method to pull data from database to datatable   
        public void PullData()
        {
            string query = "select * from Client";

            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leDomce\Desktop\RepairSho.mdf;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);            

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(dataSet);
            da.Fill(dataTable);
            conn.Close();
            var columns = dataTable.Columns;
            foreach (DataTable table in dataSet.Tables)
            {
                Console.WriteLine(table + "\n");
                foreach (DataColumn col in table.Columns)
                {
                    Console.Write(col + "\t");
                }
                foreach (DataRow row in table.Rows)
                {
                    Console.WriteLine("\t\t");
                    foreach (var rowValue in row.ItemArray)
                    {
                        Console.Write(rowValue + "\t");
                    }
                }

            }
            da.Dispose();
        }
    }
}
