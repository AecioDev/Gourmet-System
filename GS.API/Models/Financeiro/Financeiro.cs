using System;
using System.Collections.Generic;

namespace GS.API.Models
{
    public class Financeiro
    {
        public int FinanceiroId { get; set; }
        public string FinanMov { get; set; }            //Pagar / Receber
        public string FinanStatus { get; set; }         //Aberto / Parcial / Liquidado
        public int? FinanCodOrigem { get; set; }         //Código Compra ou Venda / Zero se for Manual
        public int? CodCliForOrigem { get; set; }        //Codigo do Cliente ou Fornecedor
        public DateTime? FinanDataDig { get; set; }      //Data da Digitação Geração
        public DateTime? FinanVencimento { get; set; }
        public decimal? FinanValorTotal { get; set; }    //Valor do Titulo
        public decimal? FinanValorPago { get; set; }     //Valor que já Foi Pago
        public decimal? FinanValorSaldo { get; set; }    //Valor que Falta Pagar
        public DateTime? FinanDataUltPag { get; set; }   //Data do Ultimo Pagamento

        public List<FinanceiroPag> FinanPag { get; set; }
    }
}
