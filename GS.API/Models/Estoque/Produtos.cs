using System.Collections.Generic;

namespace GS.API.Models
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string ProdutoTipo { get; set; }
        public decimal? ProPrecoAtual { get; set; }
        public decimal? ProCustoAtual { get; set; } //O Custo sempre vai Atualizar pela média        
        public bool? ProdutoAtivo { get; set; }
        public bool? ProPrecoGrupo { get; set; } //Utiliza preço por grupo?
        public int? ProCodUni { get; set; }
        public int? ProCodGrupo { get; set; }

        public virtual Unidades Unidade { get; set; }
        public virtual Grupos Grupo { get; set; }
        public List<ComprasItens> CompraItens { get; set; }
        public List<VendasItens> VendaItens { get; set; }
        public List<SaldoProdutos> Saldo { get; set; }
    }
}
