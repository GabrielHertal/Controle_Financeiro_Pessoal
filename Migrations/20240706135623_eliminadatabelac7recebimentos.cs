using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class eliminadatabelac7recebimentos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "C7Recebimento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "C7Recebimento",
                columns: table => new
                {
                    C7ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C7FKC1ID_Usuario = table.Column<int>(type: "integer", nullable: false),
                    C7FKC6ID_Conta = table.Column<int>(type: "integer", nullable: false),
                    C7Data_Recebimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C7Titulo_Recebimento = table.Column<string>(type: "text", nullable: false),
                    C7Valor_Recebimento = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C7Recebimento", x => x.C7ID);
                    table.ForeignKey(
                        name: "FK_C7Recebimento_C1Usuario_C7FKC1ID_Usuario",
                        column: x => x.C7FKC1ID_Usuario,
                        principalTable: "C1Usuario",
                        principalColumn: "C1ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C7Recebimento_C6Conta_C7FKC6ID_Conta",
                        column: x => x.C7FKC6ID_Conta,
                        principalTable: "C6Conta",
                        principalColumn: "C6Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_C7Recebimento_C7FKC1ID_Usuario",
                table: "C7Recebimento",
                column: "C7FKC1ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_C7Recebimento_C7FKC6ID_Conta",
                table: "C7Recebimento",
                column: "C7FKC6ID_Conta");
        }
    }
}
