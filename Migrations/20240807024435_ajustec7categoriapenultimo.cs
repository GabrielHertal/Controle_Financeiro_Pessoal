using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class ajustec7categoriapenultimo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "C7Tipo_Categoria",
                table: "C7Categoria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C7Tipo_Categoria",
                table: "C7Categoria",
                type: "integer",
                nullable: true);
        }
    }
}
