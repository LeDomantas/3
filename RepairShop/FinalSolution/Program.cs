using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Duombazė pagal ER diagramą iš DB kurso (0,2)
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\leDomce\Desktop\RepairSho.mdf;Integrated Security=True";

            DataSet repairShopData;
            
            repairShopData = DataSelecter.SelectData(connString, "RepairShop", "Client", "Vehicle", "Repair", "Mechanic");
            Object[] insertionClientData = new Object[] { 6, "John", "Cena", "862587511", "cant@see.me" };

            // TODO: Insert (0,1)
            DataInserter.InsertData(connString, repairShopData, "Client", insertionClientData);
            DataSetWritter.WriteData(repairShopData, "Client");

            Console.Clear();
            repairShopData = DataSelecter.SelectData(connString, "RepairShop", "Client", "Vehicle", "Repair", "Mechanic");
            DataSetWritter.WriteData(repairShopData, "Client");

            //DataSetWritter.WriteTableColumns(repairShopData, "Vehicle");

            // TODO: /insert/update/delete realizacijos (per DataAdapter)
        }
    }
}
