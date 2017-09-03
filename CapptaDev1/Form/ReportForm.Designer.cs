namespace SinalVeiculos
{
    partial class ReportForm
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
            this.comboBoxVeiculos = new System.Windows.Forms.ComboBox();
            this.botaoParaAtualizarDados = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textoPesquisaCliente = new System.Windows.Forms.TextBox();
            this.pictureBoxPesquisaCliente = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dgvFuncionario = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaNomeFuncionario = new System.Windows.Forms.TextBox();
            this.pictureBoxPesquisaFuncionario = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBoxPesquisaPorNomeProduto = new System.Windows.Forms.TextBox();
            this.pictureBoxPesquisaProduto = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.panel12 = new System.Windows.Forms.Panel();
            this.dataVenda = new System.Windows.Forms.DateTimePicker();
            this.pictureBoxPesquisaVenda = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaCliente)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaProduto)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBoxVeiculos);
            this.panel1.Controls.Add(this.botaoParaAtualizarDados);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(673, 490);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBoxVeiculos
            // 
            this.comboBoxVeiculos.FormattingEnabled = true;
            this.comboBoxVeiculos.Location = new System.Drawing.Point(238, 6);
            this.comboBoxVeiculos.Name = "comboBoxVeiculos";
            this.comboBoxVeiculos.Size = new System.Drawing.Size(283, 21);
            this.comboBoxVeiculos.TabIndex = 5;
            // 
            // botaoParaAtualizarDados
            // 
            this.botaoParaAtualizarDados.Location = new System.Drawing.Point(534, 3);
            this.botaoParaAtualizarDados.Name = "botaoParaAtualizarDados";
            this.botaoParaAtualizarDados.Size = new System.Drawing.Size(106, 23);
            this.botaoParaAtualizarDados.TabIndex = 4;
            this.botaoParaAtualizarDados.Text = "Atualizar";
            this.botaoParaAtualizarDados.UseVisualStyleBackColor = true;
            this.botaoParaAtualizarDados.Click += new System.EventHandler(this.botaoParaAtualizarDados_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(668, 674);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvCliente);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(660, 648);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(6, 78);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(651, 348);
            this.dgvCliente.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textoPesquisaCliente);
            this.panel2.Controls.Add(this.pictureBoxPesquisaCliente);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 45);
            this.panel2.TabIndex = 0;
            // 
            // textoPesquisaCliente
            // 
            this.textoPesquisaCliente.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoPesquisaCliente.Location = new System.Drawing.Point(74, 8);
            this.textoPesquisaCliente.Name = "textoPesquisaCliente";
            this.textoPesquisaCliente.Size = new System.Drawing.Size(461, 26);
            this.textoPesquisaCliente.TabIndex = 1;
            // 
            // pictureBoxPesquisaCliente
            // 
            this.pictureBoxPesquisaCliente.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.pictureBoxPesquisaCliente.Location = new System.Drawing.Point(538, 8);
            this.pictureBoxPesquisaCliente.Name = "pictureBoxPesquisaCliente";
            this.pictureBoxPesquisaCliente.Size = new System.Drawing.Size(51, 26);
            this.pictureBoxPesquisaCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesquisaCliente.TabIndex = 0;
            this.pictureBoxPesquisaCliente.TabStop = false;
            this.pictureBoxPesquisaCliente.Click += new System.EventHandler(this.pictureBoxPesquisaCliente_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(660, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funcionários";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(654, 642);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(650, 638);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.dgvFuncionario);
            this.panel7.Location = new System.Drawing.Point(3, 61);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(719, 356);
            this.panel7.TabIndex = 5;
            // 
            // dgvFuncionario
            // 
            this.dgvFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFuncionario.Location = new System.Drawing.Point(0, 0);
            this.dgvFuncionario.Name = "dgvFuncionario";
            this.dgvFuncionario.Size = new System.Drawing.Size(715, 352);
            this.dgvFuncionario.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.textBoxPesquisaNomeFuncionario);
            this.panel6.Controls.Add(this.pictureBoxPesquisaFuncionario);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(719, 52);
            this.panel6.TabIndex = 4;
            // 
            // textBoxPesquisaNomeFuncionario
            // 
            this.textBoxPesquisaNomeFuncionario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaNomeFuncionario.Location = new System.Drawing.Point(58, 9);
            this.textBoxPesquisaNomeFuncionario.Name = "textBoxPesquisaNomeFuncionario";
            this.textBoxPesquisaNomeFuncionario.Size = new System.Drawing.Size(461, 26);
            this.textBoxPesquisaNomeFuncionario.TabIndex = 3;
            // 
            // pictureBoxPesquisaFuncionario
            // 
            this.pictureBoxPesquisaFuncionario.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.pictureBoxPesquisaFuncionario.Location = new System.Drawing.Point(522, 4);
            this.pictureBoxPesquisaFuncionario.Name = "pictureBoxPesquisaFuncionario";
            this.pictureBoxPesquisaFuncionario.Size = new System.Drawing.Size(51, 37);
            this.pictureBoxPesquisaFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesquisaFuncionario.TabIndex = 2;
            this.pictureBoxPesquisaFuncionario.TabStop = false;
            this.pictureBoxPesquisaFuncionario.Click += new System.EventHandler(this.pictureBoxPesquisaFuncionario_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(55, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(461, 26);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.pictureBox1.Location = new System.Drawing.Point(519, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel8);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(660, 648);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Produtos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(660, 648);
            this.panel8.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel10.Controls.Add(this.dgvProdutos);
            this.panel10.Location = new System.Drawing.Point(3, 83);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(729, 344);
            this.panel10.TabIndex = 2;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 0);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(725, 340);
            this.dgvProdutos.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.textBoxPesquisaPorNomeProduto);
            this.panel9.Controls.Add(this.pictureBoxPesquisaProduto);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(729, 74);
            this.panel9.TabIndex = 1;
            // 
            // textBoxPesquisaPorNomeProduto
            // 
            this.textBoxPesquisaPorNomeProduto.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPesquisaPorNomeProduto.Location = new System.Drawing.Point(105, 22);
            this.textBoxPesquisaPorNomeProduto.Name = "textBoxPesquisaPorNomeProduto";
            this.textBoxPesquisaPorNomeProduto.Size = new System.Drawing.Size(461, 26);
            this.textBoxPesquisaPorNomeProduto.TabIndex = 5;
            // 
            // pictureBoxPesquisaProduto
            // 
            this.pictureBoxPesquisaProduto.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.pictureBoxPesquisaProduto.Location = new System.Drawing.Point(569, 17);
            this.pictureBoxPesquisaProduto.Name = "pictureBoxPesquisaProduto";
            this.pictureBoxPesquisaProduto.Size = new System.Drawing.Size(51, 37);
            this.pictureBoxPesquisaProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesquisaProduto.TabIndex = 4;
            this.pictureBoxPesquisaProduto.TabStop = false;
            this.pictureBoxPesquisaProduto.Click += new System.EventHandler(this.pictureBoxPesquisaProduto_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel11);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(660, 648);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Venda";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(660, 648);
            this.panel11.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Controls.Add(this.dgvVenda);
            this.panel13.Location = new System.Drawing.Point(3, 84);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(729, 358);
            this.panel13.TabIndex = 1;
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVenda.Location = new System.Drawing.Point(0, 0);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.Size = new System.Drawing.Size(725, 354);
            this.dgvVenda.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Controls.Add(this.dataVenda);
            this.panel12.Controls.Add(this.pictureBoxPesquisaVenda);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(651, 75);
            this.panel12.TabIndex = 0;
            // 
            // dataVenda
            // 
            this.dataVenda.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVenda.Location = new System.Drawing.Point(53, 34);
            this.dataVenda.Name = "dataVenda";
            this.dataVenda.Size = new System.Drawing.Size(510, 20);
            this.dataVenda.TabIndex = 7;
            // 
            // pictureBoxPesquisaVenda
            // 
            this.pictureBoxPesquisaVenda.Image = global::SinalVeiculos.Properties.Resources.if_search_173095;
            this.pictureBoxPesquisaVenda.Location = new System.Drawing.Point(569, 34);
            this.pictureBoxPesquisaVenda.Name = "pictureBoxPesquisaVenda";
            this.pictureBoxPesquisaVenda.Size = new System.Drawing.Size(51, 20);
            this.pictureBoxPesquisaVenda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPesquisaVenda.TabIndex = 6;
            this.pictureBoxPesquisaVenda.TabStop = false;
            this.pictureBoxPesquisaVenda.Click += new System.EventHandler(this.pictureBoxPesquisaVenda_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(3, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 384);
            this.panel3.TabIndex = 1;
            // 
            // Relatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 490);
            this.Controls.Add(this.panel1);
            this.Name = "Relatorios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorios";
            this.Load += new System.EventHandler(this.Relatorios_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaCliente)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionario)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaProduto)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPesquisaVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textoPesquisaCliente;
        private System.Windows.Forms.PictureBox pictureBoxPesquisaCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgvFuncionario;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBoxPesquisaNomeFuncionario;
        private System.Windows.Forms.PictureBox pictureBoxPesquisaFuncionario;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox textBoxPesquisaPorNomeProduto;
        private System.Windows.Forms.PictureBox pictureBoxPesquisaProduto;
        private System.Windows.Forms.Button botaoParaAtualizarDados;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.PictureBox pictureBoxPesquisaVenda;
        private System.Windows.Forms.DateTimePicker dataVenda;
        private System.Windows.Forms.ComboBox comboBoxVeiculos;
        private System.Windows.Forms.DataGridView dgvVenda;
    }
}