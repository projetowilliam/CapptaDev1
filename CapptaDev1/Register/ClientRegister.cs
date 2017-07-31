using CapptaDev1.Dados.Pessoas;
using CapptaDev1.Models;

namespace CapptaDev1.Data
{
    public class ClientRegister : PersonRegister<Client>
    {
        public override string tblPerson
        {
            get { return "clientes"; }
        }
    }
}
