
using SinalVeiculos.Models;
using SinalVeiculos.Register;
using System;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class StockForm : Form
    {
        public StockForm()
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
            carRegister.Quantity = Convert.ToInt32(textBoxQuantidade.Text);
            carRegister.Add(car);
            limparCampos();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {           
            if (string.IsNullOrEmpty(textBoxPesquisa.Text))
            {
                MessageBox.Show("Por favor preencha o campo para pesquisa");
                textBoxPesquisa.Focus();
            }
            else
            {
                var name =(textBoxPesquisa.Text);
                var carRegister = new CarRegister();
                var car = new Car();
                car = carRegister.SearchVehicleByName(name);
                if (carRegister != null)
                {
                    textBoxCodigoID.Text = Convert.ToString(car.id);
                    textBoxNome.Text = car.name;
                    textBoxAno.Text = car.year;
                    textBoxModelo.Text = car.model;
                    textBoxPreco.Text = car.price;
                    textBoxMarca.Text = car.mark;
                    textBoxQuantidade.Text = Convert.ToString(carRegister.Quantity);
                }
                else
                {
                    MessageBox.Show("Verifique o campo digitado. Não há item correspondente na Base");
                }
            }
        }
        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            buttonSalvar.Visible = true;
        }

        private void Estoque_Load(object sender, EventArgs e)
        {

            EnableButtons();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var exclusionCode = Convert.ToInt32(textBoxCodigoID.Text);
            var carRegister = new CarRegister();
            carRegister.Delete(exclusionCode);
        }
        private void EnableButtons()
        {
            
            ButtonDelete.Visible = false;
            buttonSalvar.Visible = false;
            BtnGoBack.Visible = false;
            textBoxCodigoID.Visible = false;
            BtnSearch.Visible = false;
            textBoxPesquisa.Visible = false;

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ButtonDelete.Visible = false;
            buttonSalvar.Visible = true;
            BtnSearch.Visible = false;
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            ButtonDelete.Visible = false;
            buttonSalvar.Visible = false;
            BtnSearch.Visible = false;
            textBoxCodigoID.Visible = true;
            BtnSearch.Visible = true;
            textBoxPesquisa.Visible = true;
            ButtonDelete.Visible = true;
        }
    }
}


