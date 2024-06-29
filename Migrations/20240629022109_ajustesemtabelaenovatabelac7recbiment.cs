using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Controle_Financeiro_Pessoal.Migrations
{
    /// <inheritdoc />
    public partial class ajustesemtabelaenovatabelac7recbiment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C6Contas_C1Usuario_C6FKC1ID_User",
                table: "C6Contas");

            migrationBuilder.DropTable(
                name: "C2Lancamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C6Contas",
                table: "C6Contas");

            migrationBuilder.RenameTable(
                name: "C6Contas",
                newName: "C6Conta");

            migrationBuilder.RenameColumn(
                name: "C3Noem_Status",
                table: "C3Status_Lancamento",
                newName: "C3Nome_Status");

            migrationBuilder.RenameIndex(
                name: "IX_C6Contas_C6FKC1ID_User",
                table: "C6Conta",
                newName: "IX_C6Conta_C6FKC1ID_User");

            migrationBuilder.AddColumn<bool>(
                name: "C6Ativo",
                table: "C6Conta",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<float>(
                name: "C6Saldo",
                table: "C6Conta",
                type: "real",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_C6Conta",
                table: "C6Conta",
                column: "C6Id");

            migrationBuilder.CreateTable(
                name: "C2Lancamento",
                columns: table => new
                {
                    C2ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C2Titulo_Lancamento = table.Column<string>(type: "text", nullable: false),
                    C2Valor = table.Column<decimal>(type: "numeric", nullable: false),
                    C2Data_Lancamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C2Data_Previa_Pagamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C2Data_Pagamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    C2FKC1ID_User = table.Column<int>(type: "integer", nullable: false),
                    C2FKC3ID_Status = table.Column<int>(type: "integer", nullable: false),
                    C2FKC4ID_Moeda = table.Column<int>(type: "integer", nullable: false),
                    C2FKC5ID_Tipo_Lancamento = table.Column<int>(type: "integer", nullable: false),
                    C2FKC6ID_Conta = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C2Lancamento", x => x.C2ID);
                    table.ForeignKey(
                        name: "FK_C2Lancamento_C1Usuario_C2FKC1ID_User",
                        column: x => x.C2FKC1ID_User,
                        principalTable: "C1Usuario",
                        principalColumn: "C1ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamento_C3Status_Lancamento_C2FKC3ID_Status",
                        column: x => x.C2FKC3ID_Status,
                        principalTable: "C3Status_Lancamento",
                        principalColumn: "C3ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamento_C4Moeda_C2FKC4ID_Moeda",
                        column: x => x.C2FKC4ID_Moeda,
                        principalTable: "C4Moeda",
                        principalColumn: "C4ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamento_C5Tipo_Lancamento_C2FKC5ID_Tipo_Lancamento",
                        column: x => x.C2FKC5ID_Tipo_Lancamento,
                        principalTable: "C5Tipo_Lancamento",
                        principalColumn: "C5ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamento_C6Conta_C2FKC6ID_Conta",
                        column: x => x.C2FKC6ID_Conta,
                        principalTable: "C6Conta",
                        principalColumn: "C6Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "C7Recebimento",
                columns: table => new
                {
                    C7ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C7Titulo_Recebimento = table.Column<string>(type: "text", nullable: false),
                    C7Valor_Recebimento = table.Column<float>(type: "real", nullable: false),
                    C7Data_Recebimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C7FKC1ID_Usuario = table.Column<int>(type: "integer", nullable: false),
                    C7FKC6ID_Conta = table.Column<int>(type: "integer", nullable: false)
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
                name: "IX_C2Lancamento_C2FKC1ID_User",
                table: "C2Lancamento",
                column: "C2FKC1ID_User");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC3ID_Status",
                table: "C2Lancamento",
                column: "C2FKC3ID_Status");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC4ID_Moeda",
                table: "C2Lancamento",
                column: "C2FKC4ID_Moeda");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC5ID_Tipo_Lancamento",
                table: "C2Lancamento",
                column: "C2FKC5ID_Tipo_Lancamento");

            migrationBuilder.CreateIndex(
                name: "IX_C2Lancamento_C2FKC6ID_Conta",
                table: "C2Lancamento",
                column: "C2FKC6ID_Conta");

            migrationBuilder.CreateIndex(
                name: "IX_C7Recebimento_C7FKC1ID_Usuario",
                table: "C7Recebimento",
                column: "C7FKC1ID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_C7Recebimento_C7FKC6ID_Conta",
                table: "C7Recebimento",
                column: "C7FKC6ID_Conta");

            migrationBuilder.AddForeignKey(
                name: "FK_C6Conta_C1Usuario_C6FKC1ID_User",
                table: "C6Conta",
                column: "C6FKC1ID_User",
                principalTable: "C1Usuario",
                principalColumn: "C1ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_C6Conta_C1Usuario_C6FKC1ID_User",
                table: "C6Conta");

            migrationBuilder.DropTable(
                name: "C2Lancamento");

            migrationBuilder.DropTable(
                name: "C7Recebimento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_C6Conta",
                table: "C6Conta");

            migrationBuilder.DropColumn(
                name: "C6Ativo",
                table: "C6Conta");

            migrationBuilder.DropColumn(
                name: "C6Saldo",
                table: "C6Conta");

            migrationBuilder.RenameTable(
                name: "C6Conta",
                newName: "C6Contas");

            migrationBuilder.RenameColumn(
                name: "C3Nome_Status",
                table: "C3Status_Lancamento",
                newName: "C3Noem_Status");

            migrationBuilder.RenameIndex(
                name: "IX_C6Conta_C6FKC1ID_User",
                table: "C6Contas",
                newName: "IX_C6Contas_C6FKC1ID_User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_C6Contas",
                table: "C6Contas",
                column: "C6Id");

            migrationBuilder.CreateTable(
                name: "C2Lancamentos",
                columns: table => new
                {
                    C2ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    C2FKC1ID_User = table.Column<int>(type: "integer", nullable: false),
                    C2FKC3ID_Status = table.Column<int>(type: "integer", nullable: false),
                    C2FKC4ID_Moeda = table.Column<int>(type: "integer", nullable: false),
                    C2FKC5ID_Tipo_Lancamento = table.Column<int>(type: "integer", nullable: false),
                    C2FKC6ID_Conta = table.Column<int>(type: "integer", nullable: false),
                    C2Data_Pag = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    C2Data_Prev_Pag = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    C2Titulo_Lancamento = table.Column<string>(type: "text", nullable: false),
                    C2Valor = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_C2Lancamentos", x => x.C2ID);
                    table.ForeignKey(
                        name: "FK_C2Lancamentos_C1Usuario_C2FKC1ID_User",
                        column: x => x.C2FKC1ID_User,
                        principalTable: "C1Usuario",
                        principalColumn: "C1ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamentos_C3Status_Lancamento_C2FKC3ID_Status",
                        column: x => x.C2FKC3ID_Status,
                        principalTable: "C3Status_Lancamento",
                        principalColumn: "C3ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamentos_C4Moeda_C2FKC4ID_Moeda",
                        column: x => x.C2FKC4ID_Moeda,
                        principalTable: "C4Moeda",
                        principalColumn: "C4ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamentos_C5Tipo_Lancamento_C2FKC5ID_Tipo_Lancamento",
                        column: x => x.C2FKC5ID_Tipo_Lancamento,
                        principalTable: "C5Tipo_Lancamento",
                        principalColumn: "C5ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_C2Lancamentos_C6Contas_C2FKC6ID_Conta",
                        column: x => x.C2FKC6ID_Conta,
                        principalTable: "C6Contas",
                        principalColumn: "C6Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "FK_C6Contas_C1Usuario_C6FKC1ID_User",
                table: "C6Contas",
                column: "C6FKC1ID_User",
                principalTable: "C1Usuario",
                principalColumn: "C1ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
