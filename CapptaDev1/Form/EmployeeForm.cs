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

        private void BotaoSave_Click(object sender, EventArgs e)
        {         
            var employeerRegister = new EmployeerRegister();
            var employee = new Employee();
            employee.Name = Convert.ToString(textoNome.Text);
            employee.Phone = Convert.ToString(textoTelefone.Text);
            employee.Cpf = Convert.ToString(textoCpf.Text);
            employee.Street = Convert.ToString(textoRua.Text);
            employee.Number = Convert.ToString(textoNumero.Text);
            employee.City = Convert.ToString(textoCidade.Text);
            employee.State = Convert.ToString(textoEstado.Text);
            employeerRegister.Add(employee);
            FieldClean();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
        public void FieldClean()
        {
            textoCidade.Text = string.Empty;
            textoCpf.Text = string.Empty;
            textoEstado.Text = string.Empty;
            textoNome.Text = string.Empty;
            textoNumero.Text = string.Empty;
            textoRua.Text = string.Empty;
            textoTelefone.Text = string.Empty;
        }

        private void BtnSearcheEmployeer_Click(object sender, EventArgs e)
        {
            var employeerRegister = new EmployeerRegister();
            var employee = new Employee();
            var name = textoPesquisa.Text;

            employee = employeerRegister.SearchPersonByName(name);
            textoNome.Text = employee.Name;
            textoCidade.Text = employee.City;
            textoCpf.Text = employee.Cpf;
            textoEstado.Text = employee.State;
            textoNumero.Text = employee.Number;
            textoRua.Text = employee.Street;
            textoTelefone.Text = employee.Phone;
        }
    }
}
