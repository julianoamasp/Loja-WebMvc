using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loja.Models
{
    public class DadosEmpresa
    {
        private string DadosEmpresaCNPJ;
        private string DadosEmpresaNomeFantasia;
        private string DadosEmpresaNome;
        private string DadosEmpresaResumoQuemSomos;
        private string DadosEmpresaEndereco;
        private string DadosEmpresaBairro;
        private string DadosEmpresaCidade;
        private string DadosEmpresaEstado;
        private string DadosEmpresaEmail;
        private string DadosEmpresaTelefone;
        private string DadosEmpresaWhatsapp;

        public string DadosEmpresaCNPJ1 { get => DadosEmpresaCNPJ; set => DadosEmpresaCNPJ = value; }
        public string DadosEmpresaNomeFantasia1 { get => DadosEmpresaNomeFantasia; set => DadosEmpresaNomeFantasia = value; }
        public string DadosEmpresaNome1 { get => DadosEmpresaNome; set => DadosEmpresaNome = value; }
        public string DadosEmpresaResumoQuemSomos1 { get => DadosEmpresaResumoQuemSomos; set => DadosEmpresaResumoQuemSomos = value; }
        public string DadosEmpresaEndereco1 { get => DadosEmpresaEndereco; set => DadosEmpresaEndereco = value; }
        public string DadosEmpresaBairro1 { get => DadosEmpresaBairro; set => DadosEmpresaBairro = value; }
        public string DadosEmpresaCidade1 { get => DadosEmpresaCidade; set => DadosEmpresaCidade = value; }
        public string DadosEmpresaEstado1 { get => DadosEmpresaEstado; set => DadosEmpresaEstado = value; }
        public string DadosEmpresaEmail1 { get => DadosEmpresaEmail; set => DadosEmpresaEmail = value; }
        public string DadosEmpresaTelefone1 { get => DadosEmpresaTelefone; set => DadosEmpresaTelefone = value; }
        public string DadosEmpresaWhatsapp1 { get => DadosEmpresaWhatsapp; set => DadosEmpresaWhatsapp = value; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
