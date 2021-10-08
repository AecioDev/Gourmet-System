using System.Collections.Generic;

namespace GS.API.Models
{
    public class Grupos
    {
        public int GrupoId { get; set; }
        public string GrupoNome { get; set; }
        public decimal? GrupoPreco { get; set; }

        public List<Produtos> Produtos { get; set; }
    }
}
