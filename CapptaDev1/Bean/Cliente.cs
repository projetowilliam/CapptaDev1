using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public class Cliente :Pessoa
    {
        public override void comprar()
        {

        }

        public override void alterarcadastro()
        {
           
        }

        public override void incluir(Cliente cliente)
        {
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
    }
}
