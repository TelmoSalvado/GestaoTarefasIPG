using Microsoft.EntityFrameworkCore.Migrations;

namespace GestãoTarefasIPG.Migrations
{
    public partial class FuncionarioChaveEstrangeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Funcao",
                table: "Funcionario");

            migrationBuilder.AddColumn<int>(
                name: "CargosId",
                table: "Funcionario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_CargosId",
                table: "Funcionario",
                column: "CargosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Cargos_CargosId",
                table: "Funcionario",
                column: "CargosId",
                principalTable: "Cargos",
                principalColumn: "CargosId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Cargos_CargosId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_CargosId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "CargosId",
                table: "Funcionario");

            migrationBuilder.AddColumn<string>(
                name: "Funcao",
                table: "Funcionario",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
