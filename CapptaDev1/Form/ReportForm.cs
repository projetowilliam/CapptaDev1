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
            GetAllCustomer();
            GetAllEmployee();
            GetAllSales();
        }
  
        private void GetAllCustomer()
        {
            var customerRegister = new CustomerRegiser();  
            this.dgvClient.DataSource = (from item in customerRegister.GetAll()
                select item).ToList();
        }

        private void GetAllEmployee()
        {
            var employeeRegister = new EmployeerRegister();
            this.dgvEmployee.DataSource = (from item in employeeRegister.GetAll()
                 select item).ToList();
        }

        private void GetAllSales()
        {
            var requestRegister = new RequestRegister();
            this.dgvSales.DataSource = (from item in requestRegister.GetAll()
                 select item).ToList();
        }

        private void GetaAllVehicules()
        {
            var carRegister = new CarRegister();
            this.dgvSales.DataSource = (from item in carRegister.GetAll()
                 select item).ToList();
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            var customerRegister = new CustomerRegiser();
            this.dgvClient.DataSource = (from item in customerRegister.GetAll()
                  where item.Name == this.txtSearchClient.Text select item).ToList();
        }

        private void BtnSarcheEmloyeerForName(object sender, EventArgs e)
        {
            var employeerRegister = new EmployeerRegister();
            this.dgvClient.DataSource = (from item in employeerRegister.GetAll()
                  where item.Name == this.txtSearchEmployeerForName.Text select item).ToList();
        }

        private void BtnSearcheProduct_Click(object sender, EventArgs e)
        {
            var carRegister = new CarRegister();
            this.dgvSales.DataSource = (from item in carRegister.GetAll()
                 where item.name == this.txtSearchProductsForName.Text select item).ToList();
        }

        private void BtnPesquisaVenda_Click(object sender, EventArgs e)
        {
            var requestRegister = new RequestRegister();
            this.dgvSales.DataSource = (from item in requestRegister.GetAll()
                  where item.date == this.dateSales.Text select item).ToList();
        }

    }
}