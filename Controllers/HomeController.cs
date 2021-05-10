using MySql.Data.MySqlClient;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Loja.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string pagina="")
        {
            DadosEmpresa dadosDaEmpresa = getDadosEmpresa();
            
            ViewBag.banners =  getBanners();
            ViewBag.categorias = getCategorias();
            ViewBag.produtos = getProdutos();

            ViewData["endereco"] = dadosDaEmpresa.DadosEmpresaEndereco1;
            ViewData["bairro"] = dadosDaEmpresa.DadosEmpresaBairro1;
            ViewData["cidade"] = dadosDaEmpresa.DadosEmpresaCidade1;
            ViewData["estado"] = dadosDaEmpresa.DadosEmpresaEstado1;
            ViewData["email"] = dadosDaEmpresa.DadosEmpresaEmail1;
            ViewData["telefone"] = dadosDaEmpresa.DadosEmpresaTelefone1;
            ViewData["whatsapp"] = dadosDaEmpresa.DadosEmpresaWhatsapp1;
            ViewData["homeFantasia"] = dadosDaEmpresa.DadosEmpresaNomeFantasia1;
            ViewData["resumo-rodape"] = dadosDaEmpresa.DadosEmpresaResumoQuemSomos1;

            if (pagina == "")
            {
                return View();
            }
            else
            {
                return View(pagina);
            }
        }

        public IActionResult Contato()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public DadosEmpresa getDadosEmpresa()
        {
            DadosEmpresa dadosEmpresa = new DadosEmpresa();
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=loja");

                string query = "SELECT* FROM dadosempresa WHERE DadosEmpresaId = 1";
                MySqlCommand comando = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    //dadosEmpresa.Nome = Convert.ToInt16(rd["AdministradoresId"]),
                    dadosEmpresa.DadosEmpresaCNPJ1 = Convert.ToString(rd["DadosEmpresaCNPJ"]);
                    dadosEmpresa.DadosEmpresaNomeFantasia1 = Convert.ToString(rd["DadosEmpresaNomeFantasia"]);
                    dadosEmpresa.DadosEmpresaNome1 = Convert.ToString(rd["DadosEmpresaNome"]);
                    dadosEmpresa.DadosEmpresaResumoQuemSomos1 = Convert.ToString(rd["DadosEmpresaResumoQuemSomos"]);
                    dadosEmpresa.DadosEmpresaEndereco1 = Convert.ToString(rd["DadosEmpresaEndereco"]);
                    dadosEmpresa.DadosEmpresaBairro1 = Convert.ToString(rd["DadosEmpresaBairro"]);
                    dadosEmpresa.DadosEmpresaCidade1 = Convert.ToString(rd["DadosEmpresaCidade"]);
                    dadosEmpresa.DadosEmpresaEstado1 = Convert.ToString(rd["DadosEmpresaEstado"]);
                    dadosEmpresa.DadosEmpresaEmail1 = Convert.ToString(rd["DadosEmpresaEmail"]);
                    dadosEmpresa.DadosEmpresaTelefone1 = Convert.ToString(rd["DadosEmpresaTelefone"]);
                    dadosEmpresa.DadosEmpresaWhatsapp1 = Convert.ToString(rd["DadosEmpresaWhatsapp"]);
                }
                conn.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return dadosEmpresa;
        }
        public List<Banners> getBanners()
        {
            List<Banners> banners = new List<Banners>();
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=loja");

                string query = "SELECT* FROM `banners`";
                MySqlCommand comando = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    banners.Add(
                        new Banners(
                            Convert.ToString(rd["BannersImagem"]),
                            Convert.ToString(rd["BannersTitulo"]),
                            Convert.ToString(rd["BannersSubTitulo"]),
                            Convert.ToString(rd["BannersDescricao"]),
                            Convert.ToString(rd["BannersLink"])
                            )
                        );
                }
                conn.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return banners;
        }
        public List<Categorias> getCategorias()
        {
            List<Categorias> categorias = new List<Categorias>();
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=loja");

                string query = "SELECT * FROM `categorias`;";
                MySqlCommand comando = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader rd = comando.ExecuteReader();

                while (rd.Read())
                {
                    categorias.Add(
                        new Categorias(
                            Convert.ToInt32(rd["CategoriasId"]),
                            Convert.ToString(rd["CategoriasPermalink"]),
                            Convert.ToString(rd["CategoriasTitulo"]),
                            Convert.ToString(rd["CategoriasDesc"]),
                            Convert.ToString(rd["CategoriasTags"]),
                            Convert.ToString(rd["CategoriasImagem"])
                            )
                        );
                }
                conn.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return categorias;
        }

        public List<Produtos> getProdutos()
        {
            List<Produtos> produtos = new List<Produtos>();
            try
            {
                MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=loja");

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
