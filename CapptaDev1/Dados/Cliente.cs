using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class Cliente :Pessoa
    {
        
        //construtor
        public  void comprar()
        {
           
            

        }

        
        //metodo para incluir cliente no banco
        public override void incluir(Pessoa cliente)
        {
        // = new Cliente();
            string sql = "insert into clientes (nome, telefone, cpf,rua, numero,cidade,estado) values(@nome,@telefone,@cpf,@rua,@numero,@cidade,@estado)";
            try
            {
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, cb.sqlConection);
                cb.comand.Parameters.AddWithValue("@nome", cliente.nome);
                cb.comand.Parameters.AddWithValue("@telefone", cliente.telefone);
                cb. comand.Parameters.AddWithValue("@cpf", cliente.cpf);
                cb.comand.Parameters.AddWithValue("@rua", cliente.rua);
                cb.comand.Parameters.AddWithValue("@numero", cliente.numero);
                cb.comand.Parameters.AddWithValue("@cidade", cliente.cidade);
                cb.comand.Parameters.AddWithValue("@estado", cliente.estado);

               cb.comand.ExecuteNonQuery();
                
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + "...   Erro ao inserir um novo cliente");

            }

        }
        //metodo para alterar o cadastro do cliente
        public override  void alterarCadastro(Pessoa cliente)
        {
            try
            {
               
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand("update clientes nome=@nome, telefone=@telefone, cpf=@cpf, rua=@rua numero=@numero, cidade=@cidade, estado=@estado  where codigo = @codigo", cb.sqlConection);

                cb.comand.Parameters.AddWithValue("@nome", cliente.nome);
                cb.comand.Parameters.AddWithValue("@telefone", cliente.telefone);
                cb.comand.Parameters.AddWithValue("@cpf", cliente.cpf);
                cb.comand.Parameters.AddWithValue("@rua", cliente.rua);
                cb.comand.Parameters.AddWithValue("@numero", cliente.numero);
                cb.comand.Parameters.AddWithValue("@cidade", cliente.cidade);
                cb.comand.Parameters.AddWithValue("@estado", cliente.estado);

                cb.comand.Parameters.AddWithValue("@codigo", cliente.codigo);

                cb.comand.ExecuteNonQuery();



            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. Erro ao atualizar");
            }

        }

        //metodo para pesquisar por nome
        public  Cliente pesquisarPorNome(string nome)
        {
            try
            {
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                String sql = "select nome, telefone, cpf, rua, numero, cidade, estado from clientes where nome=@nome";
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, cb.sqlConection);

                cb.comand.Parameters.AddWithValue("@nome", nome);
                cb.dataReader = cb.comand.ExecuteReader();
                //Criando um local na memória
                Cliente cliente = null;
                if (cb.dataReader.Read())
                {
                    cliente = new Cliente();

                    cliente.nome = Convert.ToString(cb.dataReader["nome"]);
                    cliente.telefone = Convert.ToString(cb.dataReader["telefone"]);
                    cliente.cpf = Convert.ToString(cb.dataReader["cpf"]);
                    cliente.rua = Convert.ToString(cb.dataReader["rua"]);
                    cliente.numero = Convert.ToString(cb.dataReader["numero"]);
                    cliente.cidade = Convert.ToString(cb.dataReader["cidade"]);
                    cliente.estado = Convert.ToString(cb.dataReader["estado"]);



                }

                return cliente;
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. não foi possivel encontrar o produto informado");
            }
        }

        // metodo para listar sem filtro
        public override List<Pessoa> Listar()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select*from clientes";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (conectaBanco.dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.codigo = Convert.ToInt32(conectaBanco.dataReader["codigo"]);
                    cliente.nome = Convert.ToString(conectaBanco.dataReader["nome"]);
                    cliente.telefone = Convert.ToString(conectaBanco.dataReader["telefone"]);
                    cliente.cpf = Convert.ToString(conectaBanco.dataReader["cpf"]);
                    cliente.rua = Convert.ToString(conectaBanco.dataReader["rua"]);
                    cliente.numero = Convert.ToString(conectaBanco.dataReader["numero"]);
                    cliente.cidade = Convert.ToString(conectaBanco.dataReader["cidade"]);
                    cliente.estado = Convert.ToString(conectaBanco.dataReader["estado"]);

                    lista.Add(cliente);

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }
        // metodo para listar por nome
        public override List<Pessoa> ListarPorNome(string nome)
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select codigo, nome, telefone, cpf, rua, numero, cidade, estado from clientes where  (nome LIKE '%' @nome '%')";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
               
                conectaBanco.comand.Parameters.AddWithValue("@nome", nome);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (conectaBanco.dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.codigo = Convert.ToInt32(conectaBanco.dataReader["codigo"]);
                    cliente.nome = Convert.ToString(conectaBanco.dataReader["nome"]);
                    cliente.telefone = Convert.ToString(conectaBanco.dataReader["telefone"]);
                    cliente.cpf = Convert.ToString(conectaBanco.dataReader["cpf"]);
                    cliente.rua = Convert.ToString(conectaBanco.dataReader["rua"]);
                    cliente.numero = Convert.ToString(conectaBanco.dataReader["numero"]);
                    cliente.cidade = Convert.ToString(conectaBanco.dataReader["cidade"]);
                    cliente.estado = Convert.ToString(conectaBanco.dataReader["estado"]);

                    lista.Add(cliente);

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }

        }
        // metodo para listar por código
        public override List<Pessoa> ListarPorCodigo(int codigo)
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select nome, telefone, cpf, rua, numero, cidade, estado from clientes where codigo=@codigo";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.comand.Parameters.AddWithValue("@codigo", codigo);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (conectaBanco.dataReader.Read())
                {
                    Cliente cliente = new Cliente();
                    cliente.nome = Convert.ToString(conectaBanco.dataReader["nome"]);
                    cliente.telefone = Convert.ToString(conectaBanco.dataReader["telefone"]);
                    cliente.cpf = Convert.ToString(conectaBanco.dataReader["cpf"]);
                    cliente.rua = Convert.ToString(conectaBanco.dataReader["rua"]);
                    cliente.numero = Convert.ToString(conectaBanco.dataReader["numero"]);
                    cliente.cidade = Convert.ToString(conectaBanco.dataReader["cidade"]);
                    cliente.estado = Convert.ToString(conectaBanco.dataReader["estado"]);

                    lista.Add(cliente);

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
