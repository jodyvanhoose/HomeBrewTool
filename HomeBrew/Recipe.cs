using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeBrew
{
    public class Recipe
    {
        public string RecipeName;
        public int BatchSize = 0;
        public string YeastType;
        public string Notes;
        public string AdditionalFermentable;
        public int AdditionalFermentableWeight;
    }
}
