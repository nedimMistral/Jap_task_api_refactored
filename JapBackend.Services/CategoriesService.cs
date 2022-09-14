using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Category;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Services
{
    public class CategoriesService : ICategoriesService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoriesService(ICategoryRepository categoryRepository, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        public async Task<List<CategoryDto>> Get(int n)
        {
            return await _categoryRepository.GetAllWithLimitAsync(n);
        }
    }
}