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
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoryService(ICategoryRepository categoryRepository, IHttpContextAccessor httpContextAccessor)
        {
            _categoryRepository = categoryRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public Task<List<CategoriesDto>> Get(int n)
        {
            throw new NotImplementedException();
        }
    }
}