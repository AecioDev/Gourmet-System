using System;
using System.Collections.Generic;

namespace GS.API.Models
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string ClienteNome { get; set; }
        public string ClienteCelular { get; set; }
        public DateTime? ClienteDataNasc { get; set; }
        public DateTime? ClienteDataCad { get; set; }
        public bool? ClienteStatus { get; set; } //Adimplente / Inadimplente
        public decimal? ClienteTotalCompras { get; set; } //Total que o Cliente já Comprou.
        public int? CliCodEndereco { get; set; }
        public virtual Enderecos Endereco { get; set; }

        public List<Vendas> Venda { get; set; }
    }
}
