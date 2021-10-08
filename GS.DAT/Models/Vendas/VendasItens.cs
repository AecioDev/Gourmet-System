using System;
using System.Collections.Generic;
using System.Text;

namespace GS.API.Models
{
    public class VendasItens
    {
        public int VendaItemId { get; set; }
        public int CodVenda { get; set; }
        public int? CodProduto { get; set; }
        public decimal? QntItemVenda { get; set; }
        public decimal? ValUniItemVenda { get; set; }
        public decimal? ValDescItemVenda { get; set; } //Desconto
        public decimal? ValTotItemVenda { get; set; }

        public virtual Vendas Venda { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
