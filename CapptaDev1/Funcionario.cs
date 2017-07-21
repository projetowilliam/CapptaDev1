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
    public partial class Funcionario : Form
    {
        public Funcionario()
        {
            InitializeComponent();
        }
        // metodo para limpar campos
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

        //botao para limpar campos
        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        // salvar funcionario
        private void botaoSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Vendedor vendedor = new Vendedor();
                vendedor.nome = Convert.ToString(textoNome.Text);
                vendedor.telefone= Convert.ToString(textoTelefone.Text);
                vendedor.cpf = Convert.ToString(textoCpf.Text);
                vendedor.rua = Convert.ToString(textoRua.Text);
                vendedor.numero = Convert.ToString(textoNumero.Text);
                vendedor.cidade = Convert.ToString(textoCidade.Text);
                vendedor.estado = Convert.ToString(textoEstado.Text);

                vendedor.incluir(vendedor);

                limparCampos();
                

            }
            catch (Exception)
            {

                throw;
            }
        }

        // botão para cancelar inclusão de funcionário e fechar Form Funcionário
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
