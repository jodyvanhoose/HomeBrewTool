﻿using System;
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
        public decimal BaseMaltWeight;
        public bool HasAdditionalMalt = false;
        public string AdditionalMalt;
        public decimal AdditionalMaltWeight;
        public bool HasSpecialtyGrain = false;
        public string SpecialtyGrain;
        public decimal SpecialtyGrainWeight;
        public int BoilTime;
        public int HopAdditions;
        public string[] HopTypeArray;
        public decimal[] HopWeightArray;
        public int[] HopTimeArray;



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
            myBeer.BaseMaltWeight = ParseToDecimal(myBeer.BaseMaltWeight);

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

            //string input = Console.ReadLine();

            //if (int.TryParse(input, out int boilOutput))
            //{
            //    myBeer.BoilTime = boilOutput;
            //}
            //else
            //{
            //    myBeer.BoilTime = 0;
            //}


            Console.Clear();
            TitleScreen.Title();

            Console.Write("How many hop additons: ");

            myBeer.HopAdditions = ParseToInt(myBeer.HopAdditions);

            //myBeer.HopAdditions = Convert.ToInt32(Console.ReadLine());

            myBeer.HopTypeArray = new string[myBeer.HopAdditions];
            myBeer.HopWeightArray = new decimal[myBeer.HopAdditions];
            myBeer.HopTimeArray = new int[myBeer.HopAdditions];

            for (int i = 0; i < myBeer.HopAdditions; i++)
            {
                Console.Write($"Enter number {i + 1} hop addition type: ");
                HopTypeArray[i] = Console.ReadLine();
                Console.Write($"Enter number {i + 1} hop's weight in ounces: ");
                string input = Console.ReadLine();

                if (decimal.TryParse(input, out decimal output))
                {
                    HopWeightArray[i] = output;
                }
                else
                {
                    HopWeightArray[i] = 0;
                }

                Console.Write($"Enter number {i + 1} hop addition time: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out int timeOutput))
                {
                    HopTimeArray[i] = timeOutput;
                }
                else
                {
                    HopTimeArray[i] = 0;
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
            Console.WriteLine($"Recipe name: {RecipeName}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Is Recipe extract: {IsExtract}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Base malt: {BaseMalt}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Base malt weight: {BaseMaltWeight}lb");
            Console.WriteLine("-----------------------------------------------------------");
            if (HasAdditionalMalt)
            {
                Console.WriteLine($"Additional malt: {AdditionalMalt}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Additional malt: {AdditionalMaltWeight}lb");
                Console.WriteLine("-----------------------------------------------------------");
            }
            if (HasAdditionalFermentable)
            {
                Console.WriteLine($"Additional fermentable: {AdditionalFermentable}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Additional fermentable weight: {AdditionalFermentableWeight}lb");
                Console.WriteLine("-----------------------------------------------------------");
            }
            if (HasSpecialtyGrain)
            {
                Console.WriteLine($"Specialty grain: {SpecialtyGrain}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Specialty grain weight: {SpecialtyGrainWeight}oz");
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine($"Batch size: {BatchSize} gallons");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Boil Time: {BoilTime} minutes");
            Console.WriteLine("-----------------------------------------------------------");

            if (HopAdditions > 0)
            {
                for (int i = 0; i < HopTypeArray.Length; i++)
                {
                    if (HopTimeArray[i] != 0)
                    {
                        Console.WriteLine($"Hop Addition: {HopWeightArray[i]} oz {HopTypeArray[i]} for {HopTimeArray[i]} minutes");
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine($"Hop Addition: {HopWeightArray[i]} oz {HopTypeArray[i]} at flame out");
                        Console.WriteLine("-----------------------------------------------------------");
                    }
                }
            }
            Console.WriteLine($"Yeast: {YeastType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Additional notes: {Notes}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}

