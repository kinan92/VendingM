using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{

    class VendingMachine
    {
        //Class Members
        
        public Money money = new Money();
        Food meat = new Food("Meat", 75);
        Food spaghetti = new Food("Spaghetti", 50);
        Food salad = new Food("Salad", 25);
        Drink coffee = new Drink("Coffee", 15);
        Drink vodka = new Drink("Vodka", 45);
        Drink milk = new Drink("Milk", 13);
        Cigarettes marlboro = new Cigarettes("Cigarettes" ,53);
        Cigarettes malboro = new Cigarettes("Malboro",25);
        Cigarettes winston = new Cigarettes("Winstone", 52);
        List<Item> listOfItems = new List<Item>();

        public void AddItemToList()
        {
            listOfItems.AddRange (new List<Item>{meat,spaghetti,salad,coffee,vodka,milk,marlboro,malboro,winston});        //list of all the item    


        }
        public void DisplayItems()
        {
            foreach(Item item in listOfItems)
            {
                
                Console.WriteLine(item.num + ": " + item.name + "    " + item.price);
            }
            string chose = Console.ReadLine();
            
            switch(chose) // chose the item (operitor) number
            {
                case "1":
                    money.InsertMoney();
                    if (money.Credits >= meat.price)
                    {
                        Console.WriteLine("you can eat the meat :)");
                        Console.WriteLine(money.Credits - meat.price);
                    }
                    else
                    {
                        Console.WriteLine("you dont have enough");
                        Console.ReadKey();
                    }
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "7":
                    break;
                case "8":
                    break;
                case "9":
                    break;
               

            }


        }    
        
    }
}
