using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoTarefasIPG.Data.Migrations
{
    public partial class cargoss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargosID = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Nível = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargosID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargos");
        }
    }
}
