using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Ingredient;

namespace JapBackend.Core.MapperProfiles
{
    public class IngredientProfile : Profile
    {
        public IngredientProfile()
        {
            CreateMap<IngredientInsertRequest, Ingredient>();
            CreateMap<Ingredient, IngredientDto>();
        }
    }
}