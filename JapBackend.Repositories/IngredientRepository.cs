using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Core.Requests.Ingredient;
using JapBackend.Database;
using Microsoft.AspNetCore.Http;

namespace JapBackend.Repositories
{
    public class IngredientRepository : BaseRepository<Ingredient, IngredientSearchRequest, IngredientInsertRequest, IngredientUpdateRequest, IngredientDto>, IIngredientRepository
    {
        public IngredientRepository(JapBackendDbContext dbContext, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(dbContext, mapper, httpContextAccessor)
        {
        }
    }
}