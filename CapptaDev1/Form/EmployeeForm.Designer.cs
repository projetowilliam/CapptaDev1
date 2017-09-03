namespace SinalVeiculos
{
    partial class EmployeeForm
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
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textoEstado = new System.Windows.Forms.TextBox();
            this.textoCidade = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoRua = new System.Windows.Forms.TextBox();
            this.textoCpf = new System.Windows.Forms.TextBox();
            this.textoTelefone = new System.Windows.Forms.TextBox();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoPesquisa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnSearcheEmployeer = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearcheEmployeer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.BtnSearcheEmployeer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textoPesquisa);
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 440);
            this.panel1.TabIndex = 0;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(531, 378);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(124, 34);
            this.botaoCancelar.TabIndex = 5;
            this.botaoCancelar.Text = "Sair";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(4, 378);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(124, 34);
            this.botaoSalvar.TabIndex = 3;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.BotaoSave_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.textoEstado);
            this.panel3.Controls.Add(this.textoCidade);
            this.panel3.Controls.Add(this.textoNumero);
            this.panel3.Controls.Add(this.textoRua);
            this.panel3.Controls.Add(this.textoCpf);
            this.panel3.Controls.Add(this.textoTelefone);
            this.panel3.Controls.Add(this.textoNome);
            this.panel3.Location = new System.Drawing.Point(139, 64);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(530, 291);
            this.panel3.TabIndex = 2;
            // 
            // textoEstado
            // 
            this.textoEstado.Location = new System.Drawing.Point(19, 233);
            this.textoEstado.Name = "textoEstado";
            this.textoEstado.Size = new System.Drawing.Size(251, 26);
            this.textoEstado.TabIndex = 6;
            // 
            // textoCidade
            // 
            this.textoCidade.Location = new System.Drawing.Point(19, 198);
            this.textoCidade.Name = "textoCidade";
            this.textoCidade.Size = new System.Drawing.Size(355, 26);
            this.textoCidade.TabIndex = 5;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(19, 165);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(109, 26);
            this.textoNumero.TabIndex = 4;
            // 
            // textoRua
            // 
            this.textoRua.Location = new System.Drawing.Point(19, 129);
            this.textoRua.Name = "textoRua";
            this.textoRua.Size = new System.Drawing.Size(504, 26);
            this.textoRua.TabIndex = 3;
            // 
            // textoCpf
            // 
            this.textoCpf.Location = new System.Drawing.Point(19, 90);
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(251, 26);
            this.textoCpf.TabIndex = 2;
            // 
            // textoTelefone
            // 
            this.textoTelefone.Location = new System.Drawing.Point(19, 51);
            this.textoTelefone.Name = "textoTelefone";
            this.textoTelefone.Size = new System.Drawing.Size(251, 26);
            this.textoTelefone.TabIndex = 1;
            // 
            // textoNome
            // 
            this.textoNome.Location = new System.Drawing.Point(19, 13);
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(504, 26);
            this.textoNome.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(116, 291);
            this.panel2.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 230);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rua";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // textoPesquisa
            // 
            this.textoPesquisa.Location = new System.Drawing.Point(139, 10);
            this.textoPesquisa.Name = "textoPesquisa";
            this.textoPesquisa.Size = new System.Drawing.Size(370, 26);
            this.textoPesquisa.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pesquisa:";
            // 
            // BtnSearcheEmployeer
            // 
            this.BtnSearcheEmployeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnSearcheEmployeer.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.BtnSearcheEmployeer.Location = new System.Drawing.Point(515, 5);
            this.BtnSearcheEmployeer.Name = "BtnSearcheEmployeer";
            this.BtnSearcheEmployeer.Size = new System.Drawing.Size(43, 31);
            this.BtnSearcheEmployeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSearcheEmployeer.TabIndex = 28;
            this.BtnSearcheEmployeer.TabStop = false;
            this.BtnSearcheEmployeer.Click += new System.EventHandler(this.BtnSearcheEmployeer_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 440);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearcheEmployeer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoSalvar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textoEstado;
        private System.Windows.Forms.TextBox textoCidade;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoRua;
        private System.Windows.Forms.TextBox textoCpf;
        private System.Windows.Forms.TextBox textoTelefone;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textoPesquisa;
        private System.Windows.Forms.PictureBox BtnSearcheEmployeer;
    }
}