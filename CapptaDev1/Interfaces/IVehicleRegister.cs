using CapptaDev1.Modelos;
using System.Collections.Generic;

namespace CapptaDev1.Interfaces
{
    interface VehicleRegister
    {
        void vehiculeAdd(Vehicules vehicles);

        void vehiculeChange(Vehicules vehicles);

        List<Vehicules> vehiculeList();

        List<Vehicules> nameVehiculeList(string name);

        Vehicules nameVehiculeSearch(string name);

        Vehicules codeVehiculeSearch(int id);

        Vehicules quantityVehiculeForName(string name, string vehiculoType);

        List<Vehicules> dateVehiculeList(string date, string type);

    }
}
