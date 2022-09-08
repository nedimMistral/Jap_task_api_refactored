using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Requests.Category;

namespace JapBackend.Core.Interfaces
{
    public interface ICategoryService
    {
        Task<List<CategoriesDto>> Get(int n);
    }
}