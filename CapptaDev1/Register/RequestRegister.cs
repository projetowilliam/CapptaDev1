using CapptaDev1.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CapptaDev1.Dados
{
    public class RequestRegister
    {
        public void requestMaker(Request request)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                string sql = @"insert into pedidos (data,clientesFk,veiculoFk,funcionarioFk,valor)
values (@data,@clienteFk,@veiculoFk,@funcionariofk,@valor)";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@data", request.date);
                comand.Parameters.AddWithValue("@clienteFk", request.clientFk);
                comand.Parameters.AddWithValue("@veiculoFk", request.vehiculeFk);
                comand.Parameters.AddWithValue("@funcionariofk", request.employee);
                comand.Parameters.AddWithValue("@valor", request.value);
                comand.ExecuteNonQuery();
            }
        }

        public List<Request> requestList()
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select*from pedidos  ";
                var comand = new MySqlCommand(sql, sqlConnection);
                var dataReader = comand.ExecuteReader();
                List<Request> list = new List<Request>();
                while (dataReader.Read())
                {
                    var requestEntry = new Request();
                    requestEntry.requestCode = dataReader.GetInt32("codigoPedido");
                    requestEntry.date = dataReader.GetString("data");
                    requestEntry.clientFk = dataReader.GetInt32("clientesFk");
                    requestEntry.vehiculeFk = dataReader.GetInt32("veiculoFk");
                    requestEntry.employee = dataReader.GetInt32("funcionarioFk");
                    requestEntry.value = dataReader.GetString("valor");
                    list.Add(requestEntry);
                }
                return list;
            }
        }

        public List<Request> dateRequestList(string date)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select*from pedidos where   (data LIKE '%' @data '%')";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@data", date);
                var dataReader = comand.ExecuteReader();
                List<Request> list = new List<Request>();
                while (dataReader.Read())
                {
                    var requestEntry = new Request();
                    requestEntry.requestCode = dataReader.GetInt32("codigoPedido");
                    requestEntry.date = dataReader.GetString("data");
                    requestEntry.clientFk = dataReader.GetInt32("clientesFk");
                    requestEntry.vehiculeFk = dataReader.GetInt32("veiculoFk");
                    requestEntry.employee = dataReader.GetInt32("funcionarioFk");
                    requestEntry.value = dataReader.GetString("valor");
                    list.Add(requestEntry);
                }
                return list;
            }
        }

        public void updateRequestEntry(string name, int quantity)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "update veiculos set quantidade = @quantidade  where carro=@nome ";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@quantidade", quantity);
                comand.Parameters.AddWithValue("@nome", name);
                comand.ExecuteNonQuery();
            }
        }
    }
}
