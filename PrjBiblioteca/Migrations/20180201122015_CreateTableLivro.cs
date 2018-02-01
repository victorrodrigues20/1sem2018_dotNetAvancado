using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace PrjBiblioteca.Migrations
{
    public partial class CreateTableLivro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livro",
                columns: table => new
                {
                    LivroID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true)
                    /*, Titulo = table.Column<string>(nullable: true)*/
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livro", x => x.LivroID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livro");
        }
    }
}
