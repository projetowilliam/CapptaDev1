using MySql.Data.MySqlClient;

namespace SinalVeiculos
{
    public static class DataBaseConnection
    {
        public static MySqlConnection Open()
        {
            var sql = "server=localhost;user id=root;password=master;database=carros";
            var sqlConnection = new MySqlConnection(sql);
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
