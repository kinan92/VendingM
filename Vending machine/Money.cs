using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_machine
{
    class Money
    {
        public int[] coin = new int[8];
        public int Credits;

        public Money()
        {
            coin[0] = 1;        //1
            coin[1] = 5;        //2
            coin[2] = 10;       //3
            coin[3] = 20;       //4
            coin[4] = 50;       //5
            coin[5] = 100;      //6
            coin[6] = 500;      //7
            coin[7] = 1000;     //8
        }

        public void InsertMoney()
        {
            foreach (int valueCoin in coin)
            {
                Console.Write($"{valueCoin}Kr ");
            }
            Console.WriteLine();
            int num = 0;
            bool moreCoins = true;                                  // to return the money to get your money 
            while (moreCoins)
            {
                Console.Write("pleas insert the money: ");
                string numStr = Console.ReadLine();


                if (int.TryParse(numStr, out num))
                {
                    ////    Console.Beep();                      //
                    ////    Console.Beep(1000, 700);             // to make the voice
                    ////    Console.Beep(440, 700);               //
                    num = Math.Abs(num);
                    moreCoins = MoneyI(num);                         // to get the money
                    Console.WriteLine("Credits: " + Credits); 
                }
            }
            //return num;
        }

        public bool MoneyI(int userSelection)  // chose and return until the user want  
        {
            switch (userSelection)
            {
                case 1:
                    Credits = Credits + coin[0];
                    break;
                case 2:
                    Credits += coin[1];
                    break;
                case 3:
                    Credits += coin[2];
                    break;
                case 4:
                    Credits += coin[3];
                    break;
                case 5:
                    Credits += coin[4];
                    break;
                case 6:
                    Credits += coin[5];
                    break;
                case 7:
                    Credits += coin[6];
                    break;
                case 8:
                    Credits += coin[7];
                    break;
                default:
                    return false;
            }
            return true;
        }



    }
}
