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
        private readonly IRecipeCostService _recipeCostService;

        public RecipesService(IRecipesRepository recipesRepository, IHttpContextAccessor httpContextAccessor, IRecipeCostService recipeCostService)
        {
            _recipesRepository = recipesRepository;
            _httpContextAccessor = httpContextAccessor;
            _recipeCostService = recipeCostService;
        }

        public async Task<RecipeDto> Details(int id)
        {
            return await _recipesRepository.GetByIdAsync(id);
        }

        public Task<List<RecipeDto>> GetRecipesByCategory(int categoryId, int n)
        {
            throw new NotImplementedException();
        }

        public async Task<RecipeDto> InsertRecipe(RecipeInsertRequest request)
        {
            request.Price = _recipeCostService.CalculatePrice(request.RecipeIngredients);
            
            return await _recipesRepository.AddAsync(request);
        }

        public Task<List<RecipeDto>> SearchRecipes(string searchTerm, int index, int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}