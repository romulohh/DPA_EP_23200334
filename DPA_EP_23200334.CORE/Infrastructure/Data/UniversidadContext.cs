using System;
using System.Collections.Generic;
using DPA_EP_23200334.CORE.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace DPA_EP_23200334.CORE.Infrastructure.Data;

public partial class UniversidadContext : DbContext
{
    public UniversidadContext()
    {
    }

    public UniversidadContext(DbContextOptions<UniversidadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrera> Carrera { get; set; }

    public virtual DbSet<Estudiante> Estudiante { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
// #warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
   //     => optionsBuilder.UseSqlServer("Server=DELL-RHERNANDEZ;Database=Universidad;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Estudiante>(entity =>
        {
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("smalldatetime");
            entity.Property(e => e.Materno)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Nombres)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Paterno)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Carrera).WithMany(p => p.Estudiante)
                .HasForeignKey(d => d.CarreraId)
                .HasConstraintName("FK_Estudiante_Carrera");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
