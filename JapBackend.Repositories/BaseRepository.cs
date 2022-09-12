
using JapBackend.Common;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Database;
using JapBackend.Repositories.Extensions;
using JapBackend.Core.Entities.Base;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;


namespace JapBackend.Repositories
{
    public class BaseRepository<TEntity, TSearch, TInsert, TUpdate, TDto> : IAsyncRepository<TEntity, TSearch, TInsert, TUpdate, TDto>
        where TEntity : class, new()
        where TSearch : BaseSearch, new()
    {
        public virtual int DefaultPageSize { get; set; } = 10;
        private readonly JapBackendDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseRepository(JapBackendDbContext dbContext,
                              IMapper mapper,
                              IHttpContextAccessor httpContextAccessor)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<TDto> AddAsync(TInsert entity, bool saveChanges = true)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var insert = _mapper.Map<TEntity>(entity) as AuditableEntity;

            if (insert is AuditableEntity)
            {
                insert.CreatedById = currentUserId;
                insert.ModifiedById = currentUserId;
            }

            await _dbContext.Set<TEntity>().AddAsync(insert as TEntity);

            if (saveChanges)
            {
                await _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<TDto>(insert);
        }

        public async Task<List<TDto>> AddBulkAsync(List<TInsert> entities, bool saveChanges = true)
        {
            var currentUserId = int.Parse(_httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            var insertList = new List<TEntity>();

            foreach (var entity in entities)
            {
                var insert = _mapper.Map<TEntity>(entity) as AuditableEntity;

                if (insert is AuditableEntity)
                {
                    insert.CreatedById = currentUserId;
                    insert.ModifiedById = currentUserId;
                }

                insertList.Add(insert as TEntity);
            }

            await _dbContext.Set<TEntity>().AddRangeAsync(insertList);

            if (saveChanges)
            {
                await _dbContext.SaveChangesAsync();
            }

            return _mapper.Map<List<TDto>>(insertList);
        }

        public async Task DeleteAsync(object id, bool saveChanges = true)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Remove(entity);

            if (saveChanges)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task<TDto> GetByIdAsync(object id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            return _mapper.Map<TDto>(entity);
        }

        public async Task<PagedResult<TDto>> GetPageAsync(TSearch search)
        {
            if (search == null)
            {
                search = new TSearch();
            }

            PagedResult<TDto> result = new PagedResult<TDto>();

            var query = await GetAsync(search);
            if (search.IncludeCount.GetValueOrDefault(false) == true)
            {
                result.Count = await GetCountAsync(query);
            }

            AddPaging(search, ref query);
            var res = await query.ToListAsync();

            result.Results = _mapper.Map<IReadOnlyList<TDto>>(res);

            return result;
        }

        public async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task SoftDeleteAsync(object id, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public async Task<TDto> UpdateAsync(object id, TUpdate entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        protected virtual async Task<IQueryable<TEntity>> GetAsync(TSearch search)
        {
            var query = _dbContext.Set<TEntity>().AsQueryable();
            if (!string.IsNullOrEmpty(search.Includes))
            {
                AddInclude(search, ref query);
            }
            query = await AddFilterAsync(search, query);
            AddOrder(search, ref query);
            return await Task.FromResult(query);
        }

        protected virtual void AddInclude(TSearch search, ref IQueryable<TEntity> query)
        {
            var includes = search.Includes.Split(",");
            query = includes.Aggregate(query, (current, include) => current.Include(include));
        }

        protected virtual void AddPaging(TSearch search, ref IQueryable<TEntity> query)
        {
            if (!search.RetrieveAll.GetValueOrDefault(false) == true)
            {
                if (search.Page < 1)
                    search.Page = 1;

                query = query.Skip((search.Page.GetValueOrDefault(1) - 1)
                    * search.PageSize.GetValueOrDefault(DefaultPageSize))
                    .Take(search.PageSize.GetValueOrDefault(DefaultPageSize));
            }
        }

        protected virtual async Task<long> GetCountAsync(IQueryable<TEntity> query)
        {
            return await query.LongCountAsync();
        }

        protected virtual async Task<IQueryable<TEntity>> AddFilterAsync(TSearch search, IQueryable<TEntity> query)
        {
            AddFilterFromSearchObject(search, ref query);
            return await Task.FromResult(query);
        }

        protected virtual void AddFilterFromSearchObject(TSearch search, ref IQueryable<TEntity> query)
        {

        }

        protected virtual void AddOrder(TSearch search, ref IQueryable<TEntity> query)
        {
            if (!string.IsNullOrWhiteSpace(search.SortBy))
            {
                if (search.SortOrder == SortOrder.ASC)
                {
                    query = query.OrderBy(search.SortBy);
                }
                else
                {
                    query = query.OrderByDescending(search.SortBy);
                }
            }
        }
    }
}