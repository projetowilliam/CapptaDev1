using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapptaDev1
{
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        //metodo para limpar
        private void limparCampos()
        {
            textoCarro.Text = "";
            textoAno.Text = "";
            textoModelo.Text = "";
            textoPreco.Text = "";
            textoQuantidade.Text = "";
            textoMarca.Text = "";

        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {


                CarroPopular carroPopular = new CarroPopular();

                carroPopular.carro = Convert.ToString(textoCarro.Text);
                carroPopular.modelo = Convert.ToString(textoModelo.Text);
                carroPopular.ano = Convert.ToString(textoAno.Text);
                carroPopular.preco = Convert.ToString(textoPreco.Text);
                carroPopular.marca = Convert.ToString(textoMarca.Text);
                carroPopular.quantidade = Convert.ToString(textoQuantidade.Text);

                carroPopular.adicionarCarro(carroPopular);
                limparCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //botão para limpar campos
        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        // botão para pesquisar estoque por Código
        private void botaoPesquisar_Click(object sender, EventArgs e)
        {
            if (textoNomePesquisa.Text=="")
            {
                MessageBox.Show("Por favor preencha o campo para pesquisa");
                textoNomePesquisa.Focus();
            }
            else
            {
                botaoAlterar.Visible = true;
                try
                {
                    int id = Convert.ToInt32(textoNomePesquisa.Text);

                    CarroPopular car = new CarroPopular();
                    CarroPopular carro = new CarroPopular();

                    car = carro.pesquisarCarroPorCodigo(id);

                  
                    textoCarro.Text = car.carro;
                    textoAno.Text = car.ano;
                    textoModelo.Text = car.modelo;
                    textoPreco.Text = car.preco;
                    textoMarca.Text = car.marca;
                    textoQuantidade.Text = car.quantidade;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private string NewMethod()
        {
            return textoNomePesquisa.Text;
        }

        private void botaoAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                CarroPopular carro = new CarroPopular();
                CarroPopular car = new CarroPopular();

                car.id = Convert.ToInt32(textoNomePesquisa.Text);
                car.carro = textoCarro.Text;
                car.ano = textoAno.Text;
                car.modelo = textoModelo.Text;
                car.preco = textoPreco.Text;
                car.marca = textoMarca.Text;
                car.quantidade = textoQuantidade.Text;
                carro.alterarCarro(car);

                limparCampos();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            botaoSalvar.Visible = true;
            textoNomePesquisa.Visible = false;
            pictureBoxBotaoPesquisar.Visible = false;
            label3.Visible = false;
        }

        private void Carros_Load(object sender, EventArgs e)
        {

        }
    }
}
