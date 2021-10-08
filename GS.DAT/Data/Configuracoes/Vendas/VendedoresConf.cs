using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    class VendedoresConf : IEntityTypeConfiguration<Vendedores>
    {
        public void Configure(EntityTypeBuilder<Vendedores> etd)
        {
            etd.ToTable("Vendedores");
            etd.HasKey(c => c.VendedorId).HasName("PK_Vendedores");
            etd.Property(c => c.VendedorId).HasColumnName("VendedorId").ValueGeneratedOnAdd();
            etd.Property(c => c.VendedorNome).HasColumnName("VendedorNome").HasMaxLength(100);
            etd.Property(c => c.VendedorCelular).HasColumnName("VendedorCelular").HasMaxLength(20);
            etd.Property(c => c.VendedorDataNasc).HasColumnName("VendedorDataNasc");
            etd.Property(c => c.VendedorDataCad).HasColumnName("VendedorDataCad");
            etd.Property(c => c.VendedorAtivo).HasColumnName("VendedorAtivo");
            etd.Property(c => c.VendedorTotalVendas).HasColumnName("VendedorTotalVendas").HasColumnType("money");
            etd.Property(c => c.VenCodEndereco).HasColumnName("VenCodEndereco");

            etd.HasOne(c => c.Endereco).WithMany(d => d.Vendedor)
           .HasForeignKey(c => c.VenCodEndereco)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
