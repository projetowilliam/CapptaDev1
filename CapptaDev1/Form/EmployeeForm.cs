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
            this.FieldClean();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidadeInputFieldEmployee() == true)
            {
                var employeerRegister = new EmployeerRegister();
                var employee = new Employee
                {
                    Name = Convert.ToString(this.txtName.Text),
                    Phone = Convert.ToString(this.txtPhone.Text),
                    Cpf = Convert.ToString(this.txtCpf.Text),
                    Street = Convert.ToString(this.txtStreet.Text),
                    Number = Convert.ToInt32(this.txtNumber.Text),
                    City = Convert.ToString(this.txtCity.Text),
                    State = Convert.ToString(this.txtState.Text)
                };
                employeerRegister.Add(employee);
                this.FieldClean();
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
            this.txtCity.Text = string.Empty;
            this.txtCpf.Text = string.Empty;
            this.txtState.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtNumber.Text = string.Empty;
            this.txtStreet.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
        }

        private void BtnSearcheEmployeer_Click(object sender, EventArgs e)
        {
            if (this.ValidateIfTxtSearchEmployeerIsEmpty() == true)
            {
                var employeerRegister = new EmployeerRegister();
                var employee = new Employee();
                employee = employeerRegister.SearchPersonByName(this.txtSearch.Text);
                this.txtName.Text = employee.Name;
                this.txtCity.Text = employee.City;
                this.txtCpf.Text = employee.Cpf;
                this.txtState.Text = employee.State;
                this.txtNumber.Text =Convert.ToString( employee.Number);
                this.txtStreet.Text = employee.Street;
                this.txtPhone.Text = employee.Phone;
            }
            else
            {
                MessageBox.Show("Por favor escolha um nome para pesquisa");
            }
        }

        private bool ValidateIfTxtSearchEmployeerIsEmpty()
        {
            if (this.txtSearch.Text == "") { return false; } else { return true; }
        }

        private bool ValidadeInputFieldEmployee()
        {
            if (this.txtCity.Text == string.Empty || this.txtCpf.Text == string.Empty || this.txtName.Text == string.Empty
                || this.txtNumber.Text == string.Empty || this.txtPhone.Text == string.Empty || this.txtState.Text == string.Empty
                || this.txtStreet.Text == string.Empty)
            { return false; }
            else
            { return true; }
        }
    }
}
