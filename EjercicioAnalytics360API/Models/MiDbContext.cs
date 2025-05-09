using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace EjercicioAnalytics360API.Models;

public partial class MiDbContext : DbContext
{
    public MiDbContext()
    {
    }

    public MiDbContext(DbContextOptions<MiDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Balanceo> Balanceos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Balanceo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("balanceo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Input)
                .HasMaxLength(200)
                .HasColumnName("input");
            entity.Property(e => e.Result)
                .HasColumnType("tinyint(4)")
                .HasColumnName("result");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
