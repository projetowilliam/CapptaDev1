﻿using System;
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

        public abstract void comprar();

        public abstract void alterarCadastro();
        //public override  void alterarCliente(Cliente cliente)

        public abstract void incluir(Pessoa pessoa);
       
        public abstract Pessoa pesquisarPorNome(string nome);




    }
}
