using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class Vendedor : Pessoa
    {
        //metodo para alterar Pessoa Funcionário
        public override void alterarCadastro(Pessoa cliente)
        {
            try
            {
                //instância de conexão
                ConectaBanco cb = new ConectaBanco();


                cb.abrirConexao();
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand("update funcionario nome=@nome, telefone=@telefone, cpf=@cpf, rua=@rua numero=@numero, cidade=@cidade, estado=@estado  where codigo = @codigo", cb.sqlConection);

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

        

        //metodo para incluir Pessoa Funcionario
        public override void incluir(Pessoa pessoa)
        {
            string sql = "insert into funcionario (nome, telefone, cpf,rua, numero,cidade,estado) values(@nome,@telefone,@cpf,@rua,@numero,@cidade,@estado)";
            try
            {
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, cb.sqlConection);
                cb.comand.Parameters.AddWithValue("@nome", pessoa.nome);
                cb.comand.Parameters.AddWithValue("@telefone", pessoa.telefone);
                cb.comand.Parameters.AddWithValue("@cpf", pessoa.cpf);
                cb.comand.Parameters.AddWithValue("@rua", pessoa.rua);
                cb.comand.Parameters.AddWithValue("@numero", pessoa.numero);
                cb.comand.Parameters.AddWithValue("@cidade", pessoa.cidade);
                cb.comand.Parameters.AddWithValue("@estado", pessoa.estado);

                cb.comand.ExecuteNonQuery();

            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + "...   Erro ao inserir um novo cliente");

            }
        }

        //metodo para listar funcionarios
        public override List<Pessoa> Listar()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select*from funcionario";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (conectaBanco.dataReader.Read())
                {
                    Vendedor vendedor = new Vendedor();

                    vendedor.codigo = Convert.ToInt32(conectaBanco.dataReader["codigo"]);
                    vendedor.nome     = Convert.ToString(conectaBanco.dataReader["nome"]);
                    vendedor.telefone = Convert.ToString(conectaBanco.dataReader["telefone"]);
                    vendedor.cpf      = Convert.ToString(conectaBanco.dataReader["cpf"]);
                    vendedor.rua = Convert.ToString(conectaBanco.dataReader["rua"]);
                    vendedor.numero = Convert.ToString(conectaBanco.dataReader["numero"]);
                    vendedor.cidade= Convert.ToString(conectaBanco.dataReader["cidade"]);
                    vendedor.estado = Convert.ToString(conectaBanco.dataReader["estado"]);

                    lista.Add(vendedor);

                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public override List<Pessoa> ListarPorCodigo(int codigo)
        {
            throw new NotImplementedException();
        }

        public override List<Pessoa> ListarPorNome(string nome)
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                conectaBanco.abrirConexao();
                String sql = "select codigo, nome, telefone, cpf, rua, numero, cidade, estado from funcionario where (nome LIKE '%' @nome '%')";

                conectaBanco.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, conectaBanco.sqlConection);
                conectaBanco.comand.Parameters.AddWithValue("@nome", nome);
                conectaBanco.dataReader = conectaBanco.comand.ExecuteReader();

                List<Pessoa> lista = new List<Pessoa>();

                while (conectaBanco.dataReader.Read())
                {
                    Vendedor cliente = new Vendedor();
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

        //metodo para pesquisar Pessoa Funcionario por Nome
        public Vendedor pesquisarPorNome(string nome)
        {
            try
            {
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                String sql = "Select*from funcionario where nome=@nome";
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, cb.sqlConection);

                cb.comand.Parameters.AddWithValue("@nome", nome);
                //Criando um local na memória
                Vendedor cliente = null;
                if (cb.dataReader.Read())
                {
                    cliente = new Vendedor();

                    cliente.nome = Convert.ToString(cb.dataReader["nome"]);
                    cliente.telefone = Convert.ToString(cb.dataReader["telefone"]);
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
    }
}
