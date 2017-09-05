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
            UpdateSalesGridView();
        }
  
        private void UpdateCustomerGridView()
        {
            var customerRegister = new CustomerRegiser();  
            this.dgvClient.DataSource = customerRegister.GetAll().ToList();
        }

        private void UpdateEmployeeGridView()
        {
            var employeeRegister = new EmployeerRegister();
            this.dgvEmployee.DataSource =  employeeRegister.GetAll().ToList();
        }

        private void UpdateSalesGridView()
        {
            var requestRegister = new RequestRegister();
            this.dgvSales.DataSource =  requestRegister.GetAll().ToList();
        }

        private void UpdateVehiculesGridView()
        {
            var carRegister = new CarRegister();
            this.dgvProducts.DataSource = carRegister.GetAll().ToList();
        }

        private void BtnSearchCustomerForName_Click(object sender, EventArgs e)
        {
            var customerRegister = new CustomerRegiser();
            this.dgvClient.DataSource = customerRegister.GetAll().Where(customer => customer.Name == txtSearchProductsForName.Text).ToList();
        }

        private void BtnSarcheEmloyeerForName(object sender, EventArgs e)
        {
            var employeerRegister = new EmployeerRegister();
            this.dgvClient.DataSource =  employeerRegister.GetAll().Where(employee => employee.Name == this.txtSearchEmployeerForName.Text).ToList();
        }

        private void BtnSearcheProductForName_Click(object sender, EventArgs e)
        {
            var carRegister = new CarRegister();
            this.dgvProducts.DataSource = carRegister.GetAll().Where(car => car.Name == this.txtSearchProductsForName.Text).ToList();
        }

        private void BtnSearchSalesForDate_Click(object sender, EventArgs e)
        {
            var requestRegister = new RequestRegister();
            this.dgvSales.DataSource = requestRegister.GetAll().Where( sales => sales.Date == this.dateSales.Text).ToList();
        }

    }
}