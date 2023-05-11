using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DataAccess
{
    public partial class PruebaReservasBDContext : DbContext
    {
        public PruebaReservasBDContext()
        {
        }

        public PruebaReservasBDContext(DbContextOptions<PruebaReservasBDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alojamiento> Alojamientos { get; set; }
        public virtual DbSet<Categorium> Categoria { get; set; }
        public virtual DbSet<Sede> Sedes { get; set; }

     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Alojamiento>(entity =>
            {
                entity.HasKey(e => e.IdAlojamiento)
                    .HasName("PK__Alojamie__EF77F5727FD5B1AE");

                entity.ToTable("Alojamiento");

                entity.Property(e => e.CodigoHabitacion)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDisponibilidad).HasColumnType("date");

                entity.Property(e => e.FechaReserva).HasColumnType("date");

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Alojamientos)
                    .HasForeignKey(d => d.IdCategoria)
                    .HasConstraintName("FK_IdCategoria");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.Alojamientos)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("FK_IdSede");
            });

            modelBuilder.Entity<Categorium>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("PK__Categori__A3C02A101773AA3B");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sede>(entity =>
            {
                entity.HasKey(e => e.IdSede)
                    .HasName("PK__Sede__A7780DFFBB02F7E2");

                entity.ToTable("Sede");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
