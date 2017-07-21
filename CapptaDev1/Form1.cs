using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapptaDev1.Properties;
using System.IO;

namespace CapptaDev1
{
    public partial class Home : Form, Mensagens
    {
        public Home()
        {
            InitializeComponent();
        }

       // string quantidadeFinal;
        private string quantidadefinal;

        public int codigoPedido { get; set; }
        public string data { get; set; }
        public int clientesFk { get; set; }
        public int carroPopularFk { get; set; }
        public int funcionarioFk { get; set; }
        public string valor { get; set; }

        //metodo para atualizar dados
        public void atualizarDadosDoForm()
        {
            //atualizar nomes de vendedores 
            try
            {
                Vendedor vendedor = new Vendedor();
                comboBoxVendedor.DataSource = vendedor.Listar();
                comboBoxVendedor.DisplayMember = "nome";
                comboBoxVendedor.ValueMember = "nome";

            }
            catch (Exception)
            {

                throw;
            }

            //  atualizarr produtos cadastrados 
            try
            {
                CarroPopular carroPopular = new CarroPopular();
                comboBoxProduto.DataSource = carroPopular.listarCarro();
                comboBoxProduto.DisplayMember = "carro";
                comboBoxProduto.ValueMember = "carro";

            }
            catch (Exception)
            {

                throw;
            }

            // atualizar clientes cadastrados
            try
            {
                Cliente cliente = new Cliente();
                comboBoxCliente.DataSource = cliente.Listar();
                comboBoxCliente.DisplayMember = "nome";
                comboBoxCliente.ValueMember = "nome";
            }
            catch (Exception)
            {

                throw;
            }

            //atualizar grid do estoque
            try
            {



                CarroPopular carro = new CarroPopular();
                dgvEstoqueCarro.DataSource = carro.listarCarro();
                dgvEstoqueCarro.Update();
                dgvEstoqueCarro.Refresh();




            }
            catch (Exception)
            {

                throw;
            }

        }
        //metodo para salvar arquivos
        public void salvarArquivoPedidos()
        {
            FileStream fs = new FileStream(textoNome.Text, FileMode.Create);
            StreamWriter writer = new StreamWriter(fs);
            writer.WriteLine("Data:  " + dataTimeData.Text + "    ");
            writer.WriteLine("Vendedor:  " + comboBoxVendedor.Text + "    ");
            writer.WriteLine("============================================");
            writer.WriteLine("Sinal venda de Carros Nacionais e Importados");
            writer.WriteLine("========================================");
            writer.WriteLine("O Cliente de nome  :" + textoNome.Text + "     ");
            writer.WriteLine("***** ****** *****  ** **************  **** ");
            writer.WriteLine("Produto  :" + textoCarro.Text + "     ");
            writer.WriteLine("Modelo  :" + textoModelo.Text + "     ");
            writer.WriteLine("Ano  :" + textoAno.Text + "     ");
            writer.WriteLine("Preço:  :" + textoPreco.Text + "     ");
            writer.WriteLine("Marca  :" + textoMarca.Text);

            writer.WriteLine("Endereço  :" + textoRua.Text + "Número: " + textoNumero.Text);
            writer.WriteLine("Cidade  :" + textoCidade.Text + "     ");
            writer.WriteLine("Estado  :" + textoEstado.Text + "     ");
            writer.WriteLine("***** ****** *****  ** **************  **** ");
            writer.WriteLine("Fica fora deste acordo, o emplacamento e a documentação");
            writer.Close();
            fs.Close();

        }

        // mostar ou saida de arquivo
        public void mostrarArquivoPedidos()
        {
            if (File.Exists(textoNome.Text))
            {
                Stream mostrar = File.Open(textoNome.Text, FileMode.Open);
                StreamReader leitor = new StreamReader(mostrar);

                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    textoSaida.Text += $"{linha}\r\n";
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                mostrar.Close();
            }

        }
        private void Home_Load(object sender, EventArgs e)
        {
            BemVindo();
            // carregar nomes de vendedores ao iniciar a Sessão
            try
            {
                Vendedor vendedor = new Vendedor();
                comboBoxVendedor.DataSource = vendedor.Listar();
                comboBoxVendedor.DisplayMember = "nome";
                comboBoxVendedor.ValueMember = "nome";

                
                comboBoxCodigoVendedor.DataSource = vendedor.ListarPorNome(comboBoxVendedor.Text);
                comboBoxCodigoVendedor.DisplayMember = "codigo";
                comboBoxCodigoVendedor.ValueMember = "codigo";
                
            }
            catch (Exception)
            {

                throw;
            }

            //  metodo para carregar produtos cadastrados ao iniciar o Form
            try
            {
                CarroPopular carroPopular = new CarroPopular();
                comboBoxProduto.DataSource = carroPopular.listarCarro();
                comboBoxProduto.DisplayMember = "carro";
                comboBoxProduto.ValueMember = "carro";

                comboBoxCodigoCarro.DataSource = carroPopular.ListarCarroPorNome(comboBoxProduto.Text);
                comboBoxCodigoCarro.DisplayMember = "id";
                comboBoxCodigoCarro.ValueMember = "id";


            }
            catch (Exception)
            {

               throw;
            }

            //metodo para carregar os clientes cadastrados
            try
            {
                Cliente cliente = new Cliente();
                comboBoxCliente.DataSource = cliente.Listar();
                comboBoxCliente.DisplayMember = "nome";
                comboBoxCliente.ValueMember = "nome";

                comboBoxCodigoCliente.DataSource = cliente.ListarPorNome(comboBoxCliente.Text);
                comboBoxCodigoCliente.DisplayMember = "codigo";
                comboBoxCodigoCliente.ValueMember = "codigo";
            }
            catch (Exception)
            {

                throw;
            }

            //metodo para carregar grid com estoque
            try
            {



                CarroPopular carro = new CarroPopular();
                dgvEstoqueCarro.DataSource = carro.listarCarro();
                dgvEstoqueCarro.Update();
                dgvEstoqueCarro.Refresh();
              
                
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        //Registrar cliente
        private void botaoRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cliente = new Cliente();

                cliente.nome = Convert.ToString(textoNome.Text);
                cliente.telefone= Convert.ToString(textoTelefone.Text);
                cliente.cpf = Convert.ToString(textoCpf.Text);
                cliente.rua = Convert.ToString(textoRua.Text);
                cliente.numero = Convert.ToString(textoNumero.Text);
                cliente.cidade = Convert.ToString(textoCidade.Text);
                cliente.estado = Convert.ToString(textoEstado.Text);

                cliente.incluir(cliente);
                limparCampos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //buscar carro por nome
        private void botaoRegistraCarro_Click(object sender, EventArgs e)
        {

            try
            {
                string nome = comboBoxProduto.Text;

                CarroPopular car = new CarroPopular();
                CarroPopular carro = new CarroPopular();
                
                car = carro.pesquisarPorNome(nome);

                textoCarro.Text = car.carro;
                textoAno.Text = car.ano;
                textoModelo.Text = car.modelo;
                textoPreco.Text = car.preco;
                textoMarca.Text = car.marca;
                textoQuantidade.Text = car.quantidade;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //metodo para limpar
        private void limparCampos()
        {
            textoCarro.Text = "";
            textoAno.Text = "";
            textoCidade.Text = "";
            textoCpf.Text = "";
            textoEstado.Text = "";
            textoModelo.Text = "";
            textoNome.Text = "";
            textoNumero.Text = "";
            textoPreco.Text = "";
            textoRua.Text = "";
            textoTelefone.Text = "";
            textoQuantidade.Text = "";
            
        }


        // dar baixa no estoque
        private void retirarDoBanco()
        {
            try
            {
                string nome = (comboBoxProduto.Text);

            CarroPopular car = new CarroPopular();
            CarroPopular carro = new CarroPopular();

            car = carro.pesquisarPorNomeQuantidade(nome);
          
            int quantidadeAtual = Convert.ToInt32(car.quantidade);
             quantidadefinal =Convert.ToString( quantidadeAtual - 1);


           
                ConectaBanco cb = new ConectaBanco();
                cb.abrirConexao();
                String sql = "update carropopular set quantidade='" + quantidadefinal + "' where carro='" + comboBoxProduto.Text + "'";
                cb.comand = new MySql.Data.MySqlClient.MySqlCommand(sql, cb.sqlConection);

                int nu = cb.comand.ExecuteNonQuery();
                if (nu > 0)
                {
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Realizar pedidos
        private void botaoComfirmarPedido_Click(object sender, EventArgs e)
        {
            //chama o metodo para salvar os arquivos
            salvarArquivoPedidos();

            //chamada de metodo para mostrar arquivo guardado
            mostrarArquivoPedidos();

            Pedido pedido = new Pedido();

            pedido.data = Convert.ToString(dataTimeData.Text);
            pedido.clientesFk = Convert.ToInt32(comboBoxCodigoCliente.Text);
            pedido.carroPopularFk = Convert.ToInt32(comboBoxCodigoCarro.Text);
            pedido.funcionarioFk = Convert.ToInt32(comboBoxCodigoVendedor.Text);
            pedido.valor = textoPreco.Text;

             pedido.fazerpedido(pedido);
             retirarDoBanco();
            limparCampos();
        }
        // abre o form Funcionário
        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.ShowDialog();
        }
        // abre o form produtos
        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carros carros = new Carros();
            carros.ShowDialog();
        }
       //botao para pesquisar cliente
        private void botaoPesquisaCliente_Click(object sender, EventArgs e)
        {
            botaoRegistrarCliente.Visible = false;
            try
            {
                string nome = comboBoxCliente.Text;

                Cliente cliente = new Cliente();

                Cliente cli = new Cliente();
                cliente = cli.pesquisarPorNome(nome);

                textoNome.Text     = cliente.nome;
                textoTelefone.Text = cliente.telefone;
                textoCpf.Text      = cliente.cpf;
                textoRua.Text      = cliente.rua;
                textoNumero.Text   = cliente.numero;
                textoCidade.Text   = cliente.cidade;
                textoEstado.Text   = cliente.estado;
             
            }
            catch (Exception)
            {

                throw;
            }
        }
        // limpar
       private void botaoLimpar_Click(object sender, EventArgs e)
        {
             limparCampos();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void botaoAtualizarTabela_Click(object sender, EventArgs e)
        {
            // chamando metodo para atualizar dados
            atualizarDadosDoForm();
            //limpa os campos
            limparCampos();
            // mostra o botão registrar cliente
            botaoRegistrarCliente.Visible = true;
           
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Relatorios re = new Relatorios();
            re.ShowDialog();
        }

        

        private void comboBoxVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            comboBoxCodigoVendedor.DataSource = vendedor.ListarPorNome(comboBoxVendedor.Text);
            comboBoxCodigoVendedor.DisplayMember = "codigo";
            comboBoxCodigoVendedor.ValueMember = "codigo";

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            

            comboBoxCodigoCliente.DataSource = cliente.ListarPorNome(comboBoxCliente.Text);
            comboBoxCodigoCliente.DisplayMember = "codigo";
            comboBoxCodigoCliente.ValueMember = "codigo";
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CarroPopular carroPopular = new CarroPopular();


                comboBoxCodigoCarro.DataSource = carroPopular.ListarCarroPorNome(comboBoxProduto.Text);
                comboBoxCodigoCarro.DisplayMember = "id";
                comboBoxCodigoCarro.ValueMember = "id";

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void botaoBuscarArquivoPedidos_Click(object sender, EventArgs e)
        {
            textoSaida.Text = "";
            if (File.Exists(textoBuscarArquivo.Text))
            {
                Stream mostrar = File.Open(textoBuscarArquivo.Text, FileMode.Open);
                StreamReader leitor = new StreamReader(mostrar);

                string linha = leitor.ReadLine();
                while (linha != null)
                {
                    textoSaida.Text += $"{linha}\r\n";
                    linha = leitor.ReadLine();
                }
                leitor.Close();
                mostrar.Close();
            }

        }

        public void BemVindo()
        {
            MessageBox.Show("Seja bem vindo a sua Dashboard, qualquer dúvida contate o suporte");
        }
    }
}
