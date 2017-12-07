using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    public class Item
    {
        public static int numberOfItems;
        public int num { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}\tPrice: {price}");
        }
    }

    class Food : Item
    {
        //Constructor (CREATES OBJECTS OF THE CLASS FOOD)
        public Food(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.num = ++numberOfItems;
        }
    }

    class Drink : Item
    {
        //Constructor (CREATES OBJECTS OF THE CLASS FOOD)
        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.num = ++numberOfItems;
        }
    }

    class Cigarettes : Item
    {
        //Constructor (CREATES OBJECTS OF THE CLASS FOOD)
        public Cigarettes(string name, int price)
        {
            this.name = name;
            this.price = price;
            this.num = ++numberOfItems;
        }
    }
}
