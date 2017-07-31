using CapptaDev1.Models;

namespace CapptaDev1.Register
{
    public class CarRegister : CarRegister<Car>
    {
        public override string tblVehicule
        {
            get { return ("carros"); }
        }

        public override string quantity { get; set; }
    }
}
