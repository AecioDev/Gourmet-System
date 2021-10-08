using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class FinanceiroPagConf : IEntityTypeConfiguration<FinanceiroPag>
    {
        public void Configure(EntityTypeBuilder<FinanceiroPag> etd)
        {
            etd.ToTable("FinanceiroPag");
            etd.HasKey(c => c.FinanPagId).HasName("PK_FinanceiroPag");
            etd.Property(c => c.FinanPagId).HasColumnName("FinanPagId").ValueGeneratedOnAdd();
            etd.Property(c => c.FinanCod).HasColumnName("FinanCod");
            etd.Property(c => c.FinanDataPag).HasColumnName("FinanDataPag");
            etd.Property(c => c.FinanValorPag).HasColumnName("FinanValorPag").HasColumnType("money");

            etd.HasOne(c => c.Finan).WithMany(d => d.FinanPag)
           .HasForeignKey(c => c.FinanCod)
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
