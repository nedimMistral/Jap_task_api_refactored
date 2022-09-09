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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.CreatedAt).HasDefaultValueSql("(NOW() at time zone 'utc')");
            builder.Property(x => x.CreatedById).HasMaxLength(127);
            builder.Property(x => x.ModifiedAt).HasDefaultValueSql("(NOW() at time zone 'utc')");
            builder.Property(x => x.ModifiedById).HasMaxLength(127);

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(127);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(127);
            builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(127);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(127);

            builder.HasMany(x => x.UserRoles)
                   .WithOne(x => x.User)
                   .HasForeignKey(ur => ur.UserId)
                   .IsRequired();
        }
    }
}