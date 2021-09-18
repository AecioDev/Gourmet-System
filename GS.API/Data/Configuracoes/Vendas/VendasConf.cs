using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class VendasConf : IEntityTypeConfiguration<Vendas>
    {
        public void Configure(EntityTypeBuilder<Vendas> etd)
        {
            etd.ToTable("Vendas");
            etd.HasKey(c => c.VendaId).HasName("PK_Vendas");
            etd.Property(c => c.VendaId).HasColumnName("VendaId").ValueGeneratedOnAdd();
            etd.Property(c => c.VendaData).HasColumnName("VendaData");
            etd.Property(c => c.VendaCodVen).HasColumnName("VendaCodVen");
            etd.Property(c => c.VendaCodCli).HasColumnName("VendaCodCli");
            etd.Property(c => c.VendaValorItens).HasColumnName("VendaValorItens").HasColumnType("money");
            etd.Property(c => c.VendaValorEntrega).HasColumnName("VendaValorEntrega").HasColumnType("money");
            etd.Property(c => c.VendaValorTotal).HasColumnName("VendaValorTotal").HasColumnType("money");
            etd.Property(c => c.VendaEndEntrega).HasColumnName("VendaEndEntrega").HasColumnType("varchar").HasMaxLength(500);
            etd.Property(c => c.VendaStatus).HasColumnName("VendaStatus").HasColumnType("varchar").HasMaxLength(1); //Aberta, Fechada
            etd.Property(c => c.VendaCodLocal).HasColumnName("VendaCodLocal");
            etd.Property(c => c.VendaObservacoes).HasColumnName("VendaObservacoes").HasColumnType("varchar").HasMaxLength(1000);

            etd.HasOne(c => c.Vendedor).WithMany(d => d.Venda)
           .HasForeignKey(c => c.VendaCodVen)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Cliente).WithMany(d => d.Venda)
           .HasForeignKey(c => c.VendaCodCli)
           .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Local).WithMany(d => d.Venda)
           .HasForeignKey(c => c.VendaCodLocal)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
