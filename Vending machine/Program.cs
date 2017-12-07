using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();


            vm.AddItemToList();
            vm.DisplayItems();

            //Food k = new Food("salad",21);
            //k.PrintInfo();
            
            Console.WriteLine();


            Console.WriteLine("s");
            Console.ReadKey();
        }
    }
}
