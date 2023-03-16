using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;

namespace HomeBrew
{
    public class MeadRecipe : Recipe
    {
        public string HoneyType;
        public decimal HoneyPounds;
        public string Additions;
        public bool IsBackSweetened = false;
        public string BackSweetenedType;


        public void BuildMeadRecipe(MeadRecipe myMead)
        {
            Console.Clear();
            TitleScreen.Title();

            Console.Write("Enter mead style: ");
            myMead.RecipeName = Console.ReadLine();

            // Adding honey type & weight
            Console.Write("Enter Type of honey: ");
            myMead.HoneyType = Console.ReadLine();
            Console.Write("Enter amount of honey in pounds: ");
            myMead.HoneyPounds = ParseToDecimal(myMead.HoneyPounds);

            // Adding any additional fermentables
            Console.WriteLine("Any other additional fermentables?");
            Console.Write("Enter y for yes....n for no: ");
            myMead.HasAdditionalFermentable = (Console.ReadLine().ToLower() == "y");

            if (HasAdditionalFermentable)
            {
                Console.Write("Enter any additional fermentables: ");
                myMead.AdditionalFermentable = Console.ReadLine();
                Console.Write("Enter extra fermentable's weight in pounds: ");
                myMead.AdditionalFermentableWeight = ParseToDecimal(myMead.AdditionalFermentableWeight);
            }
            
            Console.Write("Enter batch size in gallons: ");
            myMead.BatchSize = ParseToDecimal(myMead.BatchSize);

            Console.Write("Enter yeast: ");
            myMead.YeastType = Console.ReadLine();

            // Adding back sweetening type
            Console.WriteLine("Are you planning on BackSweetening?");
            Console.Write("Enter y for yes.....n for no: ");
            string Sweetened = Console.ReadLine().ToLower();

            if (Sweetened == "y")
            {
                myMead.IsBackSweetened = true;
            }

            if (IsBackSweetened)
            {
                Console.Write("Enter BackSweetening type: ");
                myMead.BackSweetenedType = Console.ReadLine();
            }
            else
            {
                myMead.BackSweetenedType = "No";
            }

            // Adding any other additions
            Console.Write("Enter any other additions: ");
            myMead.Additions = Console.ReadLine();

            // Adding additional notes
            Console.Write("Enter any additional notes: ");
            myMead.Notes = Console.ReadLine();
        }

        // Displaying Mead Recipe
        public void DisplayMeadRecipe(MeadRecipe myMead)
        {
            Console.Clear();

            Console.WriteLine($"Mead style: {RecipeName}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            Console.WriteLine($"Honey type: {HoneyPounds}lb of {HoneyType}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            if (myMead.HasAdditionalFermentable)
            {
                Console.WriteLine($"Additional fermentable: {AdditionalFermentableWeight}lb of {AdditionalFermentable}");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }
            Console.WriteLine($"Recipe size: {BatchSize} gallons");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            Console.WriteLine($"Yeast: {YeastType}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            Console.WriteLine($"BackSweetend: {BackSweetenedType}");
            AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            if (Additions == "" || Additions == "0")
            {
                Console.WriteLine($"Other additions: None");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }
            else
            {
                Console.WriteLine($"Other Additions: {Additions}");
                AnsiConsole.MarkupLine("[olive]-----------------------------------------------------------[/]");
            }

            if (Notes == "")
            {
                Console.WriteLine($"Additional notes: None");
            }
            else
            {
                Console.WriteLine($"Additional notes: {Notes}");
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }

    
}
