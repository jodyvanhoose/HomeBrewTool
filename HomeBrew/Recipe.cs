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
        public decimal? BatchSize = 0;
        public string YeastType;
        public string Notes;
        public bool HasAdditionalFermentable;
        public string AdditionalFermentable;
        public decimal? AdditionalFermentableWeight;
    }
}
