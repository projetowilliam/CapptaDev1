using CapptaDev1.Modelos;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace CapptaDev1.Register
{
    public abstract class CarRegister<vehiculeType> where vehiculeType : Vehicules, new()
    {
        public abstract string quantity { get; set; }
        public abstract string tblVehicule { get;}

        public void vehiculeAdd(vehiculeType vehicles)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"insert into " + tblVehicule + "veiculos (carro, modelo, ano,preco, marca, quantidade)" +
"values(@carro,@modelo,@ano,@preco,@marca, @quantidade,@tipo)";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@carro", vehicles.name);
                comand.Parameters.AddWithValue("@modelo", vehicles.model);
                comand.Parameters.AddWithValue("@ano", vehicles.year);
                comand.Parameters.AddWithValue("@preco", vehicles.price);
                comand.Parameters.AddWithValue("@marca", vehicles.mark);
                comand.Parameters.AddWithValue("@quantidade", quantity);
                comand.ExecuteNonQuery();
            }
        }

        public void vehiculeChange(vehiculeType vehicles)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"update " + tblVehicule + " set carro=@veiculo, modelo=@modelo, ano=@ano," +
"preco =@preco, marca= @marca, quantidade=@quantidade where id = @id";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@veiculo", vehicles.name);
                comand.Parameters.AddWithValue("@modelo", vehicles.model);
                comand.Parameters.AddWithValue("@ano", vehicles.year);
                comand.Parameters.AddWithValue("@preco", vehicles.price);
                comand.Parameters.AddWithValue("@marca", vehicles.mark);
                comand.Parameters.AddWithValue("@quantidade", quantity);
                comand.Parameters.AddWithValue("@id", vehicles.id);
                comand.ExecuteNonQuery();
            }
        }

        public List<vehiculeType> dateVehiculeList(string date)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select id,carro, ano,preco,marca, modelo,tipo from " + tblVehicule + " inner " +
                    "join pedidos on id = veiculoFk where  data like'" + date + "%'";
                var comand = new MySqlCommand(sql, sqlConnection);
                var dataReader = comand.ExecuteReader();
                var list = new List<vehiculeType>();
                while (dataReader.Read())
                {
                    var vehicules = new vehiculeType();
                    vehicules.id = dataReader.GetInt32("id");
                    vehicules.name = dataReader.GetString("carro");
                    vehicules.model = dataReader.GetString("modelo");
                    vehicules.year = dataReader.GetString("ano");
                    vehicules.price = dataReader.GetString("preco");
                    vehicules.mark = dataReader.GetString("marca");
                    quantity = dataReader.GetString("quantidade");
                    list.Add(vehicules);
                }
                return list;
            }
        }

        public List<vehiculeType> vehiculeList()
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select*from " + tblVehicule;
                var comand = new MySqlCommand(sql, sqlConnection);
                var dataReader = comand.ExecuteReader();
                var list = new List<vehiculeType>();
                while (dataReader.Read())
                {
                    var vehicules = new vehiculeType();
                    vehicules.id = dataReader.GetInt32("id");
                    vehicules.name = dataReader.GetString("carro");
                    vehicules.model = dataReader.GetString("modelo");
                    vehicules.year = dataReader.GetString("ano");
                    vehicules.price = dataReader.GetString("preco");
                    vehicules.mark = dataReader.GetString("marca");
                    quantity = dataReader.GetString("quantidade");

                    list.Add(vehicules);
                }
                return list;
            }
        }

        public List<vehiculeType> nameVehiculeList(string name)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = @"select id, carro, modelo, ano, preco, marca,quantidade,tipo from " + tblVehicule + " where" +
"(carro LIKE '%' @carro '%')";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@carro", name);
                var dataReader = comand.ExecuteReader();
                var list = new List<vehiculeType>();
                while (dataReader.Read())
                {
                    var vehicules = new vehiculeType();
                    vehicules.id = dataReader.GetInt32("id");
                    vehicules.name = dataReader.GetString("carro");
                    vehicules.model = dataReader.GetString("modelo");
                    vehicules.year = dataReader.GetString("ano");
                    vehicules.price = dataReader.GetString("preco");
                    vehicules.mark = dataReader.GetString("marca");
                    quantity = dataReader.GetString("quantidade");
                    list.Add(vehicules);
                }
                return list;
            }
        }

        public vehiculeType quantityVehiculeForName(string name)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select  quantidade from " + tblVehicule + "  where carro = @carro";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@carro", name);
                var dataReader = comand.ExecuteReader();
                vehiculeType vehicules = null;
                if (dataReader.Read())
                {
                    vehicules = new vehiculeType();
                    quantity = dataReader.GetString("quantidade");
                }
                return vehicules;
            }
        }

        public vehiculeType codeVehiculeSearch(int id)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select id, carro, modelo, ano, preco, marca, quantidade from " + tblVehicule + " where id = @id";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@id", id);
                var dataReader = comand.ExecuteReader();
                vehiculeType vehicules = null;
                if (dataReader.Read())
                {
                    vehicules = new vehiculeType();
                    vehicules.id = dataReader.GetInt32("id");
                    vehicules.name = dataReader.GetString("carro");
                    vehicules.model = dataReader.GetString("modelo");
                    vehicules.year = dataReader.GetString("ano");
                    vehicules.price = dataReader.GetString("preco");
                    vehicules.mark = dataReader.GetString("marca");
                    quantity = dataReader.GetString("quantidade");
                }
                return vehicules;
            }
        }

        public vehiculeType nameVehiculeSearch(string name)
        {
            using (var sqlConnection = DataBaseConnection.open())
            {
                var sql = "select id, carro, modelo, ano, preco, marca, quantidade, tipo from " + tblVehicule + " where carro = @carro";
                var comand = new MySqlCommand(sql, sqlConnection);
                comand.Parameters.AddWithValue("@carro", name);
                var dataReader = comand.ExecuteReader();
                vehiculeType vehicules = null;
                if (dataReader.Read())
                {
                    vehicules = new vehiculeType();
                    vehicules.id = dataReader.GetInt32("id");
                    vehicules.name = dataReader.GetString("carro");
                    vehicules.model = dataReader.GetString("modelo");
                    vehicules.year = dataReader.GetString("ano");
                    vehicules.price = dataReader.GetString("preco");
                    vehicules.mark = dataReader.GetString("marca");
                }
                return vehicules;
            }
        }
    }
}
