using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public class AbvCalculator
    {
        public double CalculateABV(double og, double fg)
        {
            // Calculates the ABV from the original gravity and final gravity
            double ABV = ABV = (og - fg) * 131.25;
            return ABV;
        }

        // Brix converted to Specfic Gravity first and then calcualte abv
        public static void BrixAbv()
        {
            Console.Clear();
            TitleScreen.Title();
            Console.Write("Enter your inital Brix reading: ");
            double InitalBrixReading = Convert.ToDouble(Console.ReadLine());
            var firstBrixReading = new BrixConverter();
            double OriginalGravity = firstBrixReading.BrixToSpecficGravity(InitalBrixReading);
            Console.Write("Enter your Final Brix reading: ");
            double FinalBrixReading = Convert.ToDouble(Console.ReadLine());
            var secondBrixReading = new BrixConverter();
            double FinalGravity = secondBrixReading.BrixToSpecficGravity(FinalBrixReading);
            var abvCalc = new AbvCalculator();
            string ABV = abvCalc.CalculateABV(OriginalGravity, FinalGravity).ToString("0.0");
            Console.WriteLine($"Your brew's approximate alcohol: {ABV}%");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        // Specfic Gravity calculate abv
        public static void SpecficGravityAbv()
        {
            Console.Clear();
            TitleScreen.Title();
            Console.Write("Enter your Original Gravity reading: ");
            double OriginalGravity = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Final Gravity reading: ");
            double FinalGravity = Convert.ToDouble(Console.ReadLine());
            var abvCalc = new AbvCalculator();
            string ABV = abvCalc.CalculateABV(OriginalGravity, FinalGravity).ToString("0.0");
            Console.WriteLine($"Your brew's approximate alcohol: {ABV}%");

            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
