﻿
using SinalVeiculos.Models;
using SinalVeiculos.Register;
using System;
using System.Windows.Forms;

namespace SinalVeiculos
{
    public partial class StockForm : Form
    {
        public StockForm()
        {
            InitializeComponent();
        }

        private void BtnFieldClean_Click(object sender, EventArgs e)
        {
            FieldClean();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInputFieldStock() == true)
            {
                var carRegister = new CarRegister();
                var car = new Car
                {
                    Name = txtName.Text,
                    Model = txtModel.Text,
                    Year = txtYear.Text,
                    Price = txtPrice.Text,
                    Brand = txtBrand.Text
                };
                carRegister.Quantity = Convert.ToInt32(txtQuantity.Text);
                carRegister.Add(car);
                FieldClean();
            }
            else
            {
                MessageBox.Show("Certifique-se que todos os campos estão preenchidos");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                var carRegister = new CarRegister();
                var car = new Car();
                car = carRegister.SearchVehicleByName(txtSearch.Text);
                if (carRegister != null)
                {
                    txtId.Text = Convert.ToString(car.Id);
                    txtName.Text = car.Name;
                    txtYear.Text = car.Year;
                    txtModel.Text = car.Model;
                    txtPrice.Text = car.Price;
                    txtBrand.Text = car.Brand;
                    txtQuantity.Text = Convert.ToString(carRegister.Quantity);
                }
                else
                {
                    MessageBox.Show("Selecione um nome para pesquisa");
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FieldClean()
        {
            txtName.Text = string.Empty;
            txtYear.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtBrand.Text = string.Empty;
        }

        private bool ValidateInputFieldStock()
        {
            if (txtBrand.Text == string.Empty || txtModel.Text == string.Empty || txtName.Text == string.Empty
                || txtPrice.Text == string.Empty || txtQuantity.Text == string.Empty || txtYear.Text == string.Empty)
            { return false; }
            else { return true; }
        }
    }
}


