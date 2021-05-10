using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Categorias
    {
        public int id { get; set; }
        public string permalink { get; set; }
        public string titulo { get; set; }
        public string descricao { get; set; }
        public string tags { get; set; }
        public string imagem { get; set; }

        public Categorias(int id, string permalink, string titulo, string descricao, string tags, string imagem)
        {
            this.id = id;
            this.permalink = permalink;
            this.titulo = titulo;
            this.descricao = descricao;
            this.tags = tags;
            this.imagem = imagem;
        }
    }
}
