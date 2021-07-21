using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using Loja.DAO;
using MySql.Data.MySqlClient;

namespace Loja.DAO
{
    public class PaginaDAO
    {
        public List<Pagina> getPaginaPermalink(string permalink)
        {
            List<Pagina> pagina = new List<Pagina>();
            try
            {
                MySqlConnection conn = Fabricaconexao.conexao();

                string query = "SELECT * FROM paginas WHERE PaginasPermalink LIKE '" + permalink + "'";
                MySqlCommand comando = new MySqlCommand(query, conn);

                conn.Open();

                MySqlDataReader rd = comando.ExecuteReader();


                while (rd.Read())
                {
                    pagina.Add(
                        new Pagina(
                            Convert.ToInt32(rd["PaginasId"]),
                            Convert.ToString(rd["PaginasPermalink"]),
                            Convert.ToString(rd["PaginasTitulo"]),
                            Convert.ToString(rd["PaginasDesc"]),
                            Convert.ToString(rd["PaginasTags"])
                            )
                        );
                }
                conn.Close();
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return pagina;
        }
    }
}
