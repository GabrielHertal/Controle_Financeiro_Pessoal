using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class Eliminadatabelac7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C6Saldo",
                table: "C6Conta");

            migrationBuilder.AddColumn<string>(
                name: "C2Observacao",
                table: "C2Lancamento",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C2Observacao",
                table: "C2Lancamento");

            migrationBuilder.AddColumn<float>(
                name: "C6Saldo",
                table: "C6Conta",
                type: "real",
                nullable: true);
        }
    }
}
