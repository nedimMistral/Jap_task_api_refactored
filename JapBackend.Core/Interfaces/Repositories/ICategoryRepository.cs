using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Category;

namespace JapBackend.Core.Interfaces.Repositories
{
    public interface ICategoryRepository : IAsyncRepository<Category, CategorySearchRequest, CategoryInsertRequest, CategoryUpdateRequest, CategoriesDto>
    {
    }
}