using System;

namespace GS.API.Models
{
    public class FinanceiroPag
    {
        public int FinanPagId { get; set; }
        public int FinanCod { get; set; }           //Código do Titulo
        public DateTime FinanDataPag { get; set; }  //Data do Pagamento
        public decimal FinanValorPag { get; set; }  //Valor pago

        public virtual Financeiro Finan { get; set; }
    }
}
