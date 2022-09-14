using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Requests.RecipeIngredient;

namespace JapBackend.Services
{
    public class RecipeCostService : IRecipeCostService
    {
        public double CalculatePrice(List<RecipeIngredientDto> ingredients)
        {
            var totalPrice = 0.0;

            foreach (var ingredient in ingredients)
            {
                totalPrice += ingredient.Quantity * ingredient.Price;
            }

            return (double)Math.Round(totalPrice, 2);
        }
    }
}