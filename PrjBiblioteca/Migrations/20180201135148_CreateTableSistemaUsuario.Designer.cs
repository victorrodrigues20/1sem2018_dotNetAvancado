﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using PrjBiblioteca.Dados;
using System;

namespace PrjBiblioteca.Migrations
{
    [DbContext(typeof(BibliotecaDbContext))]
    [Migration("20180201135148_CreateTableSistemaUsuario")]
    partial class CreateTableSistemaUsuario
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("PrjBiblioteca.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .HasMaxLength(300);

                    b.HasKey("CategoriaID");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("PrjBiblioteca.Models.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Quantidade");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("LivroID");

                    b.ToTable("Livro");
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
