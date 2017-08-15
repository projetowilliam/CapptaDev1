namespace CapptaDev1.Models
{
    namespace CapptaDev1.Modelos
    {
        public  interface IPerson
        {
             int code { get; set; }
             string name { get; set; }
             string phone { get; set; }
             string cpf { get; set; }
             string street { get; set; }
             string number { get; set; }
             string city { get; set; }
             string state { get; set; }         
        }
    }
}

