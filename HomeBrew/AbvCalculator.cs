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
    }
}
