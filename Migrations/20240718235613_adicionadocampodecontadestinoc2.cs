using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class adicionadocampodecontadestinoc2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento",
                column: "C2FKC6ID_Conta_Transferencia");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C6Conta_C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento",
                column: "C2FKC6ID_Conta_Transferencia",
                principalTable: "C6Conta",
                principalColumn: "C6Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C6Conta_C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C2FKC6ID_Conta_Transferencia",
                table: "C2Lancamento");
        }
    }
}
