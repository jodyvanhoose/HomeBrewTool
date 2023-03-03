using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public class Menu
    {
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to the Pawtucket Homebrew Tool!");
            Console.WriteLine("Would you like to start building a recipe or use a homebrew tool?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Buid a Recipe:     Press 1");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Brix to Specfic");
            Console.WriteLine("Gravity Converter: Press 2");
            Console.WriteLine("--------------------------");
            Console.WriteLine("ABV Calculator:    Press 3");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Exit:              Press 0");
            Console.WriteLine("--------------------------");
            Console.Write("Your input: ");
        }

        public static void AbvMenu()
        {
            Console.WriteLine("Welcome to the homebew tools.");
            Console.WriteLine("ABV Calculator");
            Console.WriteLine();
            Console.WriteLine("Please choose your choice of measurement");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Specfic Gravity  1");
            Console.WriteLine("------------------");
            Console.WriteLine("Brix:            2");
            Console.WriteLine("------------------");
            Console.Write("Your input: ");
        }

        public static void BrixConverterMenu()
        {
            Console.WriteLine("Welcome to the homebrew tools.");
            Console.WriteLine("Brix to Specfic Gravity Converter");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your Brix reading: ");
        }
    }
}
