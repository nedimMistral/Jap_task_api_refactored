using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Ingredient;

namespace JapBackend.Core.Interfaces.Repositories
{
    public interface IIngredientRepository : IAsyncRepository<Ingredient, IngredientSearchRequest, IngredientInsertRequest, IngredientUpdateRequest, IngredientDto>
    {
        
    }
}