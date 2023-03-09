using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public class BeerRecipe : Recipe
    {
        public bool IsExtract = false;
        public string BaseMalt;
        public decimal? BaseMaltWeight;
        public bool HasAdditionalMalt = false;
        public string AdditonalMalt;
        public decimal? AdditonalMaltWeight;
        public bool HasSpecialtyGrain = false;
        public string SpecialtyGrain;
        public decimal? SpecialtyGrainWeight;
        public int BoilTime;
        public int HopAdditions;
        public string[] HopTypeArray;
        public decimal[] HopWeightArray;
        public int[] HopTimeArray;
        public bool FlameOut = false;



        public void BuildBeerRecipe(BeerRecipe myBeer)
        {
            Console.Clear();
            TitleScreen.Title();
            Console.Write("Enter recipe name: ");
            myBeer.RecipeName = Console.ReadLine();
            Console.WriteLine("Is this an Extract Recipe?");
            Console.Write("Extract: Enter 1.....All Grain: Enter 2: ");
            string Extract = Console.ReadLine().ToLower();
            myBeer.IsExtract = (Extract == "1");
            Console.Write("Enter base malt: ");
            myBeer.BaseMalt = Console.ReadLine();
            Console.Write("Enter base malt weight in pounds: ");
            myBeer.BaseMaltWeight = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Are there any additional malts?");
            Console.Write("Enter y for yes...n for no: ");
            string MoreMalt = Console.ReadLine().ToLower();
            if (MoreMalt == "y")
            {
                myBeer.HasAdditionalMalt = true;
                Console.Write("Enter additional malt: ");
                myBeer.AdditonalMalt = Console.ReadLine();
                Console.Write("Enter additional malt weight in pounds: ");
                myBeer.AdditonalMaltWeight = Convert.ToDecimal(Console.ReadLine());
            }
            Console.Clear();
            TitleScreen.Title();

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
                    myBeer.SpecialtyGrainWeight = Convert.ToDecimal(Console.ReadLine());
                }
            }
            Console.Write("Enter boil time in minutes: ");
            myBeer.BoilTime = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            TitleScreen.Title();

            Console.Write("How many hop additons: ");
            myBeer.HopAdditions = Convert.ToInt32(Console.ReadLine());

            myBeer.HopTypeArray = new string[myBeer.HopAdditions];
            myBeer.HopWeightArray = new decimal[myBeer.HopAdditions];
            myBeer.HopTimeArray = new int[myBeer.HopAdditions];

            for (int i = 0; i < myBeer.HopAdditions; i++)
            {
                Console.Write($"Enter number {i + 1} hop addition type: ");
                HopTypeArray[i] = Console.ReadLine();
                Console.Write($"Enter number {i + 1} hop's weight in ounces: ");
                HopWeightArray[i] = Convert.ToDecimal(Console.ReadLine());
                Console.Write($"Enter number {i + 1} hop addition time: ");
                HopTimeArray[i] = Convert.ToInt32(Console.ReadLine());
                if (HopTimeArray[i] == 0)
                {
                    FlameOut = myBeer.IsFlameOut();
                }
            }

            Console.Clear();
            TitleScreen.Title();

            Console.Write("Enter yeast: ");
            myBeer.YeastType = Console.ReadLine();
            Console.Write("Enter any additional notes: ");
            myBeer.Notes = Console.ReadLine();

        }

        public void DisplayBeerRecipe(BeerRecipe myBeer)
        {
            Console.Clear();
            TitleScreen.Title();
            Console.WriteLine("Beer Recipe:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Recipe name: {myBeer.RecipeName}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Is Recipe extract: {myBeer.IsExtract}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Base malt: {myBeer.BaseMalt}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Base malt weight: {myBeer.BaseMaltWeight}lb");
            Console.WriteLine("-----------------------------------------------------------");
            if (HasAdditionalMalt)
            {
                Console.WriteLine($"Additional malt: {myBeer.AdditonalMalt}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Additional malt: {myBeer.AdditonalMaltWeight}lb");
                Console.WriteLine("-----------------------------------------------------------");
            }
            if (HasSpecialtyGrain)
            {
                Console.WriteLine($"Specialty grain: {myBeer.SpecialtyGrain}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Specialty grain weight: {myBeer.SpecialtyGrainWeight}oz");
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine($"Boil Time: {myBeer.BoilTime} minutes");
            Console.WriteLine("-----------------------------------------------------------");

            if (HopAdditions > 0)
            {
                for (int i = 0; i < HopTypeArray.Length; i++)
                {
                    if (HopTimeArray[i] != 0)
                    {
                        Console.WriteLine($"Hop Addition: {myBeer.HopWeightArray[i]} oz {myBeer.HopTypeArray[i]} for {myBeer.HopTimeArray[i]} minutes");
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"Hop Addition: {myBeer.HopWeightArray[i]} oz {myBeer.HopTypeArray[i]} at flame out");
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                }
            }
            Console.WriteLine($"Yeast: {myBeer.YeastType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Additional notes: {myBeer.Notes}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public bool IsFlameOut()
        {
             return true;
        }
    }
}
