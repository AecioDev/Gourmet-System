using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class SaldoProdutosConf : IEntityTypeConfiguration<SaldoProdutos>
    {
        public void Configure(EntityTypeBuilder<SaldoProdutos> etd)
        {
            etd.ToTable("SaldoProdutos");
            etd.HasKey(c => c.SaldoId).HasName("PK_SaldoProdutos");
            etd.Property(c => c.SaldoId).HasColumnName("SaldoId").ValueGeneratedOnAdd();
            etd.Property(c => c.SaldoCodProduto).HasColumnName("SaldoCodProduto");
            etd.Property(c => c.SaldoCodLocal).HasColumnName("SaldoCodLocal");
            etd.Property(c => c.SaldoEntProduto).HasColumnName("SaldoEntProduto").HasColumnType("numeric(15,6)");
            etd.Property(c => c.SaldoSaiProduto).HasColumnName("SaldoSaiProduto").HasColumnType("numeric(15,6)");
            etd.Property(c => c.SaldoProduto).HasColumnName("SaldoProduto").HasColumnType("numeric(15,6)");

            etd.HasOne(c => c.Produto).WithMany(d => d.Saldo)
           .HasForeignKey(c => c.SaldoCodProduto)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Local).WithMany(d => d.Saldo)
           .HasForeignKey(c => c.SaldoCodLocal)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
