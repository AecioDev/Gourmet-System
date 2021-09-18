using System;
using System.Collections.Generic;

namespace  GS.API.Models
{
    public class Compras
    {
        public int CompraId { get; set; }
        public DateTime? CompraData { get; set; }
        public int? CompraCodFor { get; set; }
        public decimal? CompraValorItens { get; set; }
        public decimal? CompraValorFrete { get; set; }
        public decimal? CompraValorTotal { get; set; }
        public string CompraStatus { get; set; } //Aberta - Fechada
        public int? CompraCodLocal { get; set; } //Código do Local de Armazenamento

        public virtual Fornecedores Fornecedor { get; set; }
        public virtual Localizacoes Local { get; set; }
        public List<ComprasItens> CompraItens { get; set; }

    }
}
