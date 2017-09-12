using SinalVeiculos.Dados;
using SinalVeiculos.Data;
using SinalVeiculos.Models;
using SinalVeiculos.Register;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class HomeForm : Form
    {
        private int idCar;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.UpdateSalesmanNameComboBox();
            this.UpdateCarNameComboBox();
            this.UpdateCustomerNameComboBox();
        }

        public void UpdateCustomerNameComboBox()
        {
            var customerRegister = new CustomerRegiser();
            comboBoxClient.Items.AddRange(customerRegister.GetAll().Select(customer => customer.Name).ToArray());
        }

        public void UpdateCarNameComboBox()
        {
            var carRegister = new CarRegister();
            comboBoxProduct.Items.AddRange(carRegister.GetAll().Select(car => car.Name).ToArray());
        }

        private void UpdateSalesmanNameComboBox()
        {
            var employeerRegister = new EmployeerRegister();
            comboBoxSalesman.Items.AddRange(employeerRegister.GetAll().Select(salesman => salesman.Name).ToArray());
        }

        private void BtnComfirmSalesRegister(object sender, EventArgs e)
        {
            if (ValidateInputFieldsSales() == true)
            {
                var requestRegister = new RequestRegister();
                var request = new Request
                {
                    Price = Convert.ToInt32(txtPrice.Text),
                    ResponsibleForSale = this.comboBoxSalesman.Text,
                    Product = this.comboBoxProduct.Text,
                    Quantity = Convert.ToInt32(this.units.Text),
                    Client = this.txtName.Text,
                    CpfClient = this.txtCpf.Text,
                    Date = this.date.Text
                };

                requestRegister.Add(request);
                requestRegister.UpdateVehiculeQauntity(this.BalanceInStock(), this.idCar);
                this.FieldClean();
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos e tente novamente");
            }
        }

        private void BtnSearchClient(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.comboBoxClient.Text))
            {
                var customer = new Customer();
                var clientRegister = new CustomerRegiser();
                customer = clientRegister.SearchPersonByName(this.comboBoxClient.Text);
                this.txtName.Text = customer.Name;
                this.txtPhone.Text = customer.Phone;
                this.txtCpf.Text = customer.Cpf;
                this.txtStreet.Text = customer.Street;
                this.txtNumber.Text = Convert.ToString(customer.Number);
                this.txtCity.Text = customer.City;
                this.txtState.Text = customer.State;
            }
            else
            {
                MessageBox.Show("Por favor preencha com um nome o campo de pesquisa");
            }
        }

        private void BtnFieldClean_Click(object sender, EventArgs e)
        {
            this.FieldClean();
        }

        private void BtnRefreshHome_Click(object sender, EventArgs e)
        {
            this.UpdateSalesmanNameComboBox();
            this.UpdateCustomerNameComboBox();
            this.UpdateSalesmanNameComboBox();
        }

        private void BtnSearchVehiculeByName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.comboBoxProduct.Text))
            {
                var car = new Car();
                var carRegister = new CarRegister();
                car = carRegister.SearchVehicleByName(comboBoxProduct.Text);
                this.idCar = car.Id;
                this.txtCar.Text = car.Name;
                this.txtYear.Text = car.Year;
                this.txtModel.Text = car.Model;
                this.txtPrice.Text = car.Price;
                this.txtBrand.Text = car.Brand;
                this.txtQuantity.Text = Convert.ToString(carRegister.Quantity);
            }
            else
            {
                MessageBox.Show("Por favor escolha um produto");
            }
        }

        private void BtnShowClientForm_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm();
            clientForm.ShowDialog();
        }

        private void BtnShowEmployeeForm_Click(object sender, EventArgs e)
        {
            var employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void BtnShowStockForm_Click(object sender, EventArgs e)
        {
            var stockForm = new StockForm();
            stockForm.ShowDialog();
        }

        private void BtnShowReportForm_Click(object sender, EventArgs e)
        {
            var reportForm = new ReportForm();
            reportForm.ShowDialog();
        }

        private int BalanceInStock()
        {
            var currentQuantityInStock = Convert.ToInt32(txtQuantity.Text);
            var unitsSold = Convert.ToInt32(this.units.Text);
            return currentQuantityInStock - unitsSold;
        }

        private bool ValidateInputFieldsSales()
        {
            if (txtCity.Text == "" || txtCpf.Text == "" || txtState.Text == "" ||
               txtNumber.Text == "" || txtStreet.Text == "" || txtPhone.Text == "" ||
               units.Text == "")
            { return false; }
            else
            { return true; }
        }

        private void FieldClean()
        {
            this.txtCar.Text = string.Empty;
            this.txtYear.Text = string.Empty;
            this.txtModel.Text = string.Empty;
            this.txtPrice.Text = string.Empty;
            this.txtQuantity.Text = string.Empty;
            this.txtCity.Text = string.Empty;
            this.txtCpf.Text = string.Empty;
            this.txtName.Text = string.Empty;
            this.txtNumber.Text = string.Empty;
            this.txtPhone.Text = string.Empty;
            this.txtState.Text = string.Empty;
            this.txtStreet.Text = string.Empty;
            this.txtYear.Text = string.Empty;
            this.comboBoxClient.Text = string.Empty;
            this.comboBoxProduct.Text = string.Empty;
            this.comboBoxSalesman.Text = string.Empty;
        }
    }
}


