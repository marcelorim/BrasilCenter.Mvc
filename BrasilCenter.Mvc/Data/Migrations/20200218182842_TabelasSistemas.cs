using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrasilCenter.Mvc.Data.Migrations
{
    public partial class TabelasSistemas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Livros",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 200, nullable: false),
                    Isbn = table.Column<int>(maxLength: 13, nullable: false),
                    Autor = table.Column<string>(maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(nullable: true),
                    DtPublicacao = table.Column<DateTime>(nullable: true),
                    Capa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Livros", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Livros");
        }
    }
}
