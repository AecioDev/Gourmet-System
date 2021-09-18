using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    class ClientesConf : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> etd)
        {
            etd.ToTable("Clientes");
            etd.HasKey(c => c.ClienteId).HasName("PK_Clientes");
            etd.Property(c => c.ClienteId).HasColumnName("ClienteId").ValueGeneratedOnAdd();
            etd.Property(c => c.ClienteNome).HasColumnName("ClienteNome").HasMaxLength(100);
            etd.Property(c => c.ClienteCelular).HasColumnName("ClienteCelular").HasMaxLength(20);
            etd.Property(c => c.ClienteDataNasc).HasColumnName("ClienteDataNasc");
            etd.Property(c => c.ClienteDataCad).HasColumnName("ClienteDataCad");
            etd.Property(c => c.ClienteStatus).HasColumnName("ClienteStatus");
            etd.Property(c => c.ClienteTotalCompras).HasColumnName("ClienteTotalCompras").HasColumnType("money");
            etd.Property(c => c.CliCodEndereco).HasColumnName("CliCodEndereco");

            etd.HasOne(c => c.Endereco).WithMany(d => d.Cliente)
           .HasForeignKey(c => c.CliCodEndereco)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
