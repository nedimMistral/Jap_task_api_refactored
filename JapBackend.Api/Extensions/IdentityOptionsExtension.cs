using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace JapBackend.Api.Extensions
{
    public static class IdentityOptionsExtension
    {
        public static void RegisterIdentityOptions(this IServiceCollection service)
        {
            var passwordOptions = new PasswordOptions()
            {
                RequireDigit = true,
                RequireLowercase = true,
                RequiredLength = 4,
                RequireNonAlphanumeric = true,
                RequireUppercase = true,
            };

            service.Configure<IdentityOptions>(opt =>
            {
                opt.Password = passwordOptions;
            });
        }
    }
}