using CapptaDev1.Models.CapptaDev1.Modelos;
using System.Collections.Generic;

namespace CapptaDev1.Interface
{
    interface IPersonRegister
    {
        void peopleAdd(IPerson clientEntry);

        void peopleChange(IPerson clientEntry, string people);

        List<IPerson> peopleList();

        List<IPerson> nameListPeople(string name, string peopleType);

        IPerson nameSearchPeople(string name, string peopleType);

        IPerson codeSearchPeople(int id, string peopleType);



    }
}
