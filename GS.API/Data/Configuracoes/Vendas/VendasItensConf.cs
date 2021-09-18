using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class VendasItensConf : IEntityTypeConfiguration<VendasItens>
    {
        public void Configure(EntityTypeBuilder<VendasItens> etd)
        {
            etd.ToTable("VendasItens");
            etd.HasKey(c => c.VendaItemId).HasName("PK_VendasItens");
            etd.Property(c => c.VendaItemId).HasColumnName("VendaItemId").ValueGeneratedOnAdd();
            etd.Property(c => c.CodVenda).HasColumnName("CodVenda");
            etd.Property(c => c.CodProduto).HasColumnName("CodProduto");
            etd.Property(c => c.QntItemVenda).HasColumnName("QntItemVenda").HasColumnType("numeric(15,6)");
            etd.Property(c => c.ValUniItemVenda).HasColumnName("ValUniItemVenda").HasColumnType("money");
            etd.Property(c => c.ValDescItemVenda).HasColumnName("ValDescItemVenda").HasColumnType("money");
            etd.Property(c => c.ValTotItemVenda).HasColumnName("ValTotItemVenda").HasColumnType("money");

            etd.HasOne(c => c.Venda).WithMany(d => d.VendaItens)
           .HasForeignKey(c => c.CodVenda)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Produto).WithMany(d => d.VendaItens)
           .HasForeignKey(c => c.CodProduto)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
