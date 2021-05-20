using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;

namespace Loja.DAO
{
    public class DadosEmpresaDAO
    {
        public DadosEmpresa getDadosEmpresa()
        {
            DadosEmpresa dadosEmpresa = new DadosEmpresa();
            try
            {
                MySqlConnection conn = Fabricaconexao.conexao();

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
    }
}
