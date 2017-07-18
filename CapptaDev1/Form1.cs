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

        //Registrar cliente
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
                limparCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Registrar Carro
        private void botaoRegistraCarro_Click(object sender, EventArgs e)
        {
            try
            {

                CarroPopular carroPopular = new CarroPopular();

                carroPopular.carro = Convert.ToString(textoCarro.Text);
                carroPopular.modelo = Convert.ToString(textoModelo.Text);
                carroPopular.ano = Convert.ToString(textoAno.Text);
                carroPopular.preco = Convert.ToString(textoPreco.Text);

                carroPopular.adicionarCarro(carroPopular);
                limparCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //metodo para limpar
        private void limparCampos()
        {
            textoCarro.Text = "";
            textoAno.Text = "";
            textoCidade.Text = "";
            textoCpf.Text = "";
            textoEstado.Text = "";
            textoModelo.Text = "";
            textoNome.Text = "";
            textoNumero.Text = "";
            textoPreco.Text = "";
            textoRua.Text = "";
            textoTelefone.Text = "";
            
        }

        //Realizar pedidos
        private void botaoComfirmarPedido_Click(object sender, EventArgs e)
        {


        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
