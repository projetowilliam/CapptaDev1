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
                mysqlcomand.Parameters.AddWithValue("@valor", request.Value);
                mysqlcomand.Parameters.AddWithValue("@responsavelPelaVenda", request.ResponsibleForSale);
                mysqlcomand.Parameters.AddWithValue("@produto", request.Product);
                mysqlcomand.Parameters.AddWithValue("@quantidade", request.Quantity);
                mysqlcomand.Parameters.AddWithValue("@cliente", request.Client);
                mysqlcomand.Parameters.AddWithValue("@cpfCliente", request.CpfClient);
                mysqlcomand.Parameters.AddWithValue("@dataVenda", request.Date);

                mysqlcomand.ExecuteNonQuery();
            }
        }

        public IEnumerable<Request> GetAll()
        {
            using (var dataBaseConnectionOpen = DataBaseConnection.Open())
            {
                var selectQuery = "select*from pedidos  ";
                var mysqlComand = new MySqlCommand(selectQuery, dataBaseConnectionOpen);
                var executeReader = mysqlComand.ExecuteReader();
                while (executeReader.Read())
                {
                    var request = new Request()
                    {
                        Id = executeReader.GetInt32("codigoPedido"),
                        Value = executeReader.GetInt32("valor"),
                        ResponsibleForSale = executeReader.GetString("responsavelPelaVenda"),
                        Product = executeReader.GetString("produto"),
                        Quantity = executeReader.GetInt32("quantidade"),
                        Client = executeReader.GetString("cliente"),
                        CpfClient = executeReader.GetString("cpfCliente"),
                        Date = executeReader.GetString("dataVenda")
                    };
                    yield return request;
                }
            }
        }

        public void UpdateVehiculeQauntity(int quantity, int id)
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
