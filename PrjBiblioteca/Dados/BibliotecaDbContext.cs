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
            #region SistemaUsuario
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
            #endregion

            #region LivroAutor

            //// Gera Chave Primaria Composta
            modelBuilder.Entity<LivroAutor>()
                .HasKey(bc => new { bc.AutorID, bc.LivroID });

            modelBuilder.Entity<LivroAutor>()
                .HasOne(bc => bc.Autor)
                .WithMany(b => b.LivAutor)
                .HasForeignKey(bc => bc.AutorID);

            modelBuilder.Entity<LivroAutor>()
                .HasOne(bc => bc.Livro)
                .WithMany(c => c.LivAutor)
                .HasForeignKey(bc => bc.LivroID);

            #endregion

            #region LivroEmprestimo

            modelBuilder.Entity<LivroEmprestimo>()
                .HasKey(bc => new { bc.LivroID, bc.EmprestimoID });

            modelBuilder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Livro)
                .WithMany(b => b.LivEmprestimo)
                .HasForeignKey(bc => bc.LivroID);

            modelBuilder.Entity<LivroEmprestimo>()
                .HasOne(bc => bc.Emprestimo)
                .WithMany(c => c.LivEmprestimo)
                .HasForeignKey(bc => bc.EmprestimoID);

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<PrjBiblioteca.Models.Livro> Livro { get; set; }

        public DbSet<PrjBiblioteca.Models.Categoria> Categoria { get; set; }

        public DbSet<PrjBiblioteca.Models.Autor> Autor { get; set; }

        public DbSet<PrjBiblioteca.Models.Emprestimo> Emprestimo { get; set; }

        public DbSet<PrjBiblioteca.Models.Usuario> Usuario { get; set; }

        public DbSet<PrjBiblioteca.Models.LivroAutor> LivroAutor { get; set; }

        public DbSet<PrjBiblioteca.Models.LivroEmprestimo> LivroEmprestimo { get; set; }
    }
}
