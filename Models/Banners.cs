using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class Banners
    {
        private string BannersImagem;
        private string BannersTitulo;
        private string BannersSubTitulo;
        private string BannersDescricao;
        private string BannersLink;

        public Banners(string bannersImagem, string bannersTitulo, string bannersSubTitulo, string bannersDescricao, string bannersLink)
        {
            BannersImagem = bannersImagem;
            BannersTitulo = bannersTitulo;
            BannersSubTitulo = bannersSubTitulo;
            BannersDescricao = bannersDescricao;
            BannersLink = bannersLink;
        }

        public string BannersImagem1 { get => BannersImagem; set => BannersImagem = value; }
        public string BannersTitulo1 { get => BannersTitulo; set => BannersTitulo = value; }
        public string BannersSubTitulo1 { get => BannersSubTitulo; set => BannersSubTitulo = value; }
        public string BannersDescricao1 { get => BannersDescricao; set => BannersDescricao = value; }
        public string BannersLink1 { get => BannersLink; set => BannersLink = value; }
    }
}
