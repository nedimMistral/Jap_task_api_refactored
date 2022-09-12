using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;
using JapBackend.Core.Requests.Ingredient;
using JapBackend.Core.Requests.Recipe;

namespace JapBackend.Core.Requests.RecipeIngredient
{
    public class RecipeIngredientDto
    {
        public int Id { get; set; }
        public string IngredientName { get; set; }
        public int IngredientId { get; set; }
        public IngredientDto Ingredient { get; set; }
        public int RecipeId { get; set; }
        public RecipeDto Recipe { get; set; }
        public double Quantity { get; set; }
        public double Price { get; set; }
        public UOM MeasureUnit { get; set; }
    }
}