
using SinalVeiculos.Models.CapptaDev1.Modelos;

namespace SinalVeiculos.Models
{
    public class Employee : IPerson
    {
        public string City { get; set; }
        public int Code { get; set; }
        public string Cpf { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
    }
}
