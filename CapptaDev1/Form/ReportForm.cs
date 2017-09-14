using SinalVeiculos.Dados;
using SinalVeiculos.Data;
using SinalVeiculos.Register;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            UpdateCustomerGridView();
            UpdateEmployeeGridView();
            UpdateRequestGridView();
            UpdateCarGridView();
        }

        private void UpdateCarGridView()
        {
            var carRegister = new CarRegister();
            this.dgvCar.DataSource = carRegister.GetAll().ToList();
        }

        private void UpdateCustomerGridView()
        {
            var customerRegister = new CustomerRegiser();
            this.dgvCustomer.DataSource = customerRegister.GetAll().ToList();
        }

        private void UpdateEmployeeGridView()
        {
            var employeeRegister = new EmployeerRegister();
            this.dgvEmployee.DataSource = employeeRegister.GetAll().ToList();
        }

        private void UpdateRequestGridView()
        {
            var requestRegister = new RequestRegister();
            this.dgvRequest.DataSource = requestRegister.GetAll().ToList();
        }

        private void UpdateVehiculesGridView()
        {
            var carRegister = new CarRegister();
            this.dgvCar.DataSource = carRegister.GetAll().ToList();
        }

        private void BtnSearchCustomerForName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchClient.Text))
            {
                var customerRegister = new CustomerRegiser();
                this.dgvCustomer.DataSource = customerRegister.GetAll().Where(customer => customer.Name == txtSearchProductsForName.Text).ToList();
            }
            else
            {
                MessageBox.Show("Digite um nome para pesquisa");
            }
        }

        private void BtnSarcheEmloyeerForName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchEmployeerForName.Text))
            {
                var employeerRegister = new EmployeerRegister();
                this.dgvEmployee.DataSource = employeerRegister.GetAll().Where(employee => employee.Name == this.txtSearchEmployeerForName.Text).ToList();
            }
            else
            {
                MessageBox.Show("Digite um nome para pesquisa");
            }
        }

        private void BtnSearcheProductForName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchProductsForName.Text))
            {
                var carRegister = new CarRegister();
                this.dgvCar.DataSource = carRegister.GetAll().Where(car => car.Name == this.txtSearchProductsForName.Text).ToList();
            }
            else
            {
                MessageBox.Show("Por favor digite um nome para pesquisa");
            }
        }

        private void BtnSearchSalesForDate_Click(object sender, EventArgs e)
        {
            var requestRegister = new RequestRegister();
            this.dgvRequest.DataSource = requestRegister.GetAll().Where(sales => sales.Date == this.dateSales.Text).ToList();
        }

    }
}