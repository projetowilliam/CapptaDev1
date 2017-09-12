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
                mysqlComand.Parameters.AddWithValue("@carro", vehicles.Name);
                mysqlComand.Parameters.AddWithValue("@modelo", vehicles.Model);
                mysqlComand.Parameters.AddWithValue("@ano", vehicles.Year);
                mysqlComand.Parameters.AddWithValue("@preco", vehicles.Price);
                mysqlComand.Parameters.AddWithValue("@marca", vehicles.Brand);
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
                        Id = executeReader.GetInt32("id"),
                        Name = executeReader.GetString("carro"),
                        Model = executeReader.GetString("modelo"),
                        Year = executeReader.GetString("ano"),
                        Price = executeReader.GetString("preco"),
                        Brand = executeReader.GetString("marca")
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
                    vehicules.Id = executeReader.GetInt32("id");
                    vehicules.Name = executeReader.GetString("carro");
                    vehicules.Model = executeReader.GetString("modelo");
                    vehicules.Year = executeReader.GetString("ano");
                    vehicules.Price = executeReader.GetString("preco");
                    vehicules.Brand = executeReader.GetString("marca");
                    Quantity = executeReader.GetInt32("quantidade");
                }
                return vehicules;
            }
        }
    }
}
