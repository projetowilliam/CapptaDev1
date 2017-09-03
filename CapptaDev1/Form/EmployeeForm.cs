using SinalVeiculos.Data;
using SinalVeiculos.Models;
using System;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void BtnClean_Click(object sender, EventArgs e)
        {
            FieldClean();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidadeInputFieldEmployee() == true)
            {
                var employeerRegister = new EmployeerRegister();
                var employee = new Employee();
                employee.Name = Convert.ToString(this.txtName.Text);
                employee.Phone = Convert.ToString(txtPhone.Text);
                employee.Cpf = Convert.ToString(txtCpf.Text);
                employee.Street = Convert.ToString(txtStreet.Text);
                employee.Number = Convert.ToString(txtNumber.Text);
                employee.City = Convert.ToString(txtCity.Text);
                employee.State = Convert.ToString(txtState.Text);
                employeerRegister.Add(employee);
                FieldClean();
            }
            else
            {
                MessageBox.Show("Por favor verifique se tem algum campo vazio");
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FieldClean()
        {
            txtCity.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtState.Text = string.Empty;
            txtName.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtStreet.Text = string.Empty;
            txtPhone.Text = string.Empty;
        }

        private void BtnSearcheEmployeer_Click(object sender, EventArgs e)
        {
            if (ValidateIfTxtSearchEmployeerIsEmpty() == true)
            {
                var employeerRegister = new EmployeerRegister();
                var employee = new Employee();
                employee = employeerRegister.SearchPersonByName(txtSearch.Text);
                txtName.Text = employee.Name;
                txtCity.Text = employee.City;
                txtCpf.Text = employee.Cpf;
                txtState.Text = employee.State;
                txtNumber.Text = employee.Number;
                txtStreet.Text = employee.Street;
                txtPhone.Text = employee.Phone;
            }
            else
            {
                MessageBox.Show("Por favor escolha um nome para pesquisa");
            }
        }

        private bool ValidateIfTxtSearchEmployeerIsEmpty()
        {
            if (txtSearch.Text == "") { return false; } else { return true; }
        }

        private bool ValidadeInputFieldEmployee()
        {
            if (txtCity.Text == "" || txtCpf.Text == "" || txtName.Text == "" || txtNumber.Text == ""
                || txtPhone.Text == "" || txtState.Text == "" || txtStreet.Text == "")
            { return false; }
            else
            { return true; }
        }
    }
}
