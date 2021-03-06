﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PrjBiblioteca.Dados;
using System;

namespace PrjBiblioteca.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    [Migration("20180301162349_AddFotoTabelaLivros")]
    partial class AddFotoTabelaLivros
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("PrjBiblioteca.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Autor", b =>
                {
                    b.Property<int>("AutorID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("AutorID");

                    b.ToTable("Autor");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(300);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Emprestimo", b =>
                {
                    b.Property<int>("EmprestimoID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("DataDevolucao");

                    b.Property<string>("DataFim");

                    b.Property<string>("DataInicio");

                    b.Property<int>("UsuarioID");

                    b.HasKey("EmprestimoID");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Emprestimo");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Foto");

                    b.Property<int>("Quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("LivroID");

                    b.ToTable("Livro");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroAutor", b =>
                {
                    b.Property<int>("AutorID");

                    b.Property<int>("LivroID");

                    b.HasKey("AutorID", "LivroID");

                    b.HasIndex("LivroID");

                    b.ToTable("LivroAutor");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroEmprestimo", b =>
                {
                    b.Property<int>("LivroID");

                    b.Property<int>("EmprestimoID");

                    b.HasKey("LivroID", "EmprestimoID");

                    b.HasIndex("EmprestimoID");

                    b.ToTable("LivroEmprestimo");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Sistema", b =>
                {
                    b.Property<int>("SistemaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("SistemaID");

                    b.ToTable("Sistema");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.SistemaUsuario", b =>
                {
                    b.Property<int>("SistemaID");

                    b.Property<int>("UsuarioID");

                    b.HasKey("SistemaID", "UsuarioID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("SistemaUsuario");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CategoriaID");

                    b.Property<string>("Nome")
                        .HasMaxLength(100);

                    b.HasKey("UsuarioID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Emprestimo", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("PrjBiblioteca.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroAutor", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Autor", "Autor")
                        .WithMany("LivAutor")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Livro", "Livro")
                        .WithMany("LivAutor")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.LivroEmprestimo", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Emprestimo", "Emprestimo")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("EmprestimoID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Livro", "Livro")
                        .WithMany("LivEmprestimo")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.SistemaUsuario", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Sistema", "Sistemas")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("SistemaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PrjBiblioteca.Models.Usuario", "Usuarios")
                        .WithMany("SistUsuarios")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Usuario", b =>
                {
                    b.HasOne("PrjBiblioteca.Models.Categoria", "Categoria")
                        .WithMany("Usuarios")
                        .HasForeignKey("CategoriaID");
                });
#pragma warning restore 612, 618
        }
    }
}
