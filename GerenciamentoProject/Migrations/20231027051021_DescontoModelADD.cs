using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoProject.Migrations
{
    public partial class DescontoModelADD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cargo",
                table: "Descontos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeFuncionario",
                table: "Descontos",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cargo",
                table: "Descontos");

            migrationBuilder.DropColumn(
                name: "NomeFuncionario",
                table: "Descontos");
        }
    }
}
