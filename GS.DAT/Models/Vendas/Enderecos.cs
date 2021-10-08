using System.Collections.Generic;

namespace GS.API.Models
{ 
    public class Enderecos
    {
        public int EnderecoId { get; set; }
        public string EnderecoTipo { get; set; } //Vendedor / Cliente / Fornecedor
        public string EnderecoCEP { get; set; }
        public string EnderecoRua { get; set; }
        public string EnderecoNum { get; set; }
        public string EnderecoComplemento { get; set; }
        public string EnderecoBairro { get; set; }
        public string EnderecoCidade { get; set; }
        public string EnderecoUF { get; set; }

        public List<Clientes> Cliente { get; set; }
        public List<Vendedores> Vendedor { get; set; }
        public List<Fornecedores> Fornecedor { get; set; }
    }
}
