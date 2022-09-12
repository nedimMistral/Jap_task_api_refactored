using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Core.Requests.Ingredient
{
    public class IngredientUpdateRequest
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double UnitQuantity { get; set; }
    }
}