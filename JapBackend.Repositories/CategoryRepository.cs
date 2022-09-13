using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Category;
using JapBackend.Database;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Repositories
{
    public class CategoryRepository : BaseRepository<Category, CategorySearchRequest, CategoryInsertRequest, CategoryUpdateRequest, CategoryDto>, ICategoryRepository
    {
        public CategoryRepository(JapBackendDbContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(dbContext, mapper, httpContextAccessor)
        {
        }
    }
}