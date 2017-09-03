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
            var customerRegister = new CustomerRegiser();
            var customer = new Customer
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Cpf = txtCpf.Text,
                Street = txtStreet.Text,
                Number = txtNumber.Text,
                City = txtCity.Text,
                State = txtState.Text
            };
            customerRegister.Add(customer);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSearchClient_Click(object sender, EventArgs e)
        {
            var registerCostumer = new CustomerRegiser();
            var custumer = new Customer();
            custumer = registerCostumer.SearchPersonByName(txtSearch.Text);
            txtName.Text = custumer.Name;
            txtCity.Text = custumer.City;
            txtCpf.Text = custumer.Cpf;
            txtState.Text = custumer.State;
            txtNumber.Text = custumer.Number;
            txtStreet.Text = custumer.Street;
            txtPhone.Text = custumer.Phone;
        }

        private void BbtnClean_Click(object sender, EventArgs e)
        {
            FieldClean();
        }

        private bool ValidateIfTxtSearchClientIsEmpty()
        {
            if (txtSearch.Text == "") { return false; } else { return true; }
        }

        private bool ValidadeInputFieldClient()
        {
            if (txtCity.Text == "" || txtCpf.Text == "" || txtName.Text == "" || txtNumber.Text == ""
                || txtPhone.Text == "" || txtState.Text == "" || txtStreet.Text == "")
            { return false; }
            else
            { return true; }
        }

        private void FieldClean()
        {
            txtCity.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtState.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }
    }
}
