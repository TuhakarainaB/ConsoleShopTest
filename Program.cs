using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleShop
{
    internal class Program
    {
        // Global class variables
        public static int money = 100;

        public static void ShopFront()
        {
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine($"\tYour current shop balance is [${money}].\n");
            Console.WriteLine("\tShop Category 1           - Press [1].");
            Console.WriteLine("\tShop Category 2           - Press [2].");
            Console.WriteLine("\tShop Category 3           - Press [3].");
            Console.WriteLine("\tAdd Funds to Shop Balance - Press [4].\n");
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");

            switch(Console.ReadLine())
            {
                case "1":
                    CategoryOne();
                    break;
                case "2":
                    CategoryTwo();
                    break;
                case "3":
                    CategoryThree();
                    break;
                case "4":
                    AddFunds();
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    ShopFront();
                    break;
            }
           
        }

        public static void CategoryOne()
        {
            Console.WriteLine("\tCategory One");
        }

        public static void CategoryTwo()
        {
            Console.WriteLine("\tCategory Two");
        }

        public static void CategoryThree()
        {
            Console.WriteLine("\tCategory One");
        }

        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds");
        }

        static void Main(string[] args)
        {
            ShopFront();
            Console.ReadKey();
        }
    }
}
