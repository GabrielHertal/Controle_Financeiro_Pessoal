using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class addcampoc2lancamento_pai : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C2Lancamento_PaiC2ID",
                table: "C2Lancamento",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2Lancamento_PaiC2ID",
                table: "C2Lancamento",
                column: "C2Lancamento_PaiC2ID");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C2Lancamento_C2Lancamento_PaiC2ID",
                table: "C2Lancamento",
                column: "C2Lancamento_PaiC2ID",
                principalTable: "C2Lancamento",
                principalColumn: "C2ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C2Lancamento_C2Lancamento_PaiC2ID",
                table: "C2Lancamento");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2Lancamento_PaiC2ID",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C2FKC2ID_Lancamento_Pai",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C2Lancamento_PaiC2ID",
                table: "C2Lancamento");
        }
    }
}
