﻿using IdentityPersistanceIgnorant.Domain.Models;
using System.Data.Entity.ModelConfiguration;

namespace IdentityPersistenceIgnorant.Data.Configuration
{
    internal class ExternalLoginConfiguration : EntityTypeConfiguration<ExternalLogin>
    {
        internal ExternalLoginConfiguration()
        {
            ToTable("ExternalLogin");

            HasKey(x => new { x.LoginProvider, x.ProviderKey, x.UserId });

            Property(x => x.LoginProvider)
                .HasColumnName("LoginProvider")
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();

            Property(x => x.ProviderKey)
                .HasColumnName("ProviderKey")
                .HasColumnType("nvarchar")
                .HasMaxLength(128)
                .IsRequired();

            Property(x => x.UserId)
                .HasColumnName("UserId")
                .HasColumnType("uniqueidentifier")
                .IsRequired();

            HasRequired(x => x.User)
                .WithMany(x => x.Logins)
                .HasForeignKey(x => x.UserId);
        }
    }
}