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
    [Migration("20180201122015_CreateTableLivro")]
    partial class CreateTableLivro
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("PrjBiblioteca.Models.Livro", b =>
                {
                    b.Property<int>("LivroID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Titulo");

                    b.HasKey("LivroID");

                    b.ToTable("Livro");
                });
#pragma warning restore 612, 618
        }
    }
}
