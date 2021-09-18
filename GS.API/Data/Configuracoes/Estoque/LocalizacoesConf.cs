using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace GS.API.Data.Configuracoes
{
    public class LocalizacoesConf : IEntityTypeConfiguration<Localizacoes>
    {
        public void Configure(EntityTypeBuilder<Localizacoes> etd)
        {
            etd.ToTable("Localizacoes");
            etd.HasKey(c => c.LocalizacaoId).HasName("PK_Localizacoes");
            etd.Property(c => c.LocalizacaoId).HasColumnName("LocalizacaoId").ValueGeneratedOnAdd();
            etd.Property(c => c.LocalizacaoNome).HasColumnName("LocalizacaoNome").HasMaxLength(20);
        }
    }
}
