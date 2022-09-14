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
        Task<List<RecipeDto>> GetRecipesByCategory(int categoryId, int n);
        Task<List<RecipeDto>> SearchRecipes(string searchTerm, int index, int categoryId);
        Task<RecipeDto> Details(int id);
    }
}