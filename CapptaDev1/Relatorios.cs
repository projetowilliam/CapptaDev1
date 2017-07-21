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
    public partial class Relatorios : Form, Mensagens
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
            Cliente cliente = new Cliente();
            dgvCliente.DataSource = cliente.Listar();
            dgvCliente.Refresh();
            dgvCliente.Update();

        }

        // metodo para carregar dados de funcionarios
        private void carregarVisualizacaoPrimariaFuncionarios()
        {
            Vendedor vendedor = new Vendedor();
            dgvFuncionario.DataSource = vendedor.Listar();
            dgvFuncionario.Refresh();
            dgvFuncionario.Update();
        }


        //metodo para carregar dados de produtos
        private void carregarVisualizacaoPrimariaProdutos()
        {
            CarroPopular carroPopular = new CarroPopular();
            dgvProdutos.DataSource = carroPopular.listarCarro();
            dgvProdutos.Update();
            dgvProdutos.Refresh();
        }


        //metodo para carregar dados de vendas
        private void carregarVisualizacaoprimariaVendas()
        {
            Pedido pedido = new Pedido();
            dgvVendas.DataSource = pedido.listar();
            dgvVendas.Update();
            dgvVendas.Refresh();
        }


        //pesquisar cliente por nome ou por código
        private void pictureBoxPesquisaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textoPesquisaCliente.Text;
                Cliente cliente = new Cliente();
                dgvCliente.DataSource = cliente.ListarPorNome(nome);
                dgvCliente.Refresh();
                dgvCliente.Update();


            }
            catch (Exception mensagem)
            {

                throw new Exception("Não foi possivel encontrar na base", mensagem);
            }

        }



        // pesquisa funcionario por nome
        private void pictureBoxPesquisaFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = textBoxPesquisaNomeFuncionario.Text;
                Vendedor vendedor = new Vendedor();
                dgvFuncionario.DataSource = vendedor.ListarPorNome(nome);
                dgvFuncionario.Refresh();
                dgvFuncionario.Update();


            }
            catch (Exception mensagem)
            {

                throw new Exception("Não foi possivel encontrar na base", mensagem);
            }

        }


        private void pictureBoxPesquisaProduto_Click(object sender, EventArgs e)
        {
            CarroPopular carroPopular = new CarroPopular();
            string nome = textBoxPesquisaPorNomeProduto.Text;
            dgvProdutos.DataSource = carroPopular.ListarCarroPorNome(nome);
            dgvProdutos.Update();
            dgvProdutos.Refresh();

        }

        private void Relatorios_Load(object sender, EventArgs e)
        {
            BemVindo();
            carregarDadosPrimariosClientes();
            carregarVisualizacaoPrimariaFuncionarios();
            carregarVisualizacaoPrimariaProdutos();
            listarGridPorCliente();
            listarGridPorVendedor();
        }

        // atualizar dados
        private void botaoParaAtualizarDados_Click(object sender, EventArgs e)
        {

            carregarDadosPrimariosClientes();
            carregarVisualizacaoPrimariaFuncionarios();
            carregarVisualizacaoPrimariaProdutos();
            listarGridPorVendedor();
            listarGridPorCliente();
            dgvVendaValorPedido.Visible = false;
            dgvVendasData.Visible = false;




        }

        private void pictureBoxPesquisaVenda_Click(object sender, EventArgs e)
        {

            try
            {
                dgvVendaVendedores.Visible = true;
                ConectaBanco conectaBanco = new ConectaBanco();

                conectaBanco.abrirConexao();
                //select nome, cpf, telefone, rua, numero, cidade, estado  from clientes
                //inner join pedidos codigo  on codigo = clientesFk where data = 'sexta-feira, 21 de julho de 2017';

                dt = new DataTable();
                conectaBanco.dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter("select nome, cpf, telefone, rua, numero, cidade, estado  from clientes inner join pedidos   on codigo = clientesFk where  data like'" + dataVenda.Text + "%'", conectaBanco.sqlConection);
                conectaBanco.dataAdapter.Fill(dt);
                dgvVendaVendedores.DataSource = dt;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
            //------------------------
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();
                dgvVendaValorPedido.Visible = true;
                conectaBanco.abrirConexao();
               // select carro, ano, modelo, valor from carropopular
               //inner join pedidos on id = carroPopularFk where data = 'sexta-feira, 21 de julho de 2017' ;


                dt = new DataTable();
                conectaBanco.dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter("select carro, ano, modelo, valor from carropopular inner join pedidos on id = carroPopularFk where  data like'" + dataVenda.Text + "%'", conectaBanco.sqlConection);
                conectaBanco.dataAdapter.Fill(dt);
                dgvVendaValorPedido.DataSource = dt;

            }
            catch (Exception)
            {

                throw;
            }


        }
        // metodo para listar na Grid utilizando filtro para as tabelas
        private void listarGridPorCliente()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();

                conectaBanco.abrirConexao();


                dt = new DataTable();
                conectaBanco.dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter("select clientes.nome, pedidos.codigoPedido, pedidos.data, pedidos.valor  from pedidos inner join clientes on pedidos.clientesFk= clientes.codigo", conectaBanco.sqlConection);
                conectaBanco.dataAdapter.Fill(dt);
                dgvVendas.DataSource = dt;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }


        }

        private void listarGridPorVendedor()
        {
            try
            {
                ConectaBanco conectaBanco = new ConectaBanco();

                conectaBanco.abrirConexao();


                dt = new DataTable();
                conectaBanco.dataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter("select funcionario.nome, pedidos.codigoPedido, pedidos.data, pedidos.valor  from pedidos inner join funcionario on pedidos.funcionarioFk= funcionario.codigo", conectaBanco.sqlConection);
                conectaBanco.dataAdapter.Fill(dt);
                dgvVendaVendedores.DataSource = dt;


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }

        }

        public void BemVindo()
        {
            MessageBox.Show("Esta parte esta destinada a apresentar pequenos resumos de suas transações, bem como seus clientes e funcionários");
        }
    }
}