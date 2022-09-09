using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapBackend.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JapBackend.Database.Configurations
{
    public class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("(NOW() at time zone 'utc')");
            builder.Property(x => x.CreatedById).IsRequired().HasMaxLength(127);
            builder.Property(x => x.ModifiedAt).HasDefaultValueSql("(NOW() at time zone 'utc')");
            builder.Property(x => x.ModifiedById).HasMaxLength(127);
        }
    }
}