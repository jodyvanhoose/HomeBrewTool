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
        public int HoneyPounds;
        public string Additions;
        public bool IsBackSweetened = false;
        public string BackSweetenedType;


        public void BuildMeadRecipe(MeadRecipe myMead)
        {
            Console.Clear();
            TitleScreen.Title();
            Console.Write("Enter recipe name: ");
            myMead.RecipeName = Console.ReadLine();
            Console.Write("Enter Type of honey : ");
            myMead.HoneyType = Console.ReadLine();
            Console.Write("Enter amount of honey in pounds: ");
            myMead.HoneyPounds = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter batch size in gallons: ");
            try
            {
                myMead.BatchSize = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                throw new FormatException("You must enter a valid number");
            }
            Console.Write("Enter yeast: ");
            myMead.YeastType = Console.ReadLine();
            Console.WriteLine("Are you planning on BackSweetening?");
            Console.Write("Enter y for yes.....n for no:");
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
            Console.Write("Enter recipe description: ");
            myMead.Description = Console.ReadLine();

            if (myMead.Additions == "")
            {
                Console.WriteLine("No additions");
            }
            else
            {
                Console.WriteLine($"My additions are: {myMead.Additions}");
            }

            Console.Clear();
            TitleScreen.Title();
            Console.WriteLine("Mead Recipe:");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Recipe name: {myMead.RecipeName}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Honey type: {myMead.HoneyType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Honey weight: {myMead.HoneyPounds} pounds");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Recipe size: {myMead.BatchSize} gallons");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Yeast: {myMead.YeastType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"BackSweetend: {myMead.BackSweetenedType}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Other Additions: {myMead.Additions}");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine($"Recipe description: {myMead.Description}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }

    
}
