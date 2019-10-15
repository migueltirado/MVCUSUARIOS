using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MVCRUD.Models
{
    public partial class pruebaContext : DbContext
    {
        public virtual DbSet<TbAgente> TbAgente { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbFacturas> TbFacturas { get; set; }
        public virtual DbSet<TbOrden> TbOrden { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseMySql("server=localhost; database=prueba; user=root; pwd=Tamalit0;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAgente>(entity =>
            {
                entity.HasKey(e => e.IdAgente);

                entity.ToTable("tb_agente");

                entity.Property(e => e.IdAgente)
                    .HasColumnName("ID_AGENTE")
                    .HasMaxLength(15);

                entity.Property(e => e.Departamanto)
                    .HasColumnName("DEPARTAMANTO")
                    .HasMaxLength(50);

                entity.Property(e => e.Nombre)
                    .HasColumnName("NOMBRE")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente);

                entity.ToTable("tb_cliente");

                entity.Property(e => e.IdCliente)
                    .HasColumnName("ID_CLIENTE")
                    .HasMaxLength(15);

                entity.Property(e => e.NombreCliente)
                    .HasColumnName("NOMBRE_CLIENTE")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreComercial)
                    .HasColumnName("NOMBRE_COMERCIAL")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TbFacturas>(entity =>
            {
                entity.HasKey(e => e.Folio);

                entity.ToTable("tb_facturas");

                entity.HasIndex(e => e.Orden)
                    .HasName("FK_ORDEN");

                entity.Property(e => e.Folio)
                    .HasColumnName("FOLIO")
                    .HasMaxLength(11);

                entity.Property(e => e.IdPago)
                    .HasColumnName("ID_PAGO")
                    .HasMaxLength(15);

                entity.Property(e => e.Importe)
                    .HasColumnName("IMPORTE")
                    .HasColumnType("decimal(38,0)");

                entity.Property(e => e.Orden)
                    .HasColumnName("ORDEN")
                    .HasMaxLength(10);

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("TIPO_CAMBIO")
                    .HasColumnType("decimal(4,2)");

                entity.HasOne(d => d.OrdenNavigation)
                    .WithMany(p => p.TbFacturas)
                    .HasForeignKey(d => d.Orden)
                    .HasConstraintName("FK_ORDEN");
            });

            modelBuilder.Entity<TbOrden>(entity =>
            {
                entity.HasKey(e => e.NumeroOrden);

                entity.ToTable("tb_orden");

                entity.HasIndex(e => e.Agente)
                    .HasName("FK_AGENTE");

                entity.HasIndex(e => e.Cliente)
                    .HasName("FK_CLIENTE");

                entity.Property(e => e.NumeroOrden)
                    .HasColumnName("NUMERO_ORDEN")
                    .HasMaxLength(15);

                entity.Property(e => e.Agente)
                    .HasColumnName("AGENTE")
                    .HasMaxLength(15);

                entity.Property(e => e.Cliente)
                    .HasColumnName("CLIENTE")
                    .HasMaxLength(15);

                entity.Property(e => e.TipoVenta)
                    .HasColumnName("TIPO_VENTA")
                    .HasMaxLength(10);

                entity.HasOne(d => d.AgenteNavigation)
                    .WithMany(p => p.TbOrden)
                    .HasForeignKey(d => d.Agente)
                    .HasConstraintName("FK_AGENTE");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.TbOrden)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK_CLIENTE");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.Userid)
                    .HasName("userid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(40);

                entity.Property(e => e.Pass)
                    .HasColumnName("pass")
                    .HasMaxLength(20);

                entity.Property(e => e.Userid)
                    .HasColumnName("userid")
                    .HasMaxLength(40);
            });
        }
    }
}
