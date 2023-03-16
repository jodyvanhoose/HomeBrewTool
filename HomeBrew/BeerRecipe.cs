using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace HomeBrew
{
    public class BeerRecipe : Recipe
    {
        public bool IsExtract = false;
        public string BaseMalt;
        public decimal BaseMaltWeight;
        public bool HasAdditionalMalt = false;
        public string AdditionalMalt;
        public decimal AdditionalMaltWeight;
        public bool HasSpecialtyGrain = false;
        public string SpecialtyGrain;
        public decimal SpecialtyGrainWeight;
        public int BoilTime;
        public int HopAdditions;
        public List<string> HopType = new List<string>();
        public List<decimal> HopTime = new List<decimal>();
        public List<decimal> HopWeight = new List<decimal>();


        // User follows command prompts to enter recipe details
        public void BuildBeerRecipe(BeerRecipe myBeer)
        {
            Console.Clear();
            TitleScreen.Title();
            
            Console.Write("Enter beer style: ");
            myBeer.RecipeName = Console.ReadLine();

            //Checking for if extract recipe
            Console.WriteLine("Is this an Extract Recipe?");
            Console.Write("Extract: Enter 1.....All Grain: Enter 2: ");
            string Extract = Console.ReadLine().ToLower();
            myBeer.IsExtract = (Extract == "1");

            // Adding base malt
            Console.Write("Enter base malt: ");
            myBeer.BaseMalt = Console.ReadLine();
            Console.Write("Enter base malt weight in pounds: ");
            myBeer.BaseMaltWeight = ParseToDecimal(myBeer.BaseMaltWeight);

            // Adding any additional malts
            Console.WriteLine("Are there any additional malts?");
            Console.Write("Enter y for yes...n for no: ");

            myBeer.HasAdditionalMalt = Console.ReadLine().ToLower() == "y";
            if (HasAdditionalMalt)
            {
                Console.Write("Enter additional malt: ");
                myBeer.AdditionalMalt = Console.ReadLine();
                Console.Write("Enter additional malt weight in pounds: ");
                myBeer.AdditionalMaltWeight = ParseToDecimal(myBeer.AdditionalMaltWeight);
            }

            // Adding any additional fermentable ingredients
            Console.WriteLine("Any other additional fermentables?");
            Console.Write("Enter y for yes....n for no: ");
            myBeer.HasAdditionalFermentable = (Console.ReadLine().ToLower() == "y");
            if (HasAdditionalFermentable)
            {
                Console.Write("Enter any additional fermentables: ");
                myBeer.AdditionalFermentable = Console.ReadLine();
                Console.Write("Enter extra fermentable's weight in pounds: ");
                myBeer.AdditionalFermentableWeight = ParseToDecimal(myBeer.AdditionalFermentableWeight);
            }

            Console.Clear();
            TitleScreen.Title();

            // Adding any specialty grains if extract recipe
            if (IsExtract)
            {
                Console.WriteLine("Any specialty grains?");
                Console.Write("Enter y for yes...n for no: ");
                string Grains = Console.ReadLine();
                if (Grains == "y")
                {
                    myBeer.HasSpecialtyGrain = true;
                    Console.Write("Enter specialty grains: ");
                    myBeer.SpecialtyGrain = Console.ReadLine();
                    Console.Write("Enter specialty grains weight in ounces: ");
                    myBeer.SpecialtyGrainWeight = ParseToDecimal(myBeer.SpecialtyGrainWeight);
                }
            }


            Console.Write("Enter batch size in gallons: ");
            myBeer.BatchSize = ParseToDecimal(myBeer.BatchSize);

            Console.Write("Enter boil time in minutes: ");
            myBeer.BoilTime = ParseToInt(myBeer.BoilTime);

            Console.Clear();
            TitleScreen.Title();

            // Adding hop schedule 
            Console.Write("How many hop additons: ");
            string input;
            input = Console.ReadLine();
            myBeer.HopAdditions = int.TryParse(input, out int HopOutput) ? HopOutput : 0;

            for (int i = 0; i < myBeer.HopAdditions; i++)
            {
                
                Console.Write($"Enter number {i + 1} hop addition type: ");
                input = Console.ReadLine();
                myBeer.HopType.Add(input);

                Console.Write($"Enter number {i + 1} hop's weight in ounces: ");
                input = Console.ReadLine();
                myBeer.HopWeight.Add(decimal.TryParse(input, out decimal output) ? output : 0);

                Console.Write($"Enter number {i + 1} hop addition time: ");
                input = Console.ReadLine();
                myBeer.HopTime.Add(decimal.TryParse(input, out output) ? output : 0);
            }

            Console.Clear();
            TitleScreen.Title();

            Console.Write("Enter yeast: ");
            myBeer.YeastType = Console.ReadLine();

            Console.Write("Enter any additional notes: ");
            myBeer.Notes = Console.ReadLine();

        }


        // Displays beer recipe 
        public void DisplayBeerRecipe(BeerRecipe myBeer)
        {

            Console.Clear();

            Console.WriteLine($"Beer Style: {RecipeName}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            Console.WriteLine($"Base malt: {BaseMaltWeight}lb of {BaseMalt}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            if (HasAdditionalMalt)
            {
                Console.WriteLine($"Additional malt: {AdditionalMaltWeight}lb of {AdditionalMalt}");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }
            if (HasAdditionalFermentable)
            {
                Console.WriteLine($"Additional fermentable: {AdditionalFermentableWeight}lb of {AdditionalFermentable}");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }
            if (HasSpecialtyGrain)
            {
                Console.WriteLine($"Specialty grain: {SpecialtyGrainWeight}oz of {SpecialtyGrain}");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }
            Console.WriteLine($"Batch size: {BatchSize} gallons     Boil Time: {BoilTime} minutes");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");

            if (HopAdditions > 0)
            {
                for (int i = 0; i < HopType.Count; i++)
                {
                    if (HopTime[i] != 0)
                    {
                        Console.WriteLine($"Hop Addition: {HopWeight[i]} oz of {HopType[i]} for {HopTime[i]} minutes");
                        AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
                    }
                    else
                    {
                        Console.WriteLine($"Hop Addition: {HopWeight[i]} oz of {HopType[i]} at flame out");
                        AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
                    }
                }
            }
            Console.WriteLine($"Yeast: {YeastType}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            Console.WriteLine($"Additional notes: {Notes}");
            Console.WriteLine();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

