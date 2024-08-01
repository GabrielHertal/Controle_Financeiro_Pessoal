using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class ultimoeserio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento",
                column: "C2FKC2ID_Lancamento_Pai");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C2Lancamento_C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento",
                column: "C2FKC2ID_Lancamento_Pai",
                principalTable: "C2Lancamento",
                principalColumn: "C2ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C2Lancamento_C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento");
        }
    }
}
