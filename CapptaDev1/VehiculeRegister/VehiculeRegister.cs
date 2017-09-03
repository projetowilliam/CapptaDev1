using SinalVeiculos.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SinalVeiculos.Register
{
    public abstract class VehiculeRegister<VehiculeType> where VehiculeType : IVehicule, new()
    {
        public int Quantity { get; set; }
        public abstract string NameTable { get; }

        public void Add(VehiculeType vehicles)
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var insertQuery = @"insert into " + NameTable + " (carro, modelo, ano,preco, marca, quantidade)" +
                    "values(@carro,@modelo,@ano,@preco,@marca, @quantidade)";
                var mysqlComand = new MySqlCommand(insertQuery, dataBaseConectionOpen);
                mysqlComand.Parameters.AddWithValue("@carro", vehicles.name);
                mysqlComand.Parameters.AddWithValue("@modelo", vehicles.model);
                mysqlComand.Parameters.AddWithValue("@ano", vehicles.year);
                mysqlComand.Parameters.AddWithValue("@preco", vehicles.price);
                mysqlComand.Parameters.AddWithValue("@marca", vehicles.mark);
                mysqlComand.Parameters.AddWithValue("@quantidade", Quantity);
                mysqlComand.ExecuteNonQuery();
            }
        }

        public void Delete(int identificadorVehicule)
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var deleteQuery = @"delete from  " + NameTable + "  where id = @identificadorVeiculo";
                var mysqlComand = new MySqlCommand(deleteQuery, dataBaseConectionOpen);
                mysqlComand.Parameters.AddWithValue("@identificadorVeiculo",identificadorVehicule );           
                mysqlComand.ExecuteNonQuery();
            }
        }

        public IEnumerable<VehiculeType> GetAll()
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var selectQuery = "select*from " + NameTable;
                var mysqlComand = new MySqlCommand(selectQuery, dataBaseConectionOpen);
                var executeReader = mysqlComand.ExecuteReader();

                while (executeReader.Read())
                {
                    var vehicules = new VehiculeType()
                    {
                        id = executeReader.GetInt32("id"),
                        name = executeReader.GetString("carro"),
                        model = executeReader.GetString("modelo"),
                        year = executeReader.GetString("ano"),
                        price = executeReader.GetString("preco"),
                        mark = executeReader.GetString("marca")
                    };
                    Quantity = executeReader.GetInt32("quantidade");
                    yield return vehicules;
                }             
            }
        }

        public VehiculeType SearchVehicleByName(string name)
        {
            using (var dataBaseConectionOpen = DataBaseConnection.Open())
            {
                var selectQuery = "select id, carro, modelo, ano, preco, marca, quantidade from " + NameTable + " where carro = @carro";
                var mysqlComand = new MySqlCommand(selectQuery, dataBaseConectionOpen);
                mysqlComand.Parameters.AddWithValue("@carro", name);
                var executeReader = mysqlComand.ExecuteReader();
                VehiculeType vehicules = new VehiculeType();
                if (executeReader.Read())
                {
                    vehicules.id = executeReader.GetInt32("id");
                    vehicules.name = executeReader.GetString("carro");
                    vehicules.model = executeReader.GetString("modelo");
                    vehicules.year = executeReader.GetString("ano");
                    vehicules.price = executeReader.GetString("preco");
                    vehicules.mark = executeReader.GetString("marca");
                    Quantity = executeReader.GetInt32("quantidade");
                }
                return vehicules;
            }
        }
    }
}
