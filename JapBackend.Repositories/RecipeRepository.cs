using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Recipe;
using JapBackend.Database;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Repositories
{
    public class RecipeRepository : BaseRepository<Recipe, RecipeSearchRequest, RecipeInsertRequest, RecipeUpdateRequest, RecipeDto>, IRecipesRepository
    {
        public RecipeRepository(JapBackendDbContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(dbContext, mapper, httpContextAccessor)
        {
        }

        protected override void AddFilterFromSearchObject(RecipeSearchRequest search, ref IQueryable<Recipe> query)
        {
            base.AddFilterFromSearchObject(search, ref query);

            if (search.CategoryId != null) 
            {
                query = query.Where(x => x.CategoryId == search.CategoryId);
            }
        }
    }
}