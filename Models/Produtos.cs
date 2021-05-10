using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public int ProdutoIdCategoria { get; set; }
        public string ProdutoPermalink { get; set; }
        public string ProdutoTitulo { get; set; }
        public string ProdutoDescr { get; set; }
        public string ProdutoTags { get; set; }
        public string ProdutoThumb { get; set; }
        public decimal ProdutoPreco { get; set; }
        public int ProdutoDesconto { get; set; }

        public Produtos(int produtoId, int produtoIdCategoria, string produtoPermalink, string produtoTitulo, string produtoDescr, string produtoTags, string produtoThumb, decimal produtoPreco, int produtoDesconto)
        {
            ProdutoId = produtoId;
            ProdutoIdCategoria = produtoIdCategoria;
            ProdutoPermalink = produtoPermalink;
            ProdutoTitulo = produtoTitulo;
            ProdutoDescr = produtoDescr;
            ProdutoTags = produtoTags;
            ProdutoThumb = produtoThumb;
            ProdutoPreco = produtoPreco;
            ProdutoDesconto = produtoDesconto;
        }
    }
}
