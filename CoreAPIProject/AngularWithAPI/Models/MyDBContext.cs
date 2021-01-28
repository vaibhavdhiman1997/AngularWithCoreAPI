using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AngularWithAPI.Models
{
    public partial class MyDBContext : DbContext
    {
        // public MyDBContext()
        // {
        // }

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     if (!optionsBuilder.IsConfigured)
        //     {
        //         optionsBuilder.UseSqlServer("name=defaultConnection");
        //     }
        // }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

        //     modelBuilder.Entity<User>(entity =>
        //     {
        //         entity.ToTable("User");

        //         entity.Property(e => e.Name)
        //             .HasMaxLength(50)
        //             .IsUnicode(false);

        //         entity.Property(e => e.PasswordHash).HasMaxLength(400);

        //         entity.Property(e => e.PasswordSalt).HasMaxLength(400);
        //     });

        //     OnModelCreatingPartial(modelBuilder);
        // }

        // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
