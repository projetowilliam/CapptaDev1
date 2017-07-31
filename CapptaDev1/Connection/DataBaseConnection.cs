using MySql.Data.MySqlClient;

namespace CapptaDev1
{
    public static class DataBaseConnection
    {
        public static MySqlConnection open()
        {
            var sql = "server=localhost;user id=root;password=master;database=carros";
            var sqlConnection = new MySqlConnection(sql);
            sqlConnection.Open();

            return sqlConnection;
        }
    }
}
