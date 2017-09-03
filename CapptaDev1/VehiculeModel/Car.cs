
namespace SinalVeiculos.Models
{
    public class Car : IVehicule
    {
        public int id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string price { get; set; }
        public string mark { get; set; }
    }
}

