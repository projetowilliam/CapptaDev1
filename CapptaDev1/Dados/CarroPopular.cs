using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class CarroPopular:Carro
    {
        //abri conexão
        ConectaBanco conectaBanco = new ConectaBanco();

        //ABSTRACT


        //metodo para adicionar novo carro
        public  override void  adicionarCarro(Carro carro)
        {
            string sql = "insert into carroPopular (carro, modelo, ano,preco, marca, quantidade) values(@carro,@modelo,@ano,@preco,@marca, @quantidade)";
            try
            {
                conectaBanco.abrirConexao();
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.comand.Parameters.AddWithValue("@carro", carro.carro);
                conectaBanco.comand.Parameters.AddWithValue("@modelo", carro.modelo);
                conectaBanco.comand.Parameters.AddWithValue("@ano", carro.ano);
                conectaBanco.comand.Parameters.AddWithValue("@preco", carro.preco);
                conectaBanco.comand.Parameters.AddWithValue("@marca", carro.marca);
                conectaBanco.comand.Parameters.AddWithValue("@quantidade", carro.quantidade);

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
                    conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand("update carroPopular set carro=@carro, modelo=@modelo, ano=@ano, preco =@preco, marca= @marca, quantidade=@quantidade where id = @id", conectaBanco.sqlConection);

                    conectaBanco.comand.Parameters.AddWithValue("@carro", carro.carro);
                    conectaBanco.comand.Parameters.AddWithValue("@modelo", carro.modelo);
                    conectaBanco.comand.Parameters.AddWithValue("@ano", carro.ano);
                    conectaBanco.comand.Parameters.AddWithValue("@preco", carro.preco);
                    conectaBanco.comand.Parameters.AddWithValue("@marca", carro.marca);
                    conectaBanco.comand.Parameters.AddWithValue("@quantidade", carro.quantidade);

                conectaBanco.comand.Parameters.AddWithValue("@id", carro.id);

                 conectaBanco.comand.ExecuteNonQuery();



                }
                catch (Exception mensagem)
                {

                    throw new Exception(mensagem + ".. Erro ao atualizar");
                }

            
        }

        //metodo para listar carro
        public override List<Carro> listarCarro()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select*from carropopular";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Carro> lista = new List<Carro>();

                while (conectaBanco.dataReader.Read())
                {
                    CarroPopular carro = new CarroPopular();
                    carro.id = Convert.ToInt32(conectaBanco.dataReader["id"]);
                    carro.carro = Convert.ToString(conectaBanco.dataReader["carro"]);
                    carro.modelo = Convert.ToString(conectaBanco.dataReader["modelo"]);
                    carro.ano = Convert.ToString(conectaBanco.dataReader["ano"]);
                    carro.preco = Convert.ToString(conectaBanco.dataReader["preco"]);
                    carro.marca = Convert.ToString(conectaBanco.dataReader["marca"]);
                    carro.quantidade = Convert.ToString(conectaBanco.dataReader["quantidade"]);


                    lista.Add(carro);
                    

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }


        // metodo para listar carro por nome
        public override List<Carro> ListarCarroPorNome(string nome)
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select id, carro, modelo, ano, preco, marca,quantidade from carropopular where (carro LIKE '%' @carro '%')";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.comand.Parameters.AddWithValue("@carro", nome);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Carro> lista = new List<Carro>();

                //Criando um local na memória
                // carroPopular = null;
                while (conectaBanco.dataReader.Read())
                {
                    CarroPopular carroPopular = new CarroPopular();

                    carroPopular.id = Convert.ToInt32(conectaBanco.dataReader["id"]);
                    carroPopular.carro = Convert.ToString(conectaBanco.dataReader["carro"]);
                    carroPopular.modelo = Convert.ToString(conectaBanco.dataReader["modelo"]);
                    carroPopular.ano = Convert.ToString(conectaBanco.dataReader["ano"]);
                    carroPopular.preco = Convert.ToString(conectaBanco.dataReader["preco"]);
                    carroPopular.marca = Convert.ToString(conectaBanco.dataReader["marca"]);
                    carroPopular.quantidade = Convert.ToString(conectaBanco.dataReader["quantidade"]);

                    lista.Add(carroPopular);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }


        //metodo para pesquisar por nome
        public override CarroPopular pesquisarPorNome(string nome)
        {
            try
            {
                conectaBanco.abrirConexao();
                String sql = "select id, carro, modelo, ano, preco, marca, quantidade from carropopular where carro = @carro";
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);

                conectaBanco.comand.Parameters.AddWithValue("@carro", nome);

                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                //Criando um local na memória
                CarroPopular carroPopular = null;
                if (conectaBanco.dataReader.Read())
                {
                    carroPopular = new CarroPopular();

                    carroPopular.id = Convert.ToInt32(conectaBanco.dataReader["id"]);
                    carroPopular.carro = Convert.ToString(conectaBanco.dataReader["carro"]);
                    carroPopular.modelo = Convert.ToString(conectaBanco.dataReader["modelo"]);
                    carroPopular.ano = Convert.ToString(conectaBanco.dataReader["ano"]);
                    carroPopular.preco = Convert.ToString(conectaBanco.dataReader["preco"]);
                    carroPopular.marca = Convert.ToString(conectaBanco.dataReader["marca"]);
                    carroPopular.quantidade = Convert.ToString(conectaBanco.dataReader["quantidade"]);

                }

                return carroPopular;
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. não foi possivel encontrar o produto informado");
            }
        }


        //metodo para pesquisar por nome e retornar a quantidade
        public override CarroPopular pesquisarPorNomeQuantidade(string nome)
        {
            try
            {
                conectaBanco.abrirConexao();
                String sql = "select  quantidade from carropopular where carro = @carro";
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);

                conectaBanco.comand.Parameters.AddWithValue("@carro", nome);

                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                //Criando um local na memória
                CarroPopular carroPopular = null;
                if (conectaBanco.dataReader.Read())
                {
                    carroPopular = new CarroPopular();


                    carroPopular.quantidade = Convert.ToString(conectaBanco.dataReader["quantidade"]);

                }

                return carroPopular;
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. não foi possivel encontrar o produto informado");
            }
        }

        //------------------------------------------------------------------
        // NÃO ABSTRATO





        //metodo para pesquisar por código
        public  CarroPopular pesquisarCarroPorCodigo(int codigo)
        {
            try
            {
                conectaBanco.abrirConexao();
                String sql = "select id, carro, modelo, ano, preco, marca,quantidade from carropopular where id = @id";
                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);

                conectaBanco.comand.Parameters.AddWithValue("@id", codigo);

                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                //Criando um local na memória
                CarroPopular carroPopular = null;
                if (conectaBanco.dataReader.Read())
                {
                    carroPopular = new CarroPopular();

                    carroPopular.id = Convert.ToInt32(conectaBanco.dataReader["id"]);
                    carroPopular.carro = Convert.ToString(conectaBanco.dataReader["carro"]);
                    carroPopular.modelo = Convert.ToString(conectaBanco.dataReader["modelo"]);
                    carroPopular.ano = Convert.ToString(conectaBanco.dataReader["ano"]);
                    carroPopular.preco = Convert.ToString(conectaBanco.dataReader["preco"]);
                    carroPopular.marca = Convert.ToString(conectaBanco.dataReader["marca"]);
                    carroPopular.quantidade = Convert.ToString(conectaBanco.dataReader["quantidade"]);

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
