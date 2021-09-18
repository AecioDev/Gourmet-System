using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class UnidadesConf : IEntityTypeConfiguration<Unidades>
    {
        public void Configure(EntityTypeBuilder<Unidades> etd)
        {
            etd.ToTable("Unidades");
            etd.HasKey(c => c.UnidadeId).HasName("PK_Unidades");
            etd.Property(c => c.UnidadeId).HasColumnName("UnidadeId").ValueGeneratedOnAdd();
            etd.Property(c => c.UnidadeNome).HasColumnName("UnidadeNome").HasMaxLength(20);
            etd.Property(c => c.UnidadeSigla).HasColumnName("UnidadeSigla").HasMaxLength(5);
        }
    }
}
