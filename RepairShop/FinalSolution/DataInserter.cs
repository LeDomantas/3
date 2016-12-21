using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class DataInserter
    {
        public DataInserter()
        {
        }

        public static void InsertData(string connString, DataSet insertionSet, string insertionTableName, Object[] insertionData)
        {
            SqlConnection conn = new SqlConnection(connString);

            conn.Open();
            foreach (DataTable table in insertionSet.Tables)
            {
                if (table.TableName == insertionTableName)
                {
                    table.Rows.Add(insertionData);
                }
            }
            conn.Close();
        }

    }
}
