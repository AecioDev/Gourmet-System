using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class ComprasItensConf : IEntityTypeConfiguration<ComprasItens>
    {
        public void Configure(EntityTypeBuilder<ComprasItens> etd)
        {
            etd.ToTable("ComprasItens");
            etd.HasKey(c => c.CompraItemId).HasName("PK_ComprasItens");
            etd.Property(c => c.CompraItemId).HasColumnName("CompraItemId").ValueGeneratedOnAdd();
            etd.Property(c => c.CodCompra).HasColumnName("CodCompra");
            etd.Property(c => c.CodProduto).HasColumnName("CodProduto");
            etd.Property(c => c.QntItemCompra).HasColumnName("QntItemCompra").HasColumnType("numeric(15,6)");
            etd.Property(c => c.ValUniItemCompra).HasColumnName("ValUniItemCompra").HasColumnType("money");
            etd.Property(c => c.ValTotItemCompra).HasColumnName("ValTotItemCompra").HasColumnType("money");

            etd.HasOne(c => c.Compra).WithMany(d => d.CompraItens)
           .HasForeignKey(c => c.CodCompra)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Produto).WithMany(d => d.CompraItens)
           .HasForeignKey(c => c.CodProduto)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
