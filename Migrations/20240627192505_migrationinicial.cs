using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class migrationinicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C1Usuario",
                columns: table => new
                {
                    C1ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C1Nome = table.Column<string>(type: "text", nullable: false),
                    C1Cpf = table.Column<string>(type: "text", nullable: true),
                    C1Email = table.Column<string>(type: "text", nullable: false),
                    C1Senha = table.Column<string>(type: "text", nullable: false),
                    C1Data_Criacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C1Renda_Mensal = table.Column<float>(type: "real", nullable: false),
                    C1Ativo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C1Usuario", x => x.C1ID);
                });

            migrationBuilder.CreateTable(
                name: "C2Lancamentos",
                columns: table => new
                {
                    C2ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C2Titulo_Lancamento = table.Column<string>(type: "text", nullable: false),
                    C2Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    C2Data_Prev_Pag = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C2Data_Pag = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    C2FKC1ID_User = table.Column<int>(type: "integer", nullable: false),
                    C2FKC3ID_Status = table.Column<int>(type: "integer", nullable: false),
                    C2FKC4ID_Moeda = table.Column<int>(type: "integer", nullable: false),
                    C2FKC5ID_Tipo_Lancamento = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C2Lancamentos", x => x.C2ID);
                });

            migrationBuilder.CreateTable(
                name: "C3Status_Lancamento",
                columns: table => new
                {
                    C3ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C3Noem_Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C3Status_Lancamento", x => x.C3ID);
                });

            migrationBuilder.CreateTable(
                name: "C4Moeda",
                columns: table => new
                {
                    C4ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C4Nome_Moeda = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C4Moeda", x => x.C4ID);
                });

            migrationBuilder.CreateTable(
                name: "C5Tipo_Lancamento",
                columns: table => new
                {
                    C5ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C5Nome_Tipo_Lancamento = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C5Tipo_Lancamento", x => x.C5ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C1Usuario");

            migrationBuilder.DropTable(
                name: "C2Lancamentos");

            migrationBuilder.DropTable(
                name: "C3Status_Lancamento");

            migrationBuilder.DropTable(
                name: "C4Moeda");

            migrationBuilder.DropTable(
                name: "C5Tipo_Lancamento");
        }
    }
}
