using System;
using System.Collections.Generic;
using System.Text;

namespace GS.API.Models
{
    public class Vendedores
    {
        public int VendedorId { get; set; }
        public string VendedorNome { get; set; }
        public string VendedorCelular { get; set; }
        public DateTime? VendedorDataNasc { get; set; }
        public DateTime? VendedorDataCad { get; set; }
        public bool? VendedorAtivo { get; set; }
        public bool? VendedorComissao { get; set; }
        public decimal? VendedorTotalVendas { get; set; } //Total Bruto que o Vendedor já vendeu
        public int? VenCodEndereco { get; set; }

        public virtual Enderecos Endereco { get; set; }
        public List<Vendas> Venda { get; set; }
    }
}
