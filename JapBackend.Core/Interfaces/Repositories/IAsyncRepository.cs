using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Common;

namespace JapBackend.Core.Interfaces.Repositories
{
    public interface IAsyncRepository<TEntity, TSearch, TInsert, TUpdate, TDto>
        where TSearch : BaseSearch
        where TEntity : class
    {
        Task<TDto> GetByIdAsync(object id);
        Task<PagedResult<TDto>> GetPageAsync(TSearch search);
        Task<TDto> AddAsync(TInsert entity, bool saveChanges = true);
        Task<List<TDto>> AddBulkAsync(List<TInsert> entities, bool saveChanges = true);
        Task<TDto> UpdateAsync(object id, TUpdate entity, bool saveChanges = true);
        Task DeleteAsync(object id, bool saveChanges = true);
        Task SoftDeleteAsync(object id, bool saveChanges = true);
        Task SaveChangesAsync();

        Task<List<TDto>> GetAllAsync();
        Task<List<TDto>> GetAllWithLimitAsync(int n);
    }
}