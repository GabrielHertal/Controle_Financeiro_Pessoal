using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class adicionandoFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_C6Contas_C6FKC1ID_User",
                table: "C6Contas",
                column: "C6FKC1ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamentos_C2FKC1ID_User",
                table: "C2Lancamentos",
                column: "C2FKC1ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamentos_C2FKC3ID_Status",
                table: "C2Lancamentos",
                column: "C2FKC3ID_Status");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamentos_C2FKC4ID_Moeda",
                table: "C2Lancamentos",
                column: "C2FKC4ID_Moeda");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamentos_C2FKC5ID_Tipo_Lancamento",
                table: "C2Lancamentos",
                column: "C2FKC5ID_Tipo_Lancamento");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamentos_C2FKC6ID_Conta",
                table: "C2Lancamentos",
                column: "C2FKC6ID_Conta");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamentos_C1Usuario_C2FKC1ID_User",
                table: "C2Lancamentos",
                column: "C2FKC1ID_User",
                principalTable: "C1Usuario",
                principalColumn: "C1ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamentos_C3Status_Lancamento_C2FKC3ID_Status",
                table: "C2Lancamentos",
                column: "C2FKC3ID_Status",
                principalTable: "C3Status_Lancamento",
                principalColumn: "C3ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamentos_C4Moeda_C2FKC4ID_Moeda",
                table: "C2Lancamentos",
                column: "C2FKC4ID_Moeda",
                principalTable: "C4Moeda",
                principalColumn: "C4ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamentos_C5Tipo_Lancamento_C2FKC5ID_Tipo_Lancamento",
                table: "C2Lancamentos",
                column: "C2FKC5ID_Tipo_Lancamento",
                principalTable: "C5Tipo_Lancamento",
                principalColumn: "C5ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamentos_C6Contas_C2FKC6ID_Conta",
                table: "C2Lancamentos",
                column: "C2FKC6ID_Conta",
                principalTable: "C6Contas",
                principalColumn: "C6Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C6Contas_C1Usuario_C6FKC1ID_User",
                table: "C6Contas",
                column: "C6FKC1ID_User",
                principalTable: "C1Usuario",
                principalColumn: "C1ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamentos_C1Usuario_C2FKC1ID_User",
                table: "C2Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamentos_C3Status_Lancamento_C2FKC3ID_Status",
                table: "C2Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamentos_C4Moeda_C2FKC4ID_Moeda",
                table: "C2Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamentos_C5Tipo_Lancamento_C2FKC5ID_Tipo_Lancamento",
                table: "C2Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamentos_C6Contas_C2FKC6ID_Conta",
                table: "C2Lancamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_C6Contas_C1Usuario_C6FKC1ID_User",
                table: "C6Contas");

            migrationBuilder.DropIndex(
                name: "IX_C6Contas_C6FKC1ID_User",
                table: "C6Contas");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamentos_C2FKC1ID_User",
                table: "C2Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamentos_C2FKC3ID_Status",
                table: "C2Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamentos_C2FKC4ID_Moeda",
                table: "C2Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamentos_C2FKC5ID_Tipo_Lancamento",
                table: "C2Lancamentos");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamentos_C2FKC6ID_Conta",
                table: "C2Lancamentos");
        }
    }
}
