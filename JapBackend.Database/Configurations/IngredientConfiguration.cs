using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JapBackend.Database.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
           builder.Property(x => x.Name).IsRequired().HasMaxLength(127);
           builder.Property(x => x.UnitPrice).IsRequired();
           builder.Property(x => x.UnitQuantity).IsRequired();
           builder.Property(x => x.UnitOfMeasure).IsRequired(); 
        }
    }
}