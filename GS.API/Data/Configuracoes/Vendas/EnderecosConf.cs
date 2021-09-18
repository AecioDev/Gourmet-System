using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class EnderecosConf : IEntityTypeConfiguration<Enderecos>
    {
        public void Configure(EntityTypeBuilder<Enderecos> etd)
        {
            etd.ToTable("Enderecos");
            etd.HasKey(c => c.EnderecoId).HasName("PK_Enderecos");
            etd.Property(c => c.EnderecoId).HasColumnName("EnderecoId").ValueGeneratedOnAdd();
            etd.Property(c => c.EnderecoTipo).HasColumnName("EnderecoTipo").HasColumnType("varchar").HasMaxLength(1); //Cliente, Vendedor, Fornecedor
            etd.Property(c => c.EnderecoCEP).HasColumnName("EnderecoCEP").HasColumnType("varchar").HasMaxLength(10);
            etd.Property(c => c.EnderecoRua).HasColumnName("EnderecoRua").HasColumnType("varchar").HasMaxLength(100);
            etd.Property(c => c.EnderecoNum).HasColumnName("EnderecoNum").HasColumnType("varchar").HasMaxLength(10);
            etd.Property(c => c.EnderecoComplemento).HasColumnName("EnderecoComplemento").HasColumnType("varchar").HasMaxLength(100);
            etd.Property(c => c.EnderecoBairro).HasColumnName("EnderecoBairro").HasColumnType("varchar").HasMaxLength(100);
            etd.Property(c => c.EnderecoCidade).HasColumnName("EnderecoCidade").HasColumnType("varchar").HasMaxLength(50);
            etd.Property(c => c.EnderecoUF).HasColumnName("EnderecoUF").HasColumnType("varchar").HasMaxLength(2);
        }
    }
}
