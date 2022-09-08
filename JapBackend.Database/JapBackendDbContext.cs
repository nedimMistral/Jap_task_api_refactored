using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JapBackend.Database
{
    public class JapBackendDbContext : IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public JapBackendDbContext(DbContextOptions<JapBackendDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RecipeIngredient>()
                .HasOne(r => r.Recipe)
                    .WithMany(ri => ri.RecipeIngredients)
                        .HasForeignKey(ri => ri.RecipeId);

            DataSeeder.CategoriesSeed.Seed(builder);
            DataSeeder.IngredientsSeed.Seed(builder);
        }
    }
}