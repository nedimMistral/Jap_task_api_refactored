using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapBackend.Api.Extensions
{
    public static class CorsExtensions
    {
        public static void SetupCors(this IServiceCollection service)
        {
            service.AddCors(options => 
            {
                options.AddPolicy(name: "AllowOrigin",
                    builder => 
                    {
                        builder.WithOrigins("https://localhost:44351", "http://localhost:4200")
                                            .AllowAnyHeader()
                                            .AllowAnyMethod();
                    });
            });
        }
    }
}