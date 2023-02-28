using System;

namespace HomeBrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program start

            TitleScreen.Title();
            TitleScreen.TitleMenu();

            // Variables for selecting menu options
            string UserInput = Console.ReadLine();
            string RecipeSelect = "1";
            string BrixSelect = "2";
            string AbvSelect = "3";
            string ExitProgram = "0";
            

            // Master Loop While not exit execute this loop
            while(UserInput != ExitProgram)
            {
                // Recipe 
                if (UserInput == RecipeSelect)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Console.WriteLine("Recipe Builder");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                // Homebrew tools
                else if (UserInput == BrixSelect)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Console.WriteLine("Welcome to the homebrew tools.");
                    Console.WriteLine("Brix to Specfic Gravity Converter");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }
                else if (UserInput == AbvSelect)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Console.WriteLine("Welcome to the homebew tools.");
                    Console.WriteLine("ABV Calculator");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                // Invalid input
                else
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Console.WriteLine("Sorry invalid input");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    
                    
                }
                Console.Clear();
                TitleScreen.Title();
                TitleScreen.TitleMenu();
                //Console.WriteLine("Would you like to start building a recipe or use a homebrew tool?");
                //Console.WriteLine("--------------------------");
                //Console.WriteLine("Buid a Recipe: 1");
                //Console.WriteLine("Homebrew Tools:");
                //Console.WriteLine("Brix to Specfic Gravity Converter: 2");
                //Console.WriteLine("ABV Calculator: 3");
                //Console.WriteLine("Exit: 0");
                //Console.Write("Your input: ");
                UserInput = Console.ReadLine();
            }



            // Program End
            Console.Clear();
            TitleScreen.Title();
            Console.WriteLine("Thanks for using the Homebrew Tool!");
            Console.WriteLine("Exiting Program");
            Environment.Exit(0);
            
        }
    }
}
