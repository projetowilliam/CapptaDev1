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
            this.ListSalesmanName();
            this.ListCarName();
            this.ListCustomerName();
        }

        public void ListCustomerName()
        {
            var customerRegister = new CustomerRegiser();
            comboBoxClient.Items.AddRange((from item in customerRegister.GetAll() select item.Name).ToArray());
        }

        public void ListCarName()
        {
            var carRegister = new CarRegister();
            comboBoxProduct.Items.AddRange((from item in carRegister.GetAll() select item.name).ToArray());
        }

        private void ListSalesmanName()
        {
            var salesmanRegister = new EmployeerRegister();
            comboBoxSalesman.Items.AddRange((from item in salesmanRegister.GetAll() select item.Name).ToArray());
        }

        private void BtnComfirmSalesRegister(object sender, EventArgs e)
        {
            if (ValidateInputFieldsSales() == true)
            {
                var requestRegister = new RequestRegister();
                var request = new Request
                {
                    value = Convert.ToInt32(txtPrice.Text),
                    responsibleForSale = this.comboBoxSalesman.Text,
                    product = this.comboBoxProduct.Text,
                    quantity = Convert.ToInt32(this.units.Text),
                    client = this.txtName.Text,
                    cpfClient = this.txtCpf.Text,
                    date = this.date.Text
                };
                requestRegister.Add(request);
                requestRegister.UpdateVehiculeQauntity(this.BalanceInStock(), this.idCar);
            }
            else
            {
                MessageBox.Show("Por favor preencha os campos e tente novamente");
            }
        }

        private void BtnSearchClient(object sender, EventArgs e)
        {
            if (this.ValidateIfComboBoxClientIsEmpty() == true)
            {
                var name = this.comboBoxClient.Text;
                var client = new Customer();
                var clientRegister = new CustomerRegiser();

                client = clientRegister.SearchPersonByName(name);
                this.txtName.Text = client.Name;
                this.txtPhone.Text = client.Phone;
                this.txtCpf.Text = client.Cpf;
                this.txtStreet.Text = client.Street;
                this.txtNumber.Text =Convert.ToString( client.Number);
                this.txtCity.Text = client.City;
                this.txtState.Text = client.State;
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
            this.ListSalesmanName();
            this.ListCustomerName();
            this.ListSalesmanName();
        }

        private void BtnSearchVehicule_Click(object sender, EventArgs e)
        {
            if (this.ValedateIfComboBoxProductsIsEmpty() == true)
            {
                var name = (this.comboBoxProduct.Text);
                var car = new Car();
                var carRegister = new CarRegister();

                car = carRegister.SearchVehicleByName(name);
                this.idCar = car.id;
                this.txtCar.Text = car.name;
                this.txtYear.Text = car.year;
                this.txtModel.Text = car.model;
                this.txtPrice.Text = car.price;
                this.textoMarca.Text = car.mark;
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

        private bool ValedateIfComboBoxProductsIsEmpty()
        {
            if (this.comboBoxProduct.Text == "") { return false; } else { return true; }
        }

        private bool ValidateIfComboBoxClientIsEmpty()
        {
            if (this.comboBoxClient.Text == "") { return false; } else { return true; }
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
        }
    }
}


