using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Swimming.Models;

namespace Swimming.Context;

public partial class MyDbContext : DbContext
{
    public MyDbContext()
    {
    }

    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Swim> Swims { get; set; }

    public virtual DbSet<Swimmer> Swimmers { get; set; }

    public virtual DbSet<SwimmerList> SwimmerLists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Server=localhost;port=5432;user id=postgres;password=toor;database=Swimming;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Swim>(entity =>
        {
            entity.HasKey(e => e.IdSwim).HasName("Swim_pk");

            entity.ToTable("Swim");

            entity.Property(e => e.IdSwim).UseIdentityAlwaysColumn();
            entity.Property(e => e.DateAndTime).HasColumnType("timestamp without time zone");
        });

        modelBuilder.Entity<Swimmer>(entity =>
        {
            entity.HasKey(e => e.IdSwimmer).HasName("Swimmer_pk");

            entity.ToTable("Swimmer");

            entity.Property(e => e.IdSwimmer).UseIdentityAlwaysColumn();
            entity.Property(e => e.Fname)
                .HasMaxLength(30)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(30)
                .HasColumnName("LName");
            entity.Property(e => e.Mname).HasMaxLength(30);
        });

        modelBuilder.Entity<SwimmerList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SwimmerList");

            entity.Property(e => e.IdList)
                .ValueGeneratedOnAdd()
                .UseIdentityAlwaysColumn();

            entity.HasOne(d => d.IdSwimNavigation).WithMany()
                .HasForeignKey(d => d.IdSwim)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SwimmerList_Swim_IdSwim_fk");

            entity.HasOne(d => d.IdSwimmerNavigation).WithMany()
                .HasForeignKey(d => d.IdSwimmer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("SwimmerList_Swimmer_IdSwimmer_fk");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
