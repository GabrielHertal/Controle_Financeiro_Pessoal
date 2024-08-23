using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class ultimoajustec7categoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C7Tipo_Categoria",
                table: "C7Categoria",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C7Tipo_Categoria",
                table: "C7Categoria");
        }
    }
}
