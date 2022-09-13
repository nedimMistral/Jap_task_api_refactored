using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.MapperProfiles;

namespace JapBackend.Api.Extensions
{
    public static class RegisterAutomapperProfilesExtension
    {
        public static void RegisterAutomapperProfiles(this IServiceCollection service)
        {
            service.AddAutoMapper(typeof(CategoryProfile));
            service.AddAutoMapper(typeof(RecipeProfile));
            service.AddAutoMapper(typeof(IngredientProfile));
            service.AddAutoMapper(typeof(RecipeIngredientProfile));
            service.AddAutoMapper(typeof(UserProfile));
        }
    }
}