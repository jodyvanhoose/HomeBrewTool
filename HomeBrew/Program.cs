using System;

namespace HomeBrew
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program start

            TitleScreen.Title();
            Menu.MainMenu();

            // Variables for selecting menu options
            string UserInput = Console.ReadLine();
            string RecipeSelect = "1";
            string BrixSelect = "2";
            string AbvSelect = "3";
            string ExitProgram = "0";
            

            // Master Loop - While not exit - execute this loop
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

                // Brix Converter
                else if (UserInput == BrixSelect)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Menu.BrixConverterMenu();

                    double BrixReading = Convert.ToDouble(Console.ReadLine());
                    var brixConversion = new BrixConverter();
                    string BrixToGravityReading = brixConversion.BrixToSpecficGravity(BrixReading).ToString("0.000");
                    Console.WriteLine($"Your Brix reading of {BrixReading} is {BrixToGravityReading} specfic gravity.");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();

                }

                // ABC calculator
                else if (UserInput == AbvSelect)
                {
                    Console.Clear();
                    TitleScreen.Title();
                    Menu.AbvMenu();
                    string AbvUserInput = Console.ReadLine().ToLower();
                    string SpecficGravityMeasurement = "1";
                    string BrixMeasurement = "2";
                    string ExitToMainMenu = "0";

                    if (AbvUserInput == SpecficGravityMeasurement)
                    {
                        AbvCalculator.SpecficGravityAbv();
                    }
                    else if(AbvUserInput == BrixMeasurement)
                    {
                        AbvCalculator.BrixAbv();
                    }
                    else if(AbvUserInput == ExitToMainMenu)
                    {
                        return;
                    }
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
                    Menu.AbvMenu();
                    AbvUserInput = Console.ReadLine();
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
                Menu.MainMenu();
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
