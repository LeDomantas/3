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

        public static void WriteData(DataSet dataToWrite, params string[] printTables)
        {

            foreach (DataTable table in dataToWrite.Tables)
            {
                foreach (string tableName in printTables)
                {
                    if (tableName == table.TableName)
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

        public static void WriteTableColumns(DataSet dataToWrite, params string[] printTables)
        {
            foreach (DataTable table in dataToWrite.Tables)
            {
                foreach (string needsPrinting in printTables)
                {
                    if (table.TableName == needsPrinting)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.Write(column.ColumnName + '\t');
                        }
                        Console.WriteLine();
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.Write(column.DataType.ToString() + '\t');
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
