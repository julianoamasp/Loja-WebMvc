using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Loja.DAO;
using MySql.Data.MySqlClient;

namespace Loja.DAO
{
    public class ProdutosDAO
    {
        public List<Produtos> getProdutos()
        {
            List<Produtos> produtos = new List<Produtos>();
            try
            {
                MySqlConnection conn = Fabricaconexao.conexao();

                string query = "SELECT * FROM produto,Categorias WHERE CategoriasId = ProdutoIdCategoria;";
                MySqlCommand comando = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader rd = comando.ExecuteReader();


                while (rd.Read())
                {
                    produtos.Add(
                        new Produtos(
                            Convert.ToInt32(rd["ProdutoId"]),
                            Convert.ToInt32(rd["ProdutoIdCategoria"]),
                            Convert.ToString(rd["ProdutoPermalink"]),
                            Convert.ToString(rd["ProdutoTitulo"]),
                            Convert.ToString(rd["ProdutoDescr"]),
                            Convert.ToString(rd["ProdutoTags"]),
                            Convert.ToString(rd["ProdutoThumb"]),
                            Convert.ToDecimal(rd["ProdutoPreco"]),
                            Convert.ToInt32(rd["ProdutoDesconto"])
                            )
                        );
                }
                conn.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return produtos;
        }
    }
}
