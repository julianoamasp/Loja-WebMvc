using MySql.Data.MySqlClient;
using Loja.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Loja.dao;
using Loja.DAO;
using MySqlX.XDevAPI;

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
            BannersDAO bannersDao = new BannersDAO();
            CategoriasDAO categoriasDao = new CategoriasDAO();
            ProdutosDAO produtosDao = new ProdutosDAO();

            DadosEmpresa dadosDaEmpresa = getDadosEmpresa();
            ViewBag.banners = bannersDao.getBanners();
            ViewBag.categorias = categoriasDao.getCategorias();
            ViewBag.produtos = produtosDao.getProdutos();

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
       
    }
}
