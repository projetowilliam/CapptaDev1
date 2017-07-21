using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapptaDev1
{
     public class ConectaBanco
    {
        public MySqlConnection sqlConection { get; set; }
        public MySqlCommand comand { get; set; }
        public MySqlDataReader dataReader { get; set; }
        public MySqlDataAdapter dataAdapter { get; set; }


        public void abrirConexao()
        {
            try
            {


                string sql = "server=localhost;user id=root;password=master;database=carros";
                sqlConection = new MySqlConnection(sql);

                sqlConection.Open();
            }
            catch (Exception mensagem)
            {

             throw new Exception(mensagem +"..Não foi possivel conectar com o banco de dados");
            }
           
        }

        public void fecharConexao()
        {
            
            sqlConection.Close();
        }
    }
}
