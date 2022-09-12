using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.RecipeIngredient;

namespace JapBackend.Core.MapperProfiles
{
    public class RecipeIngredientProfile : Profile
    {
        public RecipeIngredientProfile() 
        {
            CreateMap<RecipeIngredientDto, RecipeIngredient>()
                .ReverseMap();
        }
    }
}