using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjAPICarro.Migrations
{
    public partial class sextaatualizacao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionários_Cargo_CargoId",
                table: "Funcionários");

            //migrationBuilder.DropForeignKey(
               // name: "FK_Funcionários_Pessoas_Documento",
               // table: "Funcionários");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Funcionários_FuncionarioDocumento",
                table: "Venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionários",
                table: "Funcionários");

            migrationBuilder.RenameTable(
                name: "Funcionários",
                newName: "Funcionarios");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionários_CargoId",
                table: "Funcionarios",
                newName: "IX_Funcionarios_CargoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios",
                column: "Documento");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Cargo_CargoId",
                table: "Funcionarios",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Pessoas_Documento",
                table: "Funcionarios",
                column: "Documento",
                principalTable: "Pessoas",
                principalColumn: "Documento");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Funcionarios_FuncionarioDocumento",
                table: "Venda",
                column: "FuncionarioDocumento",
                principalTable: "Funcionarios",
                principalColumn: "Documento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Cargo_CargoId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Pessoas_Documento",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Venda_Funcionarios_FuncionarioDocumento",
                table: "Venda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Funcionarios",
                table: "Funcionarios");

            migrationBuilder.RenameTable(
                name: "Funcionarios",
                newName: "Funcionários");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionarios_CargoId",
                table: "Funcionários",
                newName: "IX_Funcionários_CargoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Funcionários",
                table: "Funcionários",
                column: "Documento");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionários_Cargo_CargoId",
                table: "Funcionários",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionários_Pessoas_Documento",
                table: "Funcionários",
                column: "Documento",
                principalTable: "Pessoas",
                principalColumn: "Documento");

            migrationBuilder.AddForeignKey(
                name: "FK_Venda_Funcionários_FuncionarioDocumento",
                table: "Venda",
                column: "FuncionarioDocumento",
                principalTable: "Funcionários",
                principalColumn: "Documento");
        }
    }
}
