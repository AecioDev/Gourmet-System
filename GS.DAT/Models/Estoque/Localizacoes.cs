using System.Collections.Generic;

namespace GS.API.Models
{
    public class Localizacoes
    {
        public int LocalizacaoId { get; set; }
        public string LocalizacaoNome { get; set; }

        public List<Compras> Compra { get; set; }
        public List<Vendas> Venda { get; set; }
        public List<SaldoProdutos> Saldo { get; set; }
    }
}
