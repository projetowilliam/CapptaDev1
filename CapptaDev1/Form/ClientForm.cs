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

        private void BtnRegisterClient_Click(object sender, EventArgs e)
        {
            if (this.ValidadeInputFieldClient() == true)
            {
                var customerRegister = new CustomerRegiser();
                var customer = new Customer
                {
                    Name = this.txtName.Text,
                    Phone = this.txtPhone.Text,
                    Cpf = this.txtCpf.Text,
                    Street = this.txtStreet.Text,
                    Number = Convert.ToInt32(this.txtNumber.Text),
                    City = this.txtCity.Text,
                    State = this.txtState.Text
                };
                customerRegister.Add(customer);
                FieldClean();
            }
            else
            {
                MessageBox.Show("Por favor verifique se há algum campo vazio");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txtSearch.Text))
            {
                var custumerRegister = new CustomerRegiser();
                var custumer = new Customer();
                custumer = custumerRegister.SearchPersonByName(this.txtSearch.Text);
                this.txtName.Text = custumer.Name;
                this.txtCity.Text = custumer.City;
                this.txtCpf.Text = custumer.Cpf;
                this.txtState.Text = custumer.State;
                this.txtNumber.Text = Convert.ToString(custumer.Number);
                this.txtStreet.Text = custumer.Street;
                this.txtPhone.Text = custumer.Phone;
            }
            else
            {
                MessageBox.Show("Por favor forneça um nome para pesquisa");
            }
        }

        private void BbtnClean_Click(object sender, EventArgs e)
        {
            FieldClean();
        }

        private bool ValidadeInputFieldClient()
        {
            if (this.txtCity.Text == string.Empty || this.txtCpf.Text == string.Empty || this.txtName.Text == string.Empty
                || this.txtNumber.Text == string.Empty || this.txtPhone.Text == string.Empty || this.txtState.Text == string.Empty
                || this.txtStreet.Text == string.Empty)
            { return false; }
            else
            { return true; }
        }

        private void FieldClean()
        {
            this.txtCity.Text = string.Empty;
            this.txtCpf.Text = string.Empty;
            this.txtState.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtNumber.Text = string.Empty;
            this.txtStreet.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
        }
    }
}
