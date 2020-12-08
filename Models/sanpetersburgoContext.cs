using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace sanPetersburgo.Models
{
    public partial class sanpetersburgoContext : DbContext
    {
        public sanpetersburgoContext()
        {
        }

        public sanpetersburgoContext(DbContextOptions<sanpetersburgoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAcademium> TbAcademia { get; set; }
        public virtual DbSet<TbComunicado> TbComunicados { get; set; }
        public virtual DbSet<TbMorador> TbMoradors { get; set; }
        public virtual DbSet<TbSalao> TbSalaos { get; set; }
        public virtual DbSet<VmConsultarAcademium> VmConsultarAcademia { get; set; }
        public virtual DbSet<VmConsultarSalao> VmConsultarSalaos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=localhost;user id=root;password=matheus250302;database=sanpetersburgo", Microsoft.EntityFrameworkCore.ServerVersion.FromString("8.0.22-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAcademium>(entity =>
            {
                entity.HasKey(e => e.IdAcademia)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.IdMoradorNavigation)
                    .WithMany(p => p.TbAcademia)
                    .HasForeignKey(d => d.IdMorador)
                    .HasConstraintName("id_morador");
            });

            modelBuilder.Entity<TbComunicado>(entity =>
            {
                entity.HasKey(e => e.IdComunicado)
                    .HasName("PRIMARY");

                entity.Property(e => e.TxComunicado)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdMoradorNavigation)
                    .WithMany(p => p.TbComunicados)
                    .HasForeignKey(d => d.IdMorador)
                    .HasConstraintName("id_morador_FK");
            });

            modelBuilder.Entity<TbMorador>(entity =>
            {
                entity.HasKey(e => e.IdMorador)
                    .HasName("PRIMARY");

                entity.Property(e => e.Email)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NmMorador)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Senha)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TbSalao>(entity =>
            {
                entity.HasKey(e => e.IdSalao)
                    .HasName("PRIMARY");

                entity.HasOne(d => d.IdMoradorNavigation)
                    .WithMany(p => p.TbSalaos)
                    .HasForeignKey(d => d.IdMorador)
                    .HasConstraintName("id_morador0");
            });

            modelBuilder.Entity<VmConsultarAcademium>(entity =>
            {
                entity.ToView("vm_consultar_academia");

                entity.Property(e => e.NmMorador)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<VmConsultarSalao>(entity =>
            {
                entity.ToView("vm_consultar_salao");

                entity.Property(e => e.NmMorador)
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
