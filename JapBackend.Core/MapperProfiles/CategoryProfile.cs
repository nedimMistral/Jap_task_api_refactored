using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using JapBackend.Core.Entities;
using JapBackend.Core.Requests.Category;

namespace JapBackend.Core.MapperProfiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryInsertRequest, Category>();
            CreateMap<Category, CategoryDto>();
        }
    }
}