using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            Console.WriteLine("\tAdd Funds to Shop Balance - Press [4].");
            Console.WriteLine("\tExit Application          - Press [x].\n");
            Console.WriteLine("*********************************************************\n");
            Console.WriteLine("\t↓↓↓↓ Enter Your Option ↓↓↓↓");

            Console.Write("\t");
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
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    ShopFront();
                    break;
            }
           
        }

        public static void CategoryOne()
        {
            Console.WriteLine("\tPress any button to continue.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********** Category One Products ***********\n");
            Console.WriteLine("\tProduct 1 ($10)      - Press 1 to purchase [1]");
            Console.WriteLine("\tProduct 2 ($5)       - Press 2 to purchase [2]");
            Console.WriteLine("\tProduct 3 ($5)       - Press 1 to purchase [3]");
            Console.WriteLine("\tProduct 4 ($10)      - Press 1 to purchase [4]");
            Console.WriteLine("\tReturn to Shop Front - Press [5]\n");
            Console.WriteLine("\tYour option ↓↓↓↓");

            Console.Write("\t");
            switch (Console.ReadLine())
            {
                case "1":
                    money -= 10;
                    Console.WriteLine($"\tYou have purchased product 1 for $10 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "2":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased product 2 for $5 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "3":
                    money -= 5;
                    Console.WriteLine($"\tYou have purchased product 3 for $5 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "4":
                    money -= 10;
                    Console.WriteLine($"\tYou have purchased product 4 for $10 your remaining shop funds is ${money}");
                    CategoryOne();
                    break;
                case "5":
                    ShopFront();
                    break;
                default:
                    Console.WriteLine("\tYour chosen option in invalid, choose again\n");
                    CategoryOne();
                    break;
            }

        }

        public static void CategoryTwo()
        {
            Console.Clear();
            Console.WriteLine("\tCategory Two");
        }

        public static void CategoryThree()
        {
            Console.Clear();
            Console.WriteLine("\tCategory One");
        }

        public static void AddFunds()
        {
            Console.WriteLine("\tAdd Funds ↓↓↓↓");
            money = int.Parse(Console.ReadLine()) + money;
            Console.WriteLine($"\tShop Funds available is now {money}");
            ShopFront();
        }

        static void Main(string[] args)
        {
            ShopFront();
        }
    }
}
