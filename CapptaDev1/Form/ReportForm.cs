using CapptaDev1.Dados;
using CapptaDev1.Dados.Pessoas;
using CapptaDev1.Data;
using CapptaDev1.Modelos;
using CapptaDev1.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapptaDev1
{
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        protected DataTable dt;

        protected DataSet ds;
        protected BindingSource bs;

        //metodo para carregar dados de clientes
        private void carregarDadosPrimariosClientes()
        {
            var listarRegistro = new ClientRegister();
            dgvCliente.DataSource = listarRegistro.personList();
            dgvCliente.Refresh();
            dgvCliente.Update();

        }

        // metodo para carregar dados de funcionarios
        private void carregarVisualizacaoPrimariaFuncionarios()
        {
            var listarRegistro = new SalesRegister();
            dgvFuncionario.DataSource = listarRegistro.personList();
            dgvFuncionario.Refresh();
            dgvFuncionario.Update();
        }


        //metodo para carregar dados de produtos
        private void carregarVisualizacaoPrimariaProdutos()
        {
            var car = new CarRegister();
            dgvProdutos.DataSource = car.vehiculeList();
            dgvProdutos.Update();
            dgvProdutos.Refresh();
        }


        //metodo para carregar dados de vendas
        private void carregarVisualizacaoprimariaVendas()
        {
            var listarPedido = new RequestRegister();
            dgvVenda.DataSource = listarPedido.requestList();
            dgvVenda.Update();
            dgvVenda.Refresh();
        }


        //pesquisar cliente por nome ou por código
        private void pictureBoxPesquisaCliente_Click(object sender, EventArgs e)
        {
           
                string nome = textoPesquisaCliente.Text;
                var listarRegistro = new ClientRegister();
                dgvCliente.DataSource = listarRegistro.nameListPerson(nome);
                dgvCliente.Refresh();
                dgvCliente.Update();
        }



        // pesquisa funcionario por nome
        private void pictureBoxPesquisaFuncionario_Click(object sender, EventArgs e)
        {
                string nome = textBoxPesquisaNomeFuncionario.Text;
                var listarpessoa = new SalesRegister();
                dgvFuncionario.DataSource = listarpessoa.nameListPerson(nome);
                dgvFuncionario.Refresh();
                dgvFuncionario.Update();
        }

        private void pictureBoxPesquisaProduto_Click(object sender, EventArgs e)
        {
            var listarCarRegister = new CarRegister();
            string nome = textBoxPesquisaPorNomeProduto.Text;
            dgvProdutos.DataSource = listarCarRegister.nameVehiculeList(nome);
            dgvProdutos.Update();
            dgvProdutos.Refresh();
        }

        private void Relatorios_Load(object sender, EventArgs e)
        {

            carregarDadosPrimariosClientes();
            carregarVisualizacaoPrimariaFuncionarios();
            carregarVisualizacaoPrimariaProdutos();
            carregarVisualizacaoprimariaVendas();
          
        }

        private void botaoParaAtualizarDados_Click(object sender, EventArgs e)
        {
            carregarDadosPrimariosClientes();
            carregarVisualizacaoPrimariaFuncionarios();
            carregarVisualizacaoPrimariaProdutos();
        }
       
        private void pictureBoxPesquisaVenda_Click(object sender, EventArgs e)
        {
            var listarPedidos = new RequestRegister();
            dgvVenda.DataSource = listarPedidos.dateRequestList(dataVenda.Text);
        }
       
        public void BemVindo()
        {
            MessageBox.Show("Esta parte esta destinada a apresentar pequenos resumos de suas transações, bem como seus clientes e funcionários");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}