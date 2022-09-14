using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Ingredient;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Services
{
    public class IngredientsService : IIngredientsService
    {
        private readonly IIngredientRepository _ingredientRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public IngredientsService(IIngredientRepository ingredientRepository, IHttpContextAccessor httpContextAccessor)
        {
           _ingredientRepository = ingredientRepository;
           _httpContextAccessor = httpContextAccessor;
        }

        public async Task<List<IngredientDto>> Get()
        {
            return await _ingredientRepository.GetAllAsync();
        }
    }
}