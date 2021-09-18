using GS.API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GS.API.Data.Configuracoes
{
    public class FinanceiroConf : IEntityTypeConfiguration<Financeiro>
    {
        public void Configure(EntityTypeBuilder<Financeiro> etd)
        {
            etd.ToTable("Financeiro");
            etd.HasKey(c => c.FinanceiroId).HasName("PK_Financeiro");
            etd.Property(c => c.FinanceiroId).HasColumnName("FinanceiroId").ValueGeneratedOnAdd();
            etd.Property(c => c.FinanMov).HasColumnName("FinanMov").HasColumnType("varchar").HasMaxLength(1); //Pagar, Receber;
            etd.Property(c => c.FinanStatus).HasColumnName("FinanStatus").HasColumnType("varchar").HasMaxLength(1); //Aberto / Parcial / Liquidado;
            etd.Property(c => c.FinanCodOrigem).HasColumnName("FinanCodOrigem");
            etd.Property(c => c.CodCliForOrigem).HasColumnName("CodCliForOrigem");
            etd.Property(c => c.FinanDataDig).HasColumnName("FinanDataDig");
            etd.Property(c => c.FinanVencimento).HasColumnName("FinanVencimento");
            etd.Property(c => c.FinanValorTotal).HasColumnName("FinanValorTotal").HasColumnType("money");
            etd.Property(c => c.FinanValorPago).HasColumnName("FinanValorPago").HasColumnType("money");
            etd.Property(c => c.FinanValorSaldo).HasColumnName("FinanValorSaldo").HasColumnType("money");
            etd.Property(c => c.FinanDataUltPag).HasColumnName("FinanDataUltPag");
        }
    }
}
