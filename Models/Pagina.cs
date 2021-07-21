using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Pagina
    {
        public Pagina() { }
        public Pagina(int paginasId, string paginasPermalink, string paginasTitulo, string paginasDesc, string paginasTags)
        {
            PaginasId = paginasId;
            PaginasPermalink = paginasPermalink;
            PaginasTitulo = paginasTitulo;
            PaginasDesc = paginasDesc;
            PaginasTags = paginasTags;
        }

        public int PaginasId { get; set; }
        public string PaginasPermalink { get; set; }
        public string PaginasTitulo { get; set; }
        public string PaginasDesc { get; set; }
        public string PaginasTags { get; set; }
    }
}
