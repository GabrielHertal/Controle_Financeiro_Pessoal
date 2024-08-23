using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class Adicionadonovocampotabelac7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropForeignKey(
                name: "FK_C7Categoria_C1Usuario_C7FKC1ID_Usuario",
                table: "C7Categoria");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C2FKC2ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.AlterColumn<int>(
                name: "C7FKC1ID_Usuario",
                table: "C7Categoria",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<string>(
                name: "C7Tipo_Categoria",
                table: "C7Categoria",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "C2Titulo_Lancamento",
                table: "C2Lancamento",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "C2FKC7ID_Categoria",
                table: "C2Lancamento",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC7ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC7ID_Categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC7ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC7ID_Categoria",
                principalTable: "C7Categoria",
                principalColumn: "C7Id");

            migrationBuilder.AddForeignKey(
                name: "FK_C7Categoria_C1Usuario_C7FKC1ID_Usuario",
                table: "C7Categoria",
                column: "C7FKC1ID_Usuario",
                principalTable: "C1Usuario",
                principalColumn: "C1ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC7ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropForeignKey(
                name: "FK_C7Categoria_C1Usuario_C7FKC1ID_Usuario",
                table: "C7Categoria");

            migrationBuilder.DropIndex(
                name: "IX_C2Lancamento_C2FKC7ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.DropColumn(
                name: "C7Tipo_Categoria",
                table: "C7Categoria");

            migrationBuilder.DropColumn(
                name: "C2FKC7ID_Categoria",
                table: "C2Lancamento");

            migrationBuilder.AlterColumn<int>(
                name: "C7FKC1ID_Usuario",
                table: "C7Categoria",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "C2Titulo_Lancamento",
                table: "C2Lancamento",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "C2FKC2ID_Categoria",
                table: "C2Lancamento",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC2ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC2ID_Categoria");

            migrationBuilder.AddForeignKey(
                name: "FK_C2Lancamento_C7Categoria_C2FKC2ID_Categoria",
                table: "C2Lancamento",
                column: "C2FKC2ID_Categoria",
                principalTable: "C7Categoria",
                principalColumn: "C7Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_C7Categoria_C1Usuario_C7FKC1ID_Usuario",
                table: "C7Categoria",
                column: "C7FKC1ID_Usuario",
                principalTable: "C1Usuario",
                principalColumn: "C1ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
