using System;
using System.Collections.Generic;
using System.Text;

namespace GS.API.Models
{
    public class Vendas
    {
        public int VendaId { get; set; }
        public DateTime? VendaData { get; set; }
        public int? VendaCodVen { get; set; }
        public int? VendaCodCli { get; set; }
        public decimal? VendaValorItens { get; set; }
        public decimal? VendaValorEntrega { get; set; }
        public decimal? VendaValorTotal { get; set; }
        public string VendaEndEntrega { get; set; }        
        public string VendaStatus { get; set; } //Aberta - Fechada
        public int? VendaCodLocal { get; set; } //Código do Local de Armazenamento
        public string VendaObservacoes { get; set; }

        public virtual Vendedores Vendedor { get; set; }
        public virtual Clientes Cliente { get; set; }
        public virtual Localizacoes Local { get; set; }
        public List<VendasItens> VendaItens { get; set; }
    }
}
