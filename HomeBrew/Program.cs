using System;

namespace HomeBrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program start
            Console.WriteLine("Welcome to the Pawtucket Homebrew Tool!");
            Console.WriteLine("Would you like to start building a recipe or use a homebrew tool?");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Buid a Recipe: 1");
            Console.WriteLine("Homebrew Tools: 2");
            Console.WriteLine("Exit: 0");
            Console.Write("Your input: ");
            string UserInput = Console.ReadLine();
            

            // While not exit execute this loop
            while(UserInput != "0")
            {
                // Recipe 
                if (UserInput == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Let's build a recipe.");
                }
                // Homebrew tools
                else if (UserInput == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Welcome to the homebrew tools.");
                    Console.WriteLine("Which tool do you want to use?");
                    Console.WriteLine("Brix to Specfic Gravity Converter: 1");
                    Console.WriteLine("ABV Calculator: 2");
                    Console.WriteLine("Exit: 0");
                    Console.Write("Your input: ");
                    UserInput = Console.ReadLine();
                    Console.WriteLine(UserInput);
                }
                // Invalid input
                else
                {
                    Console.WriteLine("Sorry invalid input");
                    UserInput = Console.ReadLine();
                }
            }

            // Program End
            Console.Clear();
            Console.WriteLine("Thanks for using the Homebrew Tool!");
            Console.WriteLine("Exiting Program");
            Environment.Exit(0);
            
        }
    }
}
