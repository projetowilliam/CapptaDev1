
using SinalVeiculos.Models.CapptaDev1.Modelos;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SinalVeiculos.Dados.Pessoas
{
    public abstract class PersonRegister<PersonType> where PersonType : IPerson, new()
    {
        public abstract string TableName { get; }

        public void Add(PersonType person)
        {
            var dataBaseConectionOpen = DataBaseConnection.Open();
            var insertQuery = @"insert into " + TableName + " (nome, telefone, cpf,rua, numero,cidade,estado)" +
                " values(@nome,@telefone,@cpf,@rua,@numero,@cidade,@estado)";
            var mysqlComand = new MySqlCommand(insertQuery, dataBaseConectionOpen);
            mysqlComand.Parameters.AddWithValue("@nome", person.Name);
            mysqlComand.Parameters.AddWithValue("@telefone", person.Phone);
            mysqlComand.Parameters.AddWithValue("@cpf", person.Cpf);
            mysqlComand.Parameters.AddWithValue("@rua", person.Street);
            mysqlComand.Parameters.AddWithValue("@numero", person.Number);
            mysqlComand.Parameters.AddWithValue("@cidade", person.City);
            mysqlComand.Parameters.AddWithValue("@estado", person.State);
            mysqlComand.ExecuteNonQuery();
        }

        public void Delete(int identifier)
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var deleteQuery = @"delete from  " + TableName + "  where id = @codigo";
                var mysqlComand = new MySqlCommand(deleteQuery, dataBaseConectionOpen);
                mysqlComand.Parameters.AddWithValue("@codigo", identifier);
                mysqlComand.ExecuteNonQuery();
            }
        }

        public IEnumerable<PersonType> GetAll()
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var selectQuery = "select*from " + TableName;
                var mysqlComand = new MySqlCommand(selectQuery, dataBaseConectionOpen);
                var executeReader = mysqlComand.ExecuteReader();

                while (executeReader.Read())
                {
                    var person = new PersonType()
                    {
                        Id = executeReader.GetInt32("codigo"),
                        Name = executeReader.GetString("nome"),
                        Phone = executeReader.GetString("telefone"),
                        Cpf = executeReader.GetString("cpf"),
                        Street = executeReader.GetString("rua"),
                        Number = executeReader.GetInt32("numero"),
                        City = executeReader.GetString("cidade"),
                        State = executeReader.GetString("estado")
                    };
                    yield return person;
                }
            }
        }

        public PersonType SearchPersonByName(string name)
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var selectQuery = @"select * from " + TableName + " where nome=@nome";
                var mysqlComand = new MySqlCommand(selectQuery, dataBaseConectionOpen);
                mysqlComand.Parameters.AddWithValue("@nome", name);
                var executeReader = mysqlComand.ExecuteReader();
                var person = new PersonType();
                if (executeReader.Read())
                {
                    person.Name = executeReader.GetString("nome");
                    person.Phone = executeReader.GetString("telefone");
                    person.Cpf = executeReader.GetString("cpf");
                    person.Street = executeReader.GetString("rua");
                    person.Number = executeReader.GetInt32("numero");
                    person.City = executeReader.GetString("cidade");
                    person.State = executeReader.GetString("estado");
                }
                return person;
            }
        }
    }
}
