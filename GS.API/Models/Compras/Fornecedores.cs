using System.Collections.Generic;

namespace GS.API.Models
{
    public class Fornecedores
    {
        public int FornecedorId { get; set; }
        public string FornecedorNome { get; set; }
        public string FornecedorCNPJ { get; set; }
        public int? ForCodEndereco { get; set; }
        public virtual Enderecos Endereco { get; set; }

        public List<Compras> Compra { get; set; }
    }
}
