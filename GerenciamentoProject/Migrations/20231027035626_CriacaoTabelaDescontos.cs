using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GerenciamentoProject.Migrations
{
    public partial class CriacaoTabelaDescontos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descontos",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    HoraExtra = table.Column<double>(type: "REAL", nullable: false),
                    Faltas = table.Column<double>(type: "REAL", nullable: false),
                    SalarioBruto = table.Column<double>(type: "REAL", nullable: true),
                    Atraso = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descontos", x => x.Id_Usuario);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descontos");
        }
    }
}
