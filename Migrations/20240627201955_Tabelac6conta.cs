using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class Tabelac6conta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "C2FKC6ID_Conta",
                table: "C2Lancamentos",
                type: "integer",
                nullable: false);

            migrationBuilder.CreateTable(
                name: "C6Contas",
                columns: table => new
                {
                    C6Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C6Nome = table.Column<string>(type: "text", nullable: false),
                    C6FKC1ID_User = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C6Contas", x => x.C6Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C6Contas");

            migrationBuilder.DropColumn(
                name: "C2FKC6ID_Conta",
                table: "C2Lancamentos");
        }
    }
}
