using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class GrupoConf : IEntityTypeConfiguration<Grupos>
    {
        public void Configure(EntityTypeBuilder<Grupos> etd)
        {
            etd.ToTable("Grupos");
            etd.HasKey(c => c.GrupoId).HasName("PK_Grupos");
            etd.Property(c => c.GrupoId).HasColumnName("GrupoId").ValueGeneratedOnAdd();
            etd.Property(c => c.GrupoNome).HasColumnName("GrupoNome").HasMaxLength(20);
            etd.Property(c => c.GrupoPreco).HasColumnName("GrupoPreco").HasColumnType("money");
        }
    }
}
