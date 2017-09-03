using SinalVeiculos.Data;
using SinalVeiculos.Models;
using System;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnRegisterClient_Click(object sender, EventArgs e)
        {
            CheckCompletedField();
            var customerRegister = new CustomerRegiser();
            var customer = new Customer()
            {
                Name = textNome.Text,
                Phone = textoTelefone.Text,
                Cpf = textoCpf.Text,
                Street = textoRua.Text,
                Number = textoNumero.Text,
                City = textoCidade.Text,
                State = textoEstado.Text
            };
            customerRegister.Add(customer);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FieldClean()
        {
            textoCidade.Text = string.Empty;
            textoCpf.Text = string.Empty;
            textoEstado.Text = string.Empty;
            textNome.Text = string.Empty;
            textoNumero.Text = string.Empty;
            textoRua.Text = string.Empty;
            textoTelefone.Text = string.Empty;
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            var registerCostumer = new CustomerRegiser();
            var custumer = new Customer();
            var name = textoPesquisa.Text;

            custumer = registerCostumer.SearchPersonByName(name);
            textNome.Text = custumer.Name;
            textoCidade.Text = custumer.City;
            textoCpf.Text = custumer.Cpf;
            textoEstado.Text = custumer.State;
            textoNumero.Text = custumer.Number;
            textoRua.Text = custumer.Street;
            textoTelefone.Text = custumer.Phone;
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }
        private void CheckCompletedField()
        {
            if (string.IsNullOrEmpty(textoCidade.Text))
            {
                MessageBox.Show("por favor preencher o campo cidade");
            }
            if (string.IsNullOrEmpty(textoCpf.Text))
            {
                MessageBox.Show("por favor preencher o campo cpf");
            }
            if (string.IsNullOrEmpty(textoEstado.Text))
            {
                MessageBox.Show("por favor preencher o campo estado");
            }
            if (string.IsNullOrEmpty(textoNumero.Text))
            {
                MessageBox.Show("por favor preencher o campo Número");
            }
            if (string.IsNullOrEmpty(textoRua.Text))
            {
                MessageBox.Show("por favor preencher o campo Rua");
            }
            if (string.IsNullOrEmpty(textoTelefone.Text))
            {
                MessageBox.Show("por favor preencher o campo Telefone");
            }

        }
    }
}
