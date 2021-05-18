using MySql.Data.MySqlClient;

namespace Loja.DAO
{
    public static class Fabricaconexao
    {
        public static MySqlConnection conexao()
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=loja");
            return conn;
        }
       
    }
}
