using CapptaDev1.Modelos;
using CapptaDev1.Models.CapptaDev1.Modelos;
using System.Collections.Generic;

namespace CapptaDev1.Interface
{
    interface IPersonRegister
    {
        void peopleAdd(Person clientEntry);

        void peopleChange(Person clientEntry, string people);

        List<Person> peopleList();

        List<Person> nameListPeople(string name, string peopleType);

        Person nameSearchPeople(string name, string peopleType);

        Person codeSearchPeople(int id, string peopleType);



    }
}
