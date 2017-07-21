using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapptaDev1
{
    public abstract class Carro
    {
        public int id { get; set; }
        public string  carro { get; set; }
        public string modelo { get; set; }
        public string ano { get; set; }
        public string preco { get; set; }
        public string marca { get; set; }
        public string quantidade { get; set; }

        public Carro()
        {

        }

        public  abstract void adicionarCarro(Carro carro);

        public abstract void alterarCarro(Carro carro);

       
        public abstract List<Carro> listarCarro();

        public abstract List<Carro> ListarCarroPorNome(string nome);

        public abstract CarroPopular pesquisarPorNome(string nome);

        public abstract CarroPopular pesquisarPorNomeQuantidade(string nome);

    }
}
