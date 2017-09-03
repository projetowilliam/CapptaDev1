using SinalVeiculos.Dados.Pessoas;
using SinalVeiculos.Models;

namespace SinalVeiculos.Data
{
    class EmployeerRegister : PersonRegister<Employee>
    {
        public override string TableName
        {
            get { return "funcionario"; }
        }
    }
}
