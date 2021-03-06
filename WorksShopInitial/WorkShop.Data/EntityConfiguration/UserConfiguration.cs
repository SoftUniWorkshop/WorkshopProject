﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkShop.Models;

namespace WorkShop.Data.EntityConfiguration
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> user)
        {
            user.HasKey(x => x.Id);

            user.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);

            user.Property(x => x.Gold)
                .HasDefaultValue(0);

            user.Property(x => x.Health)
                .IsRequired();
        }
    }
}




