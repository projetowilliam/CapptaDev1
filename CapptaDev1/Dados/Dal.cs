using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CapptaDev1.Dados
{
    class Dal :ConectaBanco
    {
        
        

        //metodo para adicionar novo carro
        public void adicionarCarro(CarroPopular carro)
        {
            string sql = "insert into carro (carro, modelo, ano,preco) values(@carro,@modelo,@ano,@preco)";
            try
            {
                abrirConexao();
                comand = new MySql.Data.MySqlClient.MySqlCommand(sql,sqlConection);
                comand.Parameters.AddWithValue("@carro",carro);
                comand.Parameters.AddWithValue("@modelo", carro);
                comand.Parameters.AddWithValue("@ano", carro);
                comand.Parameters.AddWithValue("@preco", carro);

                comand.ExecuteNonQuery();
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + "...   Erro ao inserir um novo produto");

            }

        }

        //metodo para alterar carro
        public void alterarCarro(CarroPopular carro)
        {
            try
            {
                abrirConexao();
                comand = new MySql.Data.MySqlClient.MySqlCommand("update carros carro=@carro, modelo=@modelo, ano=@ano, preco =@preco where id = @id",sqlConection);

                comand.Parameters.AddWithValue("@carro",carro.carro);
                comand.Parameters.AddWithValue("@modelo", carro.modelo);
                comand.Parameters.AddWithValue("@ano", carro.ano);
                comand.Parameters.AddWithValue("@preco", carro.preco);

                comand.Parameters.AddWithValue("@id", carro.id);

                comand.ExecuteNonQuery();



            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. Erro ao atualizar");
            }

        }


        //metodo para pesquisar por nome
        public CarroPopular pesquisarPorNome(string nome)
        {
            try
            {
                abrirConexao();
                String sql = "Select*from carro where nome=@nome";
                comand = new MySql.Data.MySqlClient.MySqlCommand(sql, sqlConection);

                comand.Parameters.AddWithValue("@id", nome);
                //Criando um local na memória
                CarroPopular carroPopular = null;
                if (dataReader.Read())
                {
                    carroPopular = new CarroPopular();

                    carroPopular.carro = Convert.ToString(dataReader["nome"]);
                    carroPopular.modelo = Convert.ToString(dataReader["modelo"]);
                    carroPopular.ano = Convert.ToString(dataReader["ano"]);
                    carroPopular.preco = Convert.ToString(dataReader["preco"]);

                }

                return carroPopular;
            }
            catch (Exception mensagem)
            {

                throw new Exception (mensagem + ".. não foi possivel encontrar o produto informado");
            }
        }
    }
}
