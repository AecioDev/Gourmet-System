using System.Collections.Generic;

namespace GS.API.Models
{
    public class Unidades
    {
        public int UnidadeId { get; set; }
        public string UnidadeNome { get; set; }
        public string UnidadeSigla { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
