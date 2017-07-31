
using CapptaDev1.Models.CapptaDev1.Modelos;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CapptaDev1.Dados.Pessoas
{
    public abstract class PersonRegister<personType> where personType : Person, new()
    {
        public abstract string tblPerson { get; }

        public void personAdd(personType person)
        {
            var sqlConnection = DataBaseConnection.open();
            var sql = @"insert into " + tblPerson + " (nome, telefone, cpf,rua, numero,cidade,estado)" +
                " values(@nome,@telefone,@cpf,@rua,@numero,@cidade,@estado)";
            var comand = new MySqlCommand(sql, sqlConnection);
            comand.Parameters.AddWithValue("@nome", person.name);
            comand.Parameters.AddWithValue("@telefone", person.phone);
            comand.Parameters.AddWithValue("@cpf", person.cpf);
            comand.Parameters.AddWithValue("@rua", person.street);
            comand.Parameters.AddWithValue("@numero", person.number);
            comand.Parameters.AddWithValue("@cidade", person.city);
            comand.Parameters.AddWithValue("@estado", person.state);
            comand.ExecuteNonQuery();
        }

        public void personRegisterAlter(personType person)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "update" + tblPerson + " nome=@nome, telefone=@telefone, cpf=@cpf, rua=@rua numero=@numero, cidade=@cidade, estado=@estado  where codigo = @codigo";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@nome", person.name);
                comand.Parameters.AddWithValue("@telefone", person.phone);
                comand.Parameters.AddWithValue("@cpf", person.cpf);
                comand.Parameters.AddWithValue("@rua", person.street);
                comand.Parameters.AddWithValue("@numero", person.number);
                comand.Parameters.AddWithValue("@cidade", person.city);
                comand.Parameters.AddWithValue("@estado", person.state);
                comand.Parameters.AddWithValue("@codigo", person.code);
                comand.ExecuteNonQuery();
            }
        }

        public List<personType> dateSearch(string salesDate)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select nome, cpf, telefone, rua, numero, cidade, estado  from 
" + tblPerson + " inner join pedidos   on codigo = clientesFk where  data like'" + salesDate + "%'";
                var comand = new MySqlCommand(sql, sqlConnection);
                var dataReader = comand.ExecuteReader();
                var list = new List<personType>();
                while (dataReader.Read())
                {
                    var person = new personType();
                    person.name = dataReader.GetString("nome");
                    person.phone = dataReader.GetString("telefone");
                    person.cpf = dataReader.GetString("cpf");
                    person.street = dataReader.GetString("rua");
                    person.number = dataReader.GetString("numero");
                    person.city = dataReader.GetString("cidade");
                    person.state = dataReader.GetString("estado");
                    list.Add(person);
                }
                return list;
            }
        }

        public List<personType> personList()
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select*from " + tblPerson;
                var comand = new MySqlCommand(sql, sqlConnection);
                var dataReader = comand.ExecuteReader();
                var list = new List<personType>();
                while (dataReader.Read())
                {
                    var person = new personType();
                    person.code = dataReader.GetInt32("codigo");
                    person.name = dataReader.GetString("nome");
                    person.phone = dataReader.GetString("telefone");
                    person.cpf = dataReader.GetString("cpf");
                    person.street = dataReader.GetString("rua");
                    person.number = dataReader.GetString("numero");
                    person.city = dataReader.GetString("cidade");
                    person.state = dataReader.GetString("estado");
                    list.Add(person);
                }
                return list;
            }
        }

        public List<personType> nameListPerson(string name)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select codigo, nome, telefone, cpf, rua, numero, cidade, 
estado from " + tblPerson + " where  (nome LIKE '%' @nome '%')";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@nome", name);
                var dataReader = comand.ExecuteReader();
                var list = new List<personType>();
                while (dataReader.Read())
                {
                    var person = new personType();
                    person.code = dataReader.GetInt32("codigo");
                    person.name = dataReader.GetString("nome");
                    person.phone = dataReader.GetString("telefone");
                    person.cpf = dataReader.GetString("cpf");
                    person.street = dataReader.GetString("rua");
                    person.number = dataReader.GetString("numero");
                    person.city = dataReader.GetString("cidade");
                    person.state = dataReader.GetString("estado");
                    list.Add(person);
                }
                return list;
            }
        }

        public personType codeSearchPeople(int id)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select nome, telefone, cpf, rua, numero, cidade,
estado from " + tblPerson + " where id=@id";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@id", id);
                var dataReader = comand.ExecuteReader();
                if (dataReader.Read())
                {
                    var person = new personType();
                    person.name = dataReader.GetString("nome");
                    person.phone = dataReader.GetString("telefone");
                    person.cpf = dataReader.GetString("cpf");
                    person.street = dataReader.GetString("rua");
                    person.number = dataReader.GetString("numero");
                    person.city = dataReader.GetString("cidade");
                    person.state = dataReader.GetString("estado");
                    return person;
                }
                return null;
            }
        }

        public personType nameSearchPeople(string name)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select nome, telefone, cpf, rua, numero, cidade, estado
from " + tblPerson + " where nome=@nome";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@nome", name);
                var dataReader = comand.ExecuteReader();
                if (dataReader.Read())
                {
                    var person = new personType();
                    person.name = dataReader.GetString("nome");
                    person.phone = dataReader.GetString("telefone");
                    person.cpf = dataReader.GetString("cpf");
                    person.street = dataReader.GetString("rua");
                    person.number = dataReader.GetString("numero");
                    person.city = dataReader.GetString("cidade");
                    person.state = dataReader.GetString("estado");
                    return person;
                }
                return null;
            }
        }
    }
}
