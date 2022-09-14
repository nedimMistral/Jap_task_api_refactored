using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.RecipeIngredient;

namespace JapBackend.Core.Interfaces
{
    public interface IRecipeCostService
    {
        public double CalculatePrice(List<RecipeIngredientDto> ingredients);
    }
}