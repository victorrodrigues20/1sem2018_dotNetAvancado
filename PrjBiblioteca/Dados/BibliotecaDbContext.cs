using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrjBiblioteca.Models;

namespace PrjBiblioteca.Dados
{
    public partial class BibliotecaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite(@"Data Source=biblioteca.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SistemaUsuario>()
                .HasKey(bc => new { bc.SistemaID, bc.UsuarioID });

            modelBuilder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Sistemas)
                .WithMany(b => b.SistUsuarios)
                .HasForeignKey(bc => bc.SistemaID);

            modelBuilder.Entity<SistemaUsuario>()
                .HasOne(bc => bc.Usuarios)
                .WithMany(c => c.SistUsuarios)
                .HasForeignKey(bc => bc.UsuarioID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PrjBiblioteca.Models.Livro> Livro { get; set; }

        public DbSet<PrjBiblioteca.Models.Categoria> Categoria { get; set; }
    }
}
