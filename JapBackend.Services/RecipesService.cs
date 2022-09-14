using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Recipe;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RecipesService(IRecipesRepository recipesRepository, IHttpContextAccessor httpContextAccessor)
        {
            _recipesRepository = recipesRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<RecipeDto> InsertRecipe(RecipeInsertRequest request)
        {
            return await _recipesRepository.AddAsync(request);
        }
    }
}