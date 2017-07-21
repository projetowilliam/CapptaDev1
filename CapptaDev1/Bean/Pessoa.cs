using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public abstract class Pessoa
    {
        public int codigo{ get; set; }
        public String nome { get; set; }
        public String  telefone { get; set; }
        public String cpf { get; set; }
        public String rua { get; set; }
        public String numero { get; set; }
        public String cidade { get; set; }
        public String estado { get; set; }

        public Pessoa()
        {

        }

        
        // metodo para aiterar
        public abstract void alterarCadastro(Pessoa pessoa);
        
        // metodo para adicionar novo cliente
        public abstract void incluir(Pessoa pessoa);
       
        //metodo para listar pessoa sem filtro
        public abstract List<Pessoa> Listar();

        //metodo para listar por nome
        public abstract List<Pessoa> ListarPorNome(string nome);

        // metodo para listar por código
        public abstract List<Pessoa> ListarPorCodigo(int codigo);


    }
}
