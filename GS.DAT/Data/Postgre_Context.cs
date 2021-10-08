using GS.API.Data.Configuracoes;
using GS.API.Models;
using Microsoft.EntityFrameworkCore;

namespace GS.API.Data
{
    public class Postgre_Context : DbContext
    {
        public Postgre_Context(DbContextOptions<Postgre_Context> options) 
            : base(options){
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=DoceControl;User Id=postgres;Password=9854;", (x => x.SetPostgresVersion(9, 6)));            
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("doce");

            //Compras 
            modelBuilder.ApplyConfiguration(new ComprasConf());
            modelBuilder.ApplyConfiguration(new ComprasItensConf());
            modelBuilder.ApplyConfiguration(new FornecedoresConf());


            //Estoque
            modelBuilder.ApplyConfiguration(new GrupoConf());
            modelBuilder.ApplyConfiguration(new LocalizacoesConf());
            modelBuilder.ApplyConfiguration(new ProdutosConf());
            modelBuilder.ApplyConfiguration(new SaldoProdutosConf());
            modelBuilder.ApplyConfiguration(new UnidadesConf());

            //Financeiro
            modelBuilder.ApplyConfiguration(new FinanceiroConf());
            modelBuilder.ApplyConfiguration(new FinanceiroPagConf());

            //Vendas
            modelBuilder.ApplyConfiguration(new ClientesConf());
            modelBuilder.ApplyConfiguration(new EnderecosConf());
            modelBuilder.ApplyConfiguration(new VendasConf());
            modelBuilder.ApplyConfiguration(new VendasItensConf());
            modelBuilder.ApplyConfiguration(new VendedoresConf());

        }

        //Compras
        public DbSet<Compras> Compras { get; set; }
        public DbSet<ComprasItens> ComprasItens { get; set; }
        public DbSet<Fornecedores> Fornecedores { get; set; }

        //Estoque
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<Localizacoes> Localizacoes { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<SaldoProdutos> SaldoProdutos { get; set; }
        public DbSet<Unidades> Unidades { get; set; }

        //Financeiro
        public DbSet<Financeiro> Financeiro { get; set; }
        public DbSet<FinanceiroPag> FinanceiroPag { get; set; }

        //Vendas
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Enderecos> Enderecos { get; set; }
        public DbSet<Vendas> Vendas { get; set; }
        public DbSet<VendasItens> VendasItens { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
    }
}
