using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Requests.Recipe;

namespace JapBackend.Core.Interfaces
{
    public interface IRecipesService
    {
        Task<RecipeDto> InsertRecipe(RecipeInsertRequest request);
    }
}