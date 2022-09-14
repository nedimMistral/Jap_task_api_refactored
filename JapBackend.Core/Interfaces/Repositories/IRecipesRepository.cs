using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Recipe;

namespace JapBackend.Core.Interfaces.Repositories
{
    public interface IRecipesRepository : IAsyncRepository<Recipe, RecipeSearchRequest, RecipeInsertRequest, RecipeUpdateRequest, RecipeDto>
    {
        
    }
}