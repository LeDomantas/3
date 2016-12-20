using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class DataSetWritter
    {

        public static void WriteData(DataSet dataToWrite)
        {

            foreach (DataTable table in dataToWrite.Tables)
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
                Console.WriteLine("\n--------------------------");

            }
        }
    }
}
