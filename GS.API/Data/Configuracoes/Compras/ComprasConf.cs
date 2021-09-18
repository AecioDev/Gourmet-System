using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class ComprasConf : IEntityTypeConfiguration<Compras>
    {
        public void Configure(EntityTypeBuilder<Compras> etd)
        {
            etd.ToTable("Compras");
            etd.HasKey(c => c.CompraId).HasName("PK_Compras");
            etd.Property(c => c.CompraId).HasColumnName("CompraId").ValueGeneratedOnAdd();
            etd.Property(c => c.CompraData).HasColumnName("CompraData");
            etd.Property(c => c.CompraCodFor).HasColumnName("CompraCodFor");
            etd.Property(c => c.CompraValorItens).HasColumnName("CompraValorItens").HasColumnType("money");
            etd.Property(c => c.CompraValorFrete).HasColumnName("CompraValorFrete").HasColumnType("money");
            etd.Property(c => c.CompraValorTotal).HasColumnName("CompraValorTotal").HasColumnType("money");
            etd.Property(c => c.CompraStatus).HasColumnName("CompraStatus").HasColumnType("varchar").HasMaxLength(1); //Aberta, Fechada
            etd.Property(c => c.CompraCodLocal).HasColumnName("CompraCodLocal");

            etd.HasOne(c => c.Fornecedor).WithMany(d => d.Compra)
           .HasForeignKey(c => c.CompraCodFor)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Local).WithMany(d => d.Compra)
           .HasForeignKey(c => c.CompraCodLocal)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
