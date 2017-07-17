using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapptaDev1.Properties;

namespace CapptaDev1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               

                Dados.Dal dal = new Dados.Dal();
                CarroPopular carroPopular = new CarroPopular();

                carroPopular.carro = Convert.ToString(textoCarro.Text);
                carroPopular.modelo = Convert.ToString(textoModelo.Text);
                carroPopular.ano = Convert.ToString(textoAno.Text);
                carroPopular.preco = Convert.ToString(textoPreco.Text);

                dal.adicionarCarro(carroPopular);
            }
            catch (Exception)
            {

               throw;
            }
        }

        private void botaoRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.nome = Convert.ToString(textoNome.Text);
                cliente.telefone= Convert.ToString(textoTelefone.Text);
                cliente.cpf = Convert.ToString(textoCpf.Text);
                cliente.rua = Convert.ToString(textoRua.Text);
                cliente.numero = Convert.ToString(textoNumero.Text);
                cliente.cidade = Convert.ToString(textoCidade.Text);
                cliente.estado = Convert.ToString(textoEstado.Text);

                cliente.incluir(cliente);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
