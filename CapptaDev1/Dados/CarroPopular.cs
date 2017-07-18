using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class CarroPopular:Carro
    {

        ConectaBanco conectaBanco = new ConectaBanco();
        //metodo para adicionar novo carro
        public  override void  adicionarCarro(Carro carro)
        {
            string sql = "insert into carroPopular (carro, modelo, ano,preco) values(@carro,@modelo,@ano,@preco)";
            try
            {
                conectaBanco.abrirConexao();
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.comand.Parameters.AddWithValue("@carro", carro.carro);
                conectaBanco.comand.Parameters.AddWithValue("@modelo", carro.modelo);
                conectaBanco.comand.Parameters.AddWithValue("@ano", carro.ano);
                conectaBanco.comand.Parameters.AddWithValue("@preco", carro.preco);

                conectaBanco.comand.ExecuteNonQuery();
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + "...   Erro ao inserir um novo produto");

            }

        }

        //metodo para alterar carro
        public override void alterarCarro(Carro carro)
        {
           
           
                try
                {
                    conectaBanco.abrirConexao();
                    conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand("update carroPopular carro=@carro, modelo=@modelo, ano=@ano, preco =@preco where id = @id", conectaBanco.sqlConection);

                    conectaBanco.comand.Parameters.AddWithValue("@carro", carro.carro);
                    conectaBanco.comand.Parameters.AddWithValue("@modelo", carro.modelo);
                    conectaBanco.comand.Parameters.AddWithValue("@ano", carro.ano);
                    conectaBanco.comand.Parameters.AddWithValue("@preco", carro.preco);

                    conectaBanco.comand.Parameters.AddWithValue("@id", carro.id);

                 conectaBanco.comand.ExecuteNonQuery();



                }
                catch (Exception mensagem)
                {

                    throw new Exception(mensagem + ".. Erro ao atualizar");
                }

            
        }

        //metodo para pesquisar por nome
        public override Carro pesquisarPorNome(string nome)
        {
            try
            {
                conectaBanco.abrirConexao();
                String sql = "Select*from carroPopular where nome=@nome";
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);

                conectaBanco.comand.Parameters.AddWithValue("@id", nome);
                //Criando um local na memória
                CarroPopular carroPopular = null;
                if (conectaBanco.dataReader.Read())
                {
                    carroPopular = new CarroPopular();

                    carroPopular.carro = Convert.ToString(conectaBanco.dataReader["nome"]);
                    carroPopular.modelo = Convert.ToString(conectaBanco.dataReader["modelo"]);
                    carroPopular.ano = Convert.ToString(conectaBanco.dataReader["ano"]);
                    carroPopular.preco = Convert.ToString(conectaBanco.dataReader["preco"]);

                }

                return carroPopular;
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. não foi possivel encontrar o produto informado");
            }
        }
    }
}
