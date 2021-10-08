
namespace GS.API.Models
{
    public class ComprasItens
    {
        public int CompraItemId { get; set; }
        public int CodCompra { get; set; }
        public int? CodProduto { get; set; }
        public decimal? QntItemCompra { get; set; }
        public decimal? ValUniItemCompra { get; set; }
        public decimal? ValTotItemCompra { get; set; }

        public virtual Compras Compra { get; set; }
        public virtual Produtos Produto { get; set; }
    }
}
