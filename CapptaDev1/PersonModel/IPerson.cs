namespace SinalVeiculos.Models
{
    namespace CapptaDev1.Modelos
    {
        public interface IPerson
        {
            int Code { get; set; }
            string Name { get; set; }
            string Phone { get; set; }
            string Cpf { get; set; }
            string Street { get; set; }
            string Number { get; set; }
            string City { get; set; }
            string State { get; set; }
        }
    }
}

