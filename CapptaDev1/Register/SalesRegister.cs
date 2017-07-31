using CapptaDev1.Dados.Pessoas;
using CapptaDev1.Models;

namespace CapptaDev1.Data
{
    class SalesRegister : PersonRegister<Employee>
    {
        public override string tblPerson
        {
            get { return ("funcionario"); }
        }
    }
}
