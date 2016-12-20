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
            DataSet repairShopData;
            
            repairShopData = DataPuller.PullData("RepairShop", "Client", "Vehicle", "Repair", "Mechanic");

            DataSetWritter.WriteData(repairShopData);
        }
    }
}
