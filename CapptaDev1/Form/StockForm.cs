using CapptaDev1.Modelos;
using CapptaDev1.Models;
using CapptaDev1.Register;
using System;
using System.Windows.Forms;

namespace CapptaDev1
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }
        private void limparCampos()
        {
            textBoxNome.Text = "";
            textBoxAno.Text = "";
            textBoxModelo.Text = "";
            textBoxPreco.Text = "";
            textBoxQuantidade.Text = "";
            textBoxMarca.Text = "";
            textBoxQuantidade.Text = "";
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var car = new Car();
            var carRegister = new CarRegister();
            car.name = textBoxNome.Text;
            car.model = textBoxModelo.Text;
            car.year = textBoxAno.Text;
            car.price = textBoxPreco.Text;
            car.mark = textBoxMarca.Text;
            carRegister.quantity = textBoxQuantidade.Text;
            carRegister.vehiculeAdd(car);
            limparCampos();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            var car = new Car();
            var carRegister = new CarRegister();
            car.name = textBoxNome.Text;
            car.model = textBoxModelo.Text;
            car.year = textBoxAno.Text;
            car.price = textBoxPreco.Text;
            car.mark = textBoxMarca.Text;
            carRegister.quantity = textBoxQuantidade.Text;
            carRegister.vehiculeChange(car);
            limparCampos();
        }

        private void pictureBoxPesquisa_Click(object sender, EventArgs e)
        {
            buttonSalvar.Visible = false;
            if (textBoxPesquisa.Text == "")
            {
                MessageBox.Show("Por favor preencha o campo para pesquisa");
                textBoxPesquisa.Focus();
            }
            else
            {
                int nome = Convert.ToInt32(textBoxPesquisa.Text);
                var carRegister = new CarRegister();
                var car = new Car();
                car = carRegister.codeVehiculeSearch(nome);
                if (carRegister != null)
                {
                    textBoxNome.Text = car.name;
                    textBoxAno.Text = car.year;
                    textBoxModelo.Text = car.model;
                    textBoxPreco.Text = car.price;
                    textBoxMarca.Text = car.mark;
                    textBoxQuantidade.Text = carRegister.quantity;
                }
                else
                {
                    MessageBox.Show("Verifique o campo digitado. Não há item correspondente na Base");
                }
            }
        }
        private void pictureBoxVoltar_Click(object sender, EventArgs e)
        {
            buttonSalvar.Visible = true;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

        }
    }
}


