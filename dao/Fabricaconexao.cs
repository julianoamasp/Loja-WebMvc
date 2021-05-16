using MySql.Data.MySqlClient;

namespace Loja.dao
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
