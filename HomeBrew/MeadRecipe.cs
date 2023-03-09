using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public class MeadRecipe : Recipe
    {
        public string HoneyType;
        public decimal? HoneyPounds;
        public string Additions;
        public bool IsBackSweetened = false;
        public string BackSweetenedType;


        public void BuildMeadRecipe(MeadRecipe myMead)
        {
            Console.Clear();
            TitleScreen.Title();
            Console.Write("Enter recipe name: ");
            myMead.RecipeName = Console.ReadLine();
            Console.Write("Enter Type of honey: ");
            myMead.HoneyType = Console.ReadLine();
            Console.Write("Enter amount of honey in pounds: ");
            myMead.HoneyPounds = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Any other additional fermentables?");
            Console.Write("Enter y for yes....n for no: ");
            myMead.HasAdditionalFermentable = (Console.ReadLine().ToLower() == "y");
            if (HasAdditionalFermentable)
            {
                Console.Write("Enter any additional fermentables: ");
                myMead.AdditionalFermentable = Console.ReadLine();
                Console.Write("Enter extra fermentable's weight in pounds: ");
                myMead.AdditionalFermentableWeight = Convert.ToDecimal(Console.ReadLine());
            }
            
            Console.Write("Enter batch size in gallons: ");
            myMead.BatchSize = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter yeast: ");
            myMead.YeastType = Console.ReadLine();
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
            Console.Write("Enter any additions: ");
            myMead.Additions = Console.ReadLine();
            Console.Write("Enter any additional notes: ");
            myMead.Notes = Console.ReadLine();

            if (myMead.Additions == "")
            {
                Console.WriteLine("No additions");
            }
            else
            {
                Console.WriteLine($"My additions are: {Additions}");
            }
        }

        public void DisplayMeadRecipe(MeadRecipe myMead)
        {
            Console.Clear();
            TitleScreen.Title();
            Console.WriteLine("Mead Recipe:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Recipe name: {RecipeName}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Honey type: {HoneyType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Honey weight: {HoneyPounds} pounds");
            Console.WriteLine("-----------------------------------------------------------");
            if (myMead.HasAdditionalFermentable)
            {
                Console.WriteLine($"Additional fermentable: {AdditionalFermentable}");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"Additional fermentable weight: {AdditionalFermentableWeight} pounds");
                Console.WriteLine("-----------------------------------------------------------");
            }
            Console.WriteLine($"Recipe size: {BatchSize} gallons");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Yeast: {YeastType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"BackSweetend: {BackSweetenedType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Other Additions: {Additions}");
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
