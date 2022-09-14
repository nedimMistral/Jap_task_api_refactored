using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using JapBackend.Core.Interfaces;
using JapBackend.Core.Interfaces.Repositories;
using JapBackend.Services;

namespace JapBackend.Api.Extensions
{
    public static class RegisterServicesExtension
    {
        public static void RegisterServices(this IServiceCollection service)
        {
            service.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            service.AddTransient<IAuthService, AuthService>();
            service.AddTransient<ICategoriesService, CategoriesService>();
            service.AddTransient<IRecipesService, RecipesService>();
            service.AddTransient<IIngredientsService, IngredientsService>();
            service.AddTransient<IRecipeCostService, RecipeCostService>();

            // service.AddTransient<ICategoryRepository, CategorRepository>();
        }
    }
}