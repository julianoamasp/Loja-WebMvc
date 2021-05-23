using System;
using System.Collections.Generic;
using Loja.Models;
using Loja.DAO;
using MySql.Data.MySqlClient;

namespace Loja.dao
{
    public class BannersDAO
    {
        public List<Banners> getBanners()
        {
            List<Banners> banners = new List<Banners>();
            try
            {
                MySqlConnection conn = Fabricaconexao.conexao();

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
    }
}
