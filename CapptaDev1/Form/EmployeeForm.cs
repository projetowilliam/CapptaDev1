using CapptaDev1.Data;
using CapptaDev1.Models;
using System;
using System.Windows.Forms;
namespace CapptaDev1
{
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }

        public void limparCampos()
        {
            textoCidade.Text = "";
            textoCpf.Text = "";
            textoEstado.Text = "";
            textoNome.Text = "";
            textoNumero.Text = "";
            textoRua.Text = "";
            textoTelefone.Text = "";
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void botaoSalvar_Click(object sender, EventArgs e)
        {         
            var salesRegister = new SalesRegister();
            var employePerson = new Employee();
            employePerson.name = Convert.ToString(textoNome.Text);
            employePerson.phone = Convert.ToString(textoTelefone.Text);
            employePerson.cpf = Convert.ToString(textoCpf.Text);
            employePerson.street = Convert.ToString(textoRua.Text);
            employePerson.number = Convert.ToString(textoNumero.Text);
            employePerson.city = Convert.ToString(textoCidade.Text);
            employePerson.state = Convert.ToString(textoEstado.Text);
            salesRegister.personAdd(employePerson);
            limparCampos();
        }

        // botão para cancelar inclusão de funcionário e fechar Form Funcionário
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
