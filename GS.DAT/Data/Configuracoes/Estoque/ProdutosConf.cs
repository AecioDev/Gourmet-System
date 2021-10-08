using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class ProdutosConf : IEntityTypeConfiguration<Produtos>
    {
        public void Configure(EntityTypeBuilder<Produtos> etd)
        {
            etd.ToTable("Produtos");
            etd.HasKey(c => c.ProdutoId).HasName("PK_Produtos");
            etd.Property(c => c.ProdutoId).HasColumnName("ProdutoId").ValueGeneratedOnAdd();
            etd.Property(c => c.ProdutoNome).HasColumnName("ProdutoNome").HasMaxLength(100);
            etd.Property(c => c.ProdutoTipo).HasColumnName("ProdutoTipo").HasColumnType("varchar").HasMaxLength(1); //Matéria Prima, Consumo, Revenda
            etd.Property(c => c.ProPrecoAtual).HasColumnName("ProPrecoAtual").HasColumnType("money");
            etd.Property(c => c.ProCustoAtual).HasColumnName("ProCustoAtual").HasColumnType("numeric(15,6)");            
            etd.Property(c => c.ProdutoAtivo).HasColumnName("ProdutoAtivo");
            etd.Property(c => c.ProPrecoGrupo).HasColumnName("ProPrecoGrupo");
            etd.Property(c => c.ProCodUni).HasColumnName("ProCodUni");
            etd.Property(c => c.ProCodGrupo).HasColumnName("ProCodGrupo");

            etd.HasOne(c => c.Unidade).WithMany(d => d.Produtos)
            .HasForeignKey(c => c.ProCodUni)
            .OnDelete(DeleteBehavior.NoAction);

            etd.HasOne(c => c.Grupo).WithMany(d => d.Produtos)
            .HasForeignKey(c => c.ProCodGrupo)
            .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
