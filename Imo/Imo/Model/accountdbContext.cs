using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Imo.Model
{
    public partial class accountdbContext : DbContext
    {
        public accountdbContext()
        {
        }

        public accountdbContext(DbContextOptions<accountdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AndroidMetadatum> AndroidMetadata { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=C:\\sqlite\\db\\accountdb.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.Property(e => e.Id).HasColumnName("_id");

                entity.Property(e => e.Iat).HasColumnName("iat");

                entity.Property(e => e.Icon).HasColumnName("icon");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.PhoneCc).HasColumnName("phone_cc");

                entity.Property(e => e.Uid).HasColumnName("uid");
            });

            modelBuilder.Entity<AndroidMetadatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("android_metadata");

                entity.Property(e => e.Locale).HasColumnName("locale");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
