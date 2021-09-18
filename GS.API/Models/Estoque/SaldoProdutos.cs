
namespace GS.API.Models
{
    public class SaldoProdutos
    {
        public int SaldoId { get; set; }
        public int SaldoCodProduto { get; set; }
        public int SaldoCodLocal { get; set; }
        public decimal SaldoEntProduto { get; set; }
        public decimal SaldoSaiProduto { get; set; }
        public decimal SaldoProduto { get; set; }

        public virtual Produtos Produto { get; set; }
        public virtual Localizacoes Local { get; set; }
    }
}
