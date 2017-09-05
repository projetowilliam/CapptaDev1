
namespace SinalVeiculos.Models
{
    public class Car : IVehicule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Mark { get; set; }
    }
}

