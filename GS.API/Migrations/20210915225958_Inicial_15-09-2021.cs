using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GS.API.Migrations
{
    public partial class Inicial_15092021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "doce");

            migrationBuilder.CreateTable(
                name: "Enderecos",
                schema: "doce",
                columns: table => new
                {
                    EnderecoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    EnderecoTipo = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    EnderecoCEP = table.Column<string>(type: "varchar", maxLength: 10, nullable: true),
                    EnderecoRua = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    EnderecoNum = table.Column<string>(type: "varchar", maxLength: 10, nullable: true),
                    EnderecoComplemento = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    EnderecoBairro = table.Column<string>(type: "varchar", maxLength: 100, nullable: true),
                    EnderecoCidade = table.Column<string>(type: "varchar", maxLength: 50, nullable: true),
                    EnderecoUF = table.Column<string>(type: "varchar", maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enderecos", x => x.EnderecoId);
                });

            migrationBuilder.CreateTable(
                name: "Financeiro",
                schema: "doce",
                columns: table => new
                {
                    FinanceiroId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FinanMov = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    FinanStatus = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    FinanCodOrigem = table.Column<int>(type: "integer", nullable: true),
                    CodCliForOrigem = table.Column<int>(type: "integer", nullable: true),
                    FinanDataDig = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FinanVencimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    FinanValorTotal = table.Column<decimal>(type: "money", nullable: true),
                    FinanValorPago = table.Column<decimal>(type: "money", nullable: true),
                    FinanValorSaldo = table.Column<decimal>(type: "money", nullable: true),
                    FinanDataUltPag = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Financeiro", x => x.FinanceiroId);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                schema: "doce",
                columns: table => new
                {
                    GrupoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    GrupoNome = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    GrupoPreco = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.GrupoId);
                });

            migrationBuilder.CreateTable(
                name: "Localizacoes",
                schema: "doce",
                columns: table => new
                {
                    LocalizacaoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    LocalizacaoNome = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localizacoes", x => x.LocalizacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Unidades",
                schema: "doce",
                columns: table => new
                {
                    UnidadeId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    UnidadeNome = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    UnidadeSigla = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidades", x => x.UnidadeId);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                schema: "doce",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ClienteNome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ClienteCelular = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    ClienteDataNasc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ClienteDataCad = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    ClienteStatus = table.Column<bool>(type: "boolean", nullable: true),
                    ClienteTotalCompras = table.Column<decimal>(type: "money", nullable: true),
                    CliCodEndereco = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteId);
                    table.ForeignKey(
                        name: "FK_Clientes_Enderecos_CliCodEndereco",
                        column: x => x.CliCodEndereco,
                        principalSchema: "doce",
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId");
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                schema: "doce",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FornecedorNome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FornecedorCNPJ = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: true),
                    ForCodEndereco = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.FornecedorId);
                    table.ForeignKey(
                        name: "FK_Fornecedores_Enderecos_ForCodEndereco",
                        column: x => x.ForCodEndereco,
                        principalSchema: "doce",
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId");
                });

            migrationBuilder.CreateTable(
                name: "Vendedores",
                schema: "doce",
                columns: table => new
                {
                    VendedorId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VendedorNome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    VendedorCelular = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    VendedorDataNasc = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    VendedorDataCad = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    VendedorAtivo = table.Column<bool>(type: "boolean", nullable: true),
                    VendedorComissao = table.Column<bool>(type: "boolean", nullable: true),
                    VendedorTotalVendas = table.Column<decimal>(type: "money", nullable: true),
                    VenCodEndereco = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendedores", x => x.VendedorId);
                    table.ForeignKey(
                        name: "FK_Vendedores_Enderecos_VenCodEndereco",
                        column: x => x.VenCodEndereco,
                        principalSchema: "doce",
                        principalTable: "Enderecos",
                        principalColumn: "EnderecoId");
                });

            migrationBuilder.CreateTable(
                name: "FinanceiroPag",
                schema: "doce",
                columns: table => new
                {
                    FinanPagId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    FinanCod = table.Column<int>(type: "integer", nullable: false),
                    FinanDataPag = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FinanValorPag = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceiroPag", x => x.FinanPagId);
                    table.ForeignKey(
                        name: "FK_FinanceiroPag_Financeiro_FinanCod",
                        column: x => x.FinanCod,
                        principalSchema: "doce",
                        principalTable: "Financeiro",
                        principalColumn: "FinanceiroId");
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                schema: "doce",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    ProdutoNome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    ProdutoTipo = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    ProPrecoAtual = table.Column<decimal>(type: "money", nullable: true),
                    ProCustoAtual = table.Column<decimal>(type: "numeric(15,6)", nullable: true),
                    ProdutoAtivo = table.Column<bool>(type: "boolean", nullable: true),
                    ProPrecoGrupo = table.Column<bool>(type: "boolean", nullable: true),
                    ProCodUni = table.Column<int>(type: "integer", nullable: true),
                    ProCodGrupo = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                    table.ForeignKey(
                        name: "FK_Produtos_Grupos_ProCodGrupo",
                        column: x => x.ProCodGrupo,
                        principalSchema: "doce",
                        principalTable: "Grupos",
                        principalColumn: "GrupoId");
                    table.ForeignKey(
                        name: "FK_Produtos_Unidades_ProCodUni",
                        column: x => x.ProCodUni,
                        principalSchema: "doce",
                        principalTable: "Unidades",
                        principalColumn: "UnidadeId");
                });

            migrationBuilder.CreateTable(
                name: "Compras",
                schema: "doce",
                columns: table => new
                {
                    CompraId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CompraData = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    CompraCodFor = table.Column<int>(type: "integer", nullable: true),
                    CompraValorItens = table.Column<decimal>(type: "money", nullable: true),
                    CompraValorFrete = table.Column<decimal>(type: "money", nullable: true),
                    CompraValorTotal = table.Column<decimal>(type: "money", nullable: true),
                    CompraStatus = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    CompraCodLocal = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compras", x => x.CompraId);
                    table.ForeignKey(
                        name: "FK_Compras_Fornecedores_CompraCodFor",
                        column: x => x.CompraCodFor,
                        principalSchema: "doce",
                        principalTable: "Fornecedores",
                        principalColumn: "FornecedorId");
                    table.ForeignKey(
                        name: "FK_Compras_Localizacoes_CompraCodLocal",
                        column: x => x.CompraCodLocal,
                        principalSchema: "doce",
                        principalTable: "Localizacoes",
                        principalColumn: "LocalizacaoId");
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                schema: "doce",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    VendaData = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    VendaCodVen = table.Column<int>(type: "integer", nullable: true),
                    VendaCodCli = table.Column<int>(type: "integer", nullable: true),
                    VendaValorItens = table.Column<decimal>(type: "money", nullable: true),
                    VendaValorEntrega = table.Column<decimal>(type: "money", nullable: true),
                    VendaValorTotal = table.Column<decimal>(type: "money", nullable: true),
                    VendaEndEntrega = table.Column<string>(type: "varchar", maxLength: 500, nullable: true),
                    VendaStatus = table.Column<string>(type: "varchar", maxLength: 1, nullable: true),
                    VendaCodLocal = table.Column<int>(type: "integer", nullable: true),
                    VendaObservacoes = table.Column<string>(type: "varchar", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_VendaCodCli",
                        column: x => x.VendaCodCli,
                        principalSchema: "doce",
                        principalTable: "Clientes",
                        principalColumn: "ClienteId");
                    table.ForeignKey(
                        name: "FK_Vendas_Localizacoes_VendaCodLocal",
                        column: x => x.VendaCodLocal,
                        principalSchema: "doce",
                        principalTable: "Localizacoes",
                        principalColumn: "LocalizacaoId");
                    table.ForeignKey(
                        name: "FK_Vendas_Vendedores_VendaCodVen",
                        column: x => x.VendaCodVen,
                        principalSchema: "doce",
                        principalTable: "Vendedores",
                        principalColumn: "VendedorId");
                });

            migrationBuilder.CreateTable(
                name: "SaldoProdutos",
                schema: "doce",
                columns: table => new
                {
                    SaldoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    SaldoCodProduto = table.Column<int>(type: "integer", nullable: false),
                    SaldoCodLocal = table.Column<int>(type: "integer", nullable: false),
                    SaldoEntProduto = table.Column<decimal>(type: "numeric(15,6)", nullable: false),
                    SaldoSaiProduto = table.Column<decimal>(type: "numeric(15,6)", nullable: false),
                    SaldoProduto = table.Column<decimal>(type: "numeric(15,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaldoProdutos", x => x.SaldoId);
                    table.ForeignKey(
                        name: "FK_SaldoProdutos_Localizacoes_SaldoCodLocal",
                        column: x => x.SaldoCodLocal,
                        principalSchema: "doce",
                        principalTable: "Localizacoes",
                        principalColumn: "LocalizacaoId");
                    table.ForeignKey(
                        name: "FK_SaldoProdutos_Produtos_SaldoCodProduto",
                        column: x => x.SaldoCodProduto,
                        principalSchema: "doce",
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId");
                });

            migrationBuilder.CreateTable(
                name: "ComprasItens",
                schema: "doce",
                columns: table => new
                {
                    CompraItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodCompra = table.Column<int>(type: "integer", nullable: false),
                    CodProduto = table.Column<int>(type: "integer", nullable: true),
                    QntItemCompra = table.Column<decimal>(type: "numeric(15,6)", nullable: true),
                    ValUniItemCompra = table.Column<decimal>(type: "money", nullable: true),
                    ValTotItemCompra = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComprasItens", x => x.CompraItemId);
                    table.ForeignKey(
                        name: "FK_ComprasItens_Compras_CodCompra",
                        column: x => x.CodCompra,
                        principalSchema: "doce",
                        principalTable: "Compras",
                        principalColumn: "CompraId");
                    table.ForeignKey(
                        name: "FK_ComprasItens_Produtos_CodProduto",
                        column: x => x.CodProduto,
                        principalSchema: "doce",
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId");
                });

            migrationBuilder.CreateTable(
                name: "VendasItens",
                schema: "doce",
                columns: table => new
                {
                    VendaItemId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CodVenda = table.Column<int>(type: "integer", nullable: false),
                    CodProduto = table.Column<int>(type: "integer", nullable: true),
                    QntItemVenda = table.Column<decimal>(type: "numeric(15,6)", nullable: true),
                    ValUniItemVenda = table.Column<decimal>(type: "money", nullable: true),
                    ValDescItemVenda = table.Column<decimal>(type: "money", nullable: true),
                    ValTotItemVenda = table.Column<decimal>(type: "money", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendasItens", x => x.VendaItemId);
                    table.ForeignKey(
                        name: "FK_VendasItens_Produtos_CodProduto",
                        column: x => x.CodProduto,
                        principalSchema: "doce",
                        principalTable: "Produtos",
                        principalColumn: "ProdutoId");
                    table.ForeignKey(
                        name: "FK_VendasItens_Vendas_CodVenda",
                        column: x => x.CodVenda,
                        principalSchema: "doce",
                        principalTable: "Vendas",
                        principalColumn: "VendaId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_CliCodEndereco",
                schema: "doce",
                table: "Clientes",
                column: "CliCodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CompraCodFor",
                schema: "doce",
                table: "Compras",
                column: "CompraCodFor");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_CompraCodLocal",
                schema: "doce",
                table: "Compras",
                column: "CompraCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasItens_CodCompra",
                schema: "doce",
                table: "ComprasItens",
                column: "CodCompra");

            migrationBuilder.CreateIndex(
                name: "IX_ComprasItens_CodProduto",
                schema: "doce",
                table: "ComprasItens",
                column: "CodProduto");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceiroPag_FinanCod",
                schema: "doce",
                table: "FinanceiroPag",
                column: "FinanCod");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ForCodEndereco",
                schema: "doce",
                table: "Fornecedores",
                column: "ForCodEndereco");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProCodGrupo",
                schema: "doce",
                table: "Produtos",
                column: "ProCodGrupo");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ProCodUni",
                schema: "doce",
                table: "Produtos",
                column: "ProCodUni");

            migrationBuilder.CreateIndex(
                name: "IX_SaldoProdutos_SaldoCodLocal",
                schema: "doce",
                table: "SaldoProdutos",
                column: "SaldoCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_SaldoProdutos_SaldoCodProduto",
                schema: "doce",
                table: "SaldoProdutos",
                column: "SaldoCodProduto");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_VendaCodCli",
                schema: "doce",
                table: "Vendas",
                column: "VendaCodCli");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_VendaCodLocal",
                schema: "doce",
                table: "Vendas",
                column: "VendaCodLocal");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_VendaCodVen",
                schema: "doce",
                table: "Vendas",
                column: "VendaCodVen");

            migrationBuilder.CreateIndex(
                name: "IX_VendasItens_CodProduto",
                schema: "doce",
                table: "VendasItens",
                column: "CodProduto");

            migrationBuilder.CreateIndex(
                name: "IX_VendasItens_CodVenda",
                schema: "doce",
                table: "VendasItens",
                column: "CodVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Vendedores_VenCodEndereco",
                schema: "doce",
                table: "Vendedores",
                column: "VenCodEndereco");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComprasItens",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "FinanceiroPag",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "SaldoProdutos",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "VendasItens",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Compras",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Financeiro",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Produtos",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Vendas",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Fornecedores",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Grupos",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Unidades",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Clientes",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Localizacoes",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Vendedores",
                schema: "doce");

            migrationBuilder.DropTable(
                name: "Enderecos",
                schema: "doce");
        }
    }
}
