using SinalVeiculos.Models;

namespace SinalVeiculos.Register
{
    public class CarRegister : VehiculeRegister<Car>
    {
        public override string NameTable
        {
            get { return "carros"; }
        }
    }
}
