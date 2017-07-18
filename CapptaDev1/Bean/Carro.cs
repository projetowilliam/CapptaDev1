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

        public Carro()
        {

        }

        public  abstract void adicionarCarro(Carro carro);

        public abstract void alterarCarro(Carro carro);

        public abstract Carro pesquisarPorNome(string nome);


    }
}
