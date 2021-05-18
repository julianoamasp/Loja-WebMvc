using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Newtonsoft.Json;
using Loja.DAO;

namespace Loja.Controllers
{
    public class ApiController : Controller
    {
        public string Index()
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
            return JsonConvert.SerializeObject(produtos);
        }
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
