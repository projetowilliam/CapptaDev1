namespace CapptaDev1
{
    partial class Carros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.textoQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxBotaoPesquisar = new System.Windows.Forms.PictureBox();
            this.textoNomePesquisa = new System.Windows.Forms.TextBox();
            this.botaoAlterar = new System.Windows.Forms.Button();
            this.botaoLimpar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.textoMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoPreco = new System.Windows.Forms.TextBox();
            this.textoAno = new System.Windows.Forms.TextBox();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.textoCarro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotaoPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.botaoNovo);
            this.panel1.Controls.Add(this.textoQuantidade);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBoxBotaoPesquisar);
            this.panel1.Controls.Add(this.textoNomePesquisa);
            this.panel1.Controls.Add(this.botaoAlterar);
            this.panel1.Controls.Add(this.botaoLimpar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Controls.Add(this.textoMarca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textoPreco);
            this.panel1.Controls.Add(this.textoAno);
            this.panel1.Controls.Add(this.textoModelo);
            this.panel1.Controls.Add(this.textoCarro);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 472);
            this.panel1.TabIndex = 0;
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(27, 419);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(85, 32);
            this.botaoNovo.TabIndex = 42;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Location = new System.Drawing.Point(117, 327);
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(120, 26);
            this.textoQuantidade.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Código";
            // 
            // pictureBoxBotaoPesquisar
            // 
            this.pictureBoxBotaoPesquisar.Image = global::CapptaDev1.Properties.Resources.if_search_173095;
            this.pictureBoxBotaoPesquisar.Location = new System.Drawing.Point(324, 14);
            this.pictureBoxBotaoPesquisar.Name = "pictureBoxBotaoPesquisar";
            this.pictureBoxBotaoPesquisar.Size = new System.Drawing.Size(51, 27);
            this.pictureBoxBotaoPesquisar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBotaoPesquisar.TabIndex = 39;
            this.pictureBoxBotaoPesquisar.TabStop = false;
            this.pictureBoxBotaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // textoNomePesquisa
            // 
            this.textoNomePesquisa.Location = new System.Drawing.Point(95, 14);
            this.textoNomePesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.textoNomePesquisa.Name = "textoNomePesquisa";
            this.textoNomePesquisa.Size = new System.Drawing.Size(228, 26);
            this.textoNomePesquisa.TabIndex = 38;
            // 
            // botaoAlterar
            // 
            this.botaoAlterar.Location = new System.Drawing.Point(301, 420);
            this.botaoAlterar.Name = "botaoAlterar";
            this.botaoAlterar.Size = new System.Drawing.Size(91, 32);
            this.botaoAlterar.TabIndex = 37;
            this.botaoAlterar.Text = "Alterar";
            this.botaoAlterar.UseVisualStyleBackColor = true;
            this.botaoAlterar.Visible = false;
            this.botaoAlterar.Click += new System.EventHandler(this.botaoAlterar_Click);
            // 
            // botaoLimpar
            // 
            this.botaoLimpar.Location = new System.Drawing.Point(210, 420);
            this.botaoLimpar.Name = "botaoLimpar";
            this.botaoLimpar.Size = new System.Drawing.Size(85, 32);
            this.botaoLimpar.TabIndex = 35;
            this.botaoLimpar.Text = "Limpar";
            this.botaoLimpar.UseVisualStyleBackColor = true;
            this.botaoLimpar.Click += new System.EventHandler(this.botaoLimpar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(119, 419);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(85, 32);
            this.botaoSalvar.TabIndex = 34;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Visible = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // textoMarca
            // 
            this.textoMarca.Location = new System.Drawing.Point(116, 372);
            this.textoMarca.Margin = new System.Windows.Forms.Padding(4);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(151, 26);
            this.textoMarca.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 381);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "Quantidade";
            // 
            // textoPreco
            // 
            this.textoPreco.Location = new System.Drawing.Point(117, 262);
            this.textoPreco.Margin = new System.Windows.Forms.Padding(4);
            this.textoPreco.Name = "textoPreco";
            this.textoPreco.Size = new System.Drawing.Size(151, 26);
            this.textoPreco.TabIndex = 29;
            // 
            // textoAno
            // 
            this.textoAno.Location = new System.Drawing.Point(117, 143);
            this.textoAno.Margin = new System.Windows.Forms.Padding(4);
            this.textoAno.Name = "textoAno";
            this.textoAno.Size = new System.Drawing.Size(115, 26);
            this.textoAno.TabIndex = 28;
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(117, 201);
            this.textoModelo.Margin = new System.Windows.Forms.Padding(4);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(259, 26);
            this.textoModelo.TabIndex = 27;
            // 
            // textoCarro
            // 
            this.textoCarro.Location = new System.Drawing.Point(117, 96);
            this.textoCarro.Margin = new System.Windows.Forms.Padding(4);
            this.textoCarro.Name = "textoCarro";
            this.textoCarro.Size = new System.Drawing.Size(259, 26);
            this.textoCarro.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 25;
            this.label9.Text = "Ano";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 210);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 24;
            this.label10.Text = "Modelo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 271);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Preço";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 100);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Carro";
            // 
            // Carros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 472);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Carros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carros";
            this.Load += new System.EventHandler(this.Carros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textoQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBotaoPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoAlterar;
        private System.Windows.Forms.Button botaoLimpar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.TextBox textoMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textoPreco;
        private System.Windows.Forms.TextBox textoAno;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.TextBox textoCarro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textoNomePesquisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxBotaoPesquisar;
        private System.Windows.Forms.NumericUpDown textoQuantidade;
        private System.Windows.Forms.Button botaoNovo;
    }
}