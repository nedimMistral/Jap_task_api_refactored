using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Recipe;

namespace JapBackend.Core.MapperProfiles
{
    public class RecipeProfile : Profile
    {
        public RecipeProfile() 
        {
            CreateMap<RecipeInsertRequest, Recipe>();
            CreateMap<Recipe, RecipeDto>();
        }
    }
}