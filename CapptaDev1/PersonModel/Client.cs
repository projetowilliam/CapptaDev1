using SinalVeiculos.Models.CapptaDev1.Modelos;

namespace SinalVeiculos.Models
{
    public class Customer : IPerson
    {
        public string City { get; set; }
        public int Id { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
    }
}
