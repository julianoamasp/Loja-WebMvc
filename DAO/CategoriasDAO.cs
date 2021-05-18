using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Loja.Models;
using MySql.Data.MySqlClient;

namespace Loja.DAO
{
    public class CategoriasDAO
    {
        public List<Categorias> getCategorias()
        {
            List<Categorias> categorias = new List<Categorias>();
            try
            {
                MySqlConnection conn = Fabricaconexao.conexao();

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
    }
}
