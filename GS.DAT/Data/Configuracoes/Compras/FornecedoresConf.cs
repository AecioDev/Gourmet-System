using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class FornecedoresConf : IEntityTypeConfiguration<Fornecedores>
    {
        public void Configure(EntityTypeBuilder<Fornecedores> etd)
        {
            etd.ToTable("Fornecedores");
            etd.HasKey(c => c.FornecedorId).HasName("PK_Fornecedores");
            etd.Property(c => c.FornecedorId).HasColumnName("FornecedorId").ValueGeneratedOnAdd();
            etd.Property(c => c.FornecedorNome).HasColumnName("FornecedorNome").HasMaxLength(100);
            etd.Property(c => c.FornecedorCNPJ).HasColumnName("FornecedorCNPJ").HasMaxLength(14);
            etd.Property(c => c.ForCodEndereco).HasColumnName("ForCodEndereco");

            etd.HasOne(c => c.Endereco).WithMany(d => d.Fornecedor)
           .HasForeignKey(c => c.ForCodEndereco)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
