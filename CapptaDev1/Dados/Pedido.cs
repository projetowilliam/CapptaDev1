using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class Pedido
    {
        public int codigoPedido { get; set; }
        public string data { get; set; }
        public int clientesFk { get; set; }
        public int carroPopularFk { get; set; }
        public int funcionarioFk { get; set; }
        public string valor { get; set; }

        public Pedido()
        {

        }
        //metodo para fazer pedido
        public void fazerpedido( Pedido pedido)
        {
            try
            {

                ConectaBanco conecta = new ConectaBanco();
                conecta.abrirConexao();
                //string sql = "";
                string sql = "insert into pedidos (data,clientesFk,carroPopularFk,funcionarioFk,valor) values(@data,@clienteFk,@carroPopularFk,@funcionariofk,@valor)";
                conecta.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conecta.sqlConection);

                conecta.comand.Parameters.AddWithValue("@data", pedido.data);
                conecta.comand.Parameters.AddWithValue("@clienteFk", pedido.clientesFk);
                conecta.comand.Parameters.AddWithValue("@carroPopularFk", pedido.carroPopularFk);
                conecta.comand.Parameters.AddWithValue("@funcionariofk", pedido.funcionarioFk);
                conecta.comand.Parameters.AddWithValue("@valor", pedido.valor);

                conecta.comand.ExecuteNonQuery();

                

            }
            catch (Exception)
            {

                throw;
            }

        }

        //metodo para listar pedido 
        public List<Pedido> listar()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select*from pedidos ";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pedido> lista = new List<Pedido>();

                while (conectaBanco.dataReader.Read())
                {
                    Pedido pedido = new Pedido();
                    pedido.codigoPedido = Convert.ToInt32(conectaBanco.dataReader["codigoPedido"]);
                    pedido.data = Convert.ToString(conectaBanco.dataReader["data"]);
                    pedido.clientesFk = Convert.ToInt32(conectaBanco.dataReader["clientesFk"]);
                    pedido.carroPopularFk = Convert.ToInt32(conectaBanco.dataReader["carropopularFk"]);
                    pedido.funcionarioFk = Convert.ToInt32(conectaBanco.dataReader["funcionarioFk"]);
                    pedido.valor = Convert.ToString(conectaBanco.dataReader["valor"]);
                   

                    lista.Add(pedido);

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
