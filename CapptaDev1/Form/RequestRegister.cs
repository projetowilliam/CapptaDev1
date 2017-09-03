using SinalVeiculos.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SinalVeiculos.Dados
{
    public class RequestRegister
    {
        public void Add(Request request)
        {
            using (var sqlConnection = DataBaseConnection.Open())
            {
                string insertQuery = @"insert into pedidos (valor,responsavelPelaVenda,produto,quantidade,cliente, cpfCliente,dataVenda)
                        values (@valor,@responsavelPelaVenda,@produto,@quantidade,@cliente, @cpfCliente,@dataVenda)";
                var mysqlcomand = new MySqlCommand(insertQuery, sqlConnection);
                mysqlcomand.Parameters.AddWithValue("@valor", request.value);
                mysqlcomand.Parameters.AddWithValue("@responsavelPelaVenda", request.responsibleForSale);
                mysqlcomand.Parameters.AddWithValue("@produto", request.product);
                mysqlcomand.Parameters.AddWithValue("@quantidade", request.quantity);
                mysqlcomand.Parameters.AddWithValue("@cliente", request.client);
                mysqlcomand.Parameters.AddWithValue("@cpfCliente", request.cpfClient);
                mysqlcomand.Parameters.AddWithValue("@dataVenda", request.date);

                mysqlcomand.ExecuteNonQuery();
            }
        }

        public IEnumerable<Request> GetAll()
        {
            using (var sqlConnection = DataBaseConnection.Open())
            {
                var sql = "select*from pedidos  ";
                var mysqlComand = new MySqlCommand(sql, sqlConnection);
                var executeReader = mysqlComand.ExecuteReader();
                while (executeReader.Read())
                {
                    var request = new Request()
                    {
                        requestCode = executeReader.GetInt32("codigoPedido"),
                        value = executeReader.GetInt32("valorVenda"),
                        responsibleForSale = executeReader.GetString("responsavelPelaVenda"),
                        product = executeReader.GetString("produto"),
                        quantity = executeReader.GetInt32("quantidade"),
                        client = executeReader.GetString("cliente"),
                        cpfClient = executeReader.GetString("cpfCliente")              
                    };
                    yield return request;
                }
            }
        }

        public void UpdateQauntity(int quantity, int id)
        {
            using (var sqlConnection = DataBaseConnection.Open())
            {
                var updateQuery = "update carros set quantidade = @quantidade  where id=@identificador ";
                var mysqlComand = new MySqlCommand(updateQuery, sqlConnection);
                mysqlComand.Parameters.AddWithValue("@quantidade",quantity);
                mysqlComand.Parameters.AddWithValue("@identificador", id);
                mysqlComand.ExecuteNonQuery();
            }
        }
    }
}
