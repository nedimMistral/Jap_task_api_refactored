using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Requests.Ingredient;

namespace JapBackend.Core.Interfaces
{
    public interface IIngredientsService
    {
        Task<List<IngredientDto>> Get();
    }
}