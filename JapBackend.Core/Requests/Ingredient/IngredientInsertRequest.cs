using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;

namespace JapBackend.Core.Requests.Ingredient
{
    public class IngredientInsertRequest
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double UnitQuantity { get; set; }
        public UOM UnitOfMeasure { get; set; }
    }
}