using CapptaDev1.Dados;
using CapptaDev1.Dados.Pessoas;
using CapptaDev1.Data;
using CapptaDev1.Modelos;
using CapptaDev1.Models;
using CapptaDev1.Models.CapptaDev1.Modelos;
using CapptaDev1.Register;
using System;
using System.IO;
using System.Windows.Forms;

namespace CapptaDev1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        public void atualizarDadosDoForm()
        {
            /* var novoRegistro = new PeopleRegister();
             comboBoxVendedor.DataSource = novoRegistro.peopleList();
             comboBoxVendedor.DisplayMember = "name";
             comboBoxVendedor.ValueMember = "name";

             var stock = new VehicleRegister();
             comboBoxProduto.DataSource = stock.vehiculeList();
             comboBoxProduto.DisplayMember = "name";
             comboBoxProduto.ValueMember = "name";

             comboBoxCliente.DataSource = novoRegistro.peopleList();
             comboBoxCliente.DisplayMember = "name";
             comboBoxCliente.ValueMember = "name";


             dgvEstoqueVeiculos.DataSource = stock.vehiculeList();
             dgvEstoqueVeiculos.Update();
             dgvEstoqueVeiculos.Refresh();*/
        }

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
        public void listarpessoa()
        {

        }
        private void Home_Load(object sender, EventArgs e)
        {/*
            var registro = new PeopleRegister("funcionario");
            var stock = new VehicleRegister();
            comboBoxVendedor.DataSource = registro.peopleList();
            comboBoxVendedor.DisplayMember = "name";
            comboBoxVendedor.ValueMember = "name";

            comboBoxCodigoVendedor.DataSource = registro.nameListPeople(comboBoxVendedor.Text, "funcionario");
            comboBoxCodigoVendedor.DisplayMember = "code";
            comboBoxCodigoVendedor.ValueMember = "code";

            comboBoxProduto.DataSource = stock.vehiculeList();
            dgvEstoqueVeiculos.DataSource = stock.vehiculeList();
            comboBoxProduto.DisplayMember = "name";
            comboBoxProduto.ValueMember = "name";

            comboBoxCodigoCarro.DataSource = stock.nameVehiculeList(comboBoxProduto.Text);
            comboBoxCodigoCarro.DisplayMember = "id";
            comboBoxCodigoCarro.ValueMember = "id";

         
            comboBoxCliente.DataSource = registro.peopleList("clientes");
            comboBoxCliente.DisplayMember = "name";
            comboBoxCliente.ValueMember = "name";

            comboBoxCodigoCliente.DataSource = registro.nameListPeople(comboBoxCliente.Text, "clientes");
            comboBoxCodigoCliente.DisplayMember = "code";
            comboBoxCodigoCliente.ValueMember = "code";
            
            */

        }

        private void botaoRegistrarCliente_Click(object sender, EventArgs e)
        {
            var clientRegister = new ClientRegister();
            var client = new Client();
            client.name = textoNome.Text;
            client.phone = textoTelefone.Text;
            client.cpf = textoCpf.Text;
            client.street = textoRua.Text;
            client.number = textoNumero.Text;
            client.city = textoCidade.Text;
            client.state = textoEstado.Text;
            clientRegister.personAdd(client);
            limparCampos();
        }

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

        private void botaoComfirmarPedido_Click(object sender, EventArgs e)
        {
            //chama o metodo para salvar os arquivos
            salvarArquivoPedidos();
            //chamada de metodo para mostrar arquivo guardado
            mostrarArquivoPedidos();

            var request = new Request();
            var newRequest = new RequestRegister();
            request.date = Convert.ToString(dataTimeData.Text);
            request.clientFk = Convert.ToInt32(comboBoxCodigoCliente.Text);
            request.vehiculeFk = Convert.ToInt32(comboBoxCodigoCarro.Text);
            request.employee = Convert.ToInt32(comboBoxCodigoVendedor.Text);
            request.value = textoPreco.Text;

            int quantidadeEscolhida = Convert.ToInt32(textoQuantidade.Text) - Convert.ToInt32(textoQuantidadeEscolhida.Text);
            newRequest.requestMaker(request);
            newRequest.updateRequestEntry(textoCarro.Text, quantidadeEscolhida);
            // retirarDoBanco();
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
            Estoque estoque = new Estoque();
            estoque.ShowDialog();
        }
        //botao para pesquisar cliente
        private void botaoPesquisaCliente_Click(object sender, EventArgs e)
        {
            botaoRegistrarCliente.Visible = false;
            string nome = comboBoxCliente.Text;
            var client = new Client();
            var clientRegister = new ClientRegister();
            client = clientRegister.nameSearchPeople(nome);
            textoNome.Text = client.name;
            textoTelefone.Text = client.phone;
            textoCpf.Text = client.cpf;
            textoRua.Text = client.street;
            textoNumero.Text = client.number;
            textoCidade.Text = client.city;
            textoEstado.Text = client.state;

        }

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
            var listaRegistro = new SalesRegister();
            comboBoxCodigoVendedor.DataSource = listaRegistro.nameListPerson(comboBoxVendedor.Text);
            comboBoxCodigoVendedor.DisplayMember = "code";
            comboBoxCodigoVendedor.ValueMember = "code";
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listarRegistro = new ClientRegister();
            comboBoxCodigoCliente.DataSource = listarRegistro.nameListPerson(comboBoxCliente.Text);
            comboBoxCodigoCliente.DisplayMember = "code";
            comboBoxCodigoCliente.ValueMember = "code";
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listarStock = new CarRegister();
            comboBoxCodigoCarro.DataSource = listarStock.nameVehiculeList(comboBoxProduto.Text);
            comboBoxCodigoCarro.DisplayMember = "id";
            comboBoxCodigoCarro.ValueMember = "id";
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

        private void comboBoxVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listarStock = new CarRegister();
            comboBoxProduto.DataSource = listarStock.vehiculeList();
            comboBoxProduto.DisplayMember = "carro";
            comboBoxProduto.ValueMember = "carro";

            comboBoxCodigoCarro.DataSource = listarStock.nameVehiculeList(comboBoxProduto.Text);
            comboBoxCodigoCarro.DisplayMember = "id";
            comboBoxCodigoCarro.ValueMember = "id";

            dgvEstoqueVeiculos.DataSource = listarStock.vehiculeList();
            dgvEstoqueVeiculos.Update();
            dgvEstoqueVeiculos.Refresh();
        }

        private void pictureBoxBuscarVeiculo_Click(object sender, EventArgs e)
        {
            string nome = comboBoxProduto.Text;
            var car = new Car();
            var carRegister = new CarRegister();
            car = carRegister.nameVehiculeSearch(nome);
            textoCarro.Text = car.name;
            textoAno.Text = car.year;
            textoModelo.Text = car.model;
            textoPreco.Text = car.price;
            textoMarca.Text = car.mark;
            textoQuantidade.Text = carRegister.quantity;
        }
    }
}
