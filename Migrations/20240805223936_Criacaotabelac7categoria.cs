using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class Criacaotabelac7categoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "C2Valor",
                table: "C2Lancamento",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric");

            migrationBuilder.AddColumn<int>(
                name: "C2FKC2ID_Categoria",
                table: "C2Lancamento",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "C7Categoria",
                columns: table => new
                {
                    C7Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C7Nome = table.Column<string>(type: "text", nullable: false),
                    C7FKC1ID_Usuario = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C7Categoria", x => x.C7Id);
                    table.ForeignKey(
                        name: "FK_C7Categoria_C1Usuario_C7FKC1ID_Usuario",
                        column: x => x.C7FKC1ID_Usuario,
                        principalTable: "C1Usuario",
                        principalColumn: "C1ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC2ID_Categoria");

            migrationBuilder.CreateIndex(
                name: "IX_C7Categoria_C7FKC1ID_Usuario",
                table: "C7Categoria",
                column: "C7FKC1ID_Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC2ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC2ID_Categoria",
                principalTable: "C7Categoria",
                principalColumn: "C7Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropTable(
                name: "C7Categoria");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.AlterColumn<decimal>(
                name: "C2Valor",
                table: "C2Lancamento",
                type: "numeric",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
