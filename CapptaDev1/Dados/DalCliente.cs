using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1.Dados
{
    public class DalCliente: ConectaBanco
    {

        //metodo para adicionar novo cliente
        public void adicionarCliente(Cliente cliente)
        {
            string sql = "insert into cliente (nome, telefone, cpf,rua, numero,cidade,estado) values(@nome,@telefone,@cpf,@rua,@numero,@cidade,@estado)";
            try
            {
          
                abrirConexao();
                comand = new MySql.Data.MySqlClient.MySqlCommand(sql, sqlConection);
                comand.Parameters.AddWithValue("@nome", cliente.nome);
                comand.Parameters.AddWithValue("@telefone", cliente.telefone);
                comand.Parameters.AddWithValue("@cpf", cliente.cpf);
                comand.Parameters.AddWithValue("@rua", cliente.rua);
                comand.Parameters.AddWithValue("@numero", cliente.numero);
                comand.Parameters.AddWithValue("@cidade", cliente.cidade);
                comand.Parameters.AddWithValue("@estado", cliente.estado);

                comand.ExecuteNonQuery();
            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + "...   Erro ao inserir um novo cliente");

            }

        }

        //metodo para alterar Cliente
        public void alterarCliente(Cliente cliente)
        {
            try
            {
                abrirConexao();
                comand = new MySql.Data.MySqlClient.MySqlCommand("update clientes nome=@nome, telefone=@telefone, cpf=@cpf, rua=@rua numero=@numero, cidade=@cidade, estado=@estado  where codigo = @codigo", sqlConection);

                comand.Parameters.AddWithValue("@nome", cliente.nome);
                comand.Parameters.AddWithValue("@telefone", cliente.telefone);
                comand.Parameters.AddWithValue("@cpf", cliente.cpf);
                comand.Parameters.AddWithValue("@rua", cliente.rua);
                comand.Parameters.AddWithValue("@numero", cliente.numero);
                comand.Parameters.AddWithValue("@cidade", cliente.cidade);
                comand.Parameters.AddWithValue("@estado", cliente.estado);

                comand.Parameters.AddWithValue("@codigo", cliente.codigo);

                comand.ExecuteNonQuery();



            }
            catch (Exception mensagem)
            {

                throw new Exception(mensagem + ".. Erro ao atualizar");
            }

        }


        //metodo para pesquisar por nome
        public Cliente pesquisarPorNome(string nome)
        {
            try
            {
                abrirConexao();
                String sql = "Select*from clientes where nome=@nome";
                comand = new MySql.Data.MySqlClient.MySqlCommand(sql, sqlConection);

                comand.Parameters.AddWithValue("@nome", nome);
                //Criando um local na memória
                Cliente cliente = null;
                if (dataReader.Read())
                {
                    cliente = new Cliente();

                    cliente.nome = Convert.ToString(dataReader["nome"]);
                    cliente.telefone = Convert.ToString(dataReader["telefone"]);
                    cliente.rua = Convert.ToString(dataReader["rua"]);
                    cliente.numero = Convert.ToString(dataReader["numero"]);
                    cliente.cidade = Convert.ToString(dataReader["cidade"]);
                    cliente.estado = Convert.ToString(dataReader["estado"]);



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
