using SinalVeiculos.Dados.Pessoas;
using SinalVeiculos.Models;

namespace SinalVeiculos.Data
{
    public class CustomerRegiser : PersonRegister<Customer>
    {
        public override string TableName
        {
            get { return "clientes"; }
        }
    }
}
