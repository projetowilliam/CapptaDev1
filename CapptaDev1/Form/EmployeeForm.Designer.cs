﻿namespace SinalVeiculos
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
            this.BtnSearcheEmployeer = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddEmployeer = new System.Windows.Forms.PictureBox();
            this.btnClean_ = new System.Windows.Forms.PictureBox();
            this.btnExit_ = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearcheEmployeer)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEmployeer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean_)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit_)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExit_);
            this.panel1.Controls.Add(this.btnClean_);
            this.panel1.Controls.Add(this.btnAddEmployeer);
            this.panel1.Controls.Add(this.BtnSearcheEmployeer);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 270);
            this.panel1.TabIndex = 0;
            // 
            // BtnSearcheEmployeer
            // 
            this.BtnSearcheEmployeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BtnSearcheEmployeer.Image = global::CapptaDev1.Properties.Resources.if_search_173095;
            this.BtnSearcheEmployeer.Location = new System.Drawing.Point(337, 9);
            this.BtnSearcheEmployeer.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSearcheEmployeer.Name = "BtnSearcheEmployeer";
            this.BtnSearcheEmployeer.Size = new System.Drawing.Size(30, 25);
            this.BtnSearcheEmployeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSearcheEmployeer.TabIndex = 28;
            this.BtnSearcheEmployeer.TabStop = false;
            this.BtnSearcheEmployeer.Click += new System.EventHandler(this.BtnSearcheEmployeer_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Pesquisa:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(75, 11);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 20);
            this.txtSearch.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtState);
            this.panel3.Controls.Add(this.txtCity);
            this.panel3.Controls.Add(this.txtNumber);
            this.panel3.Controls.Add(this.txtStreet);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCpf);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPhone);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Location = new System.Drawing.Point(15, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(355, 150);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rua";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(307, 100);
            this.txtState.Margin = new System.Windows.Forms.Padding(2);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(43, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(59, 100);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(157, 20);
            this.txtCity.TabIndex = 5;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(307, 71);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(43, 20);
            this.txtNumber.TabIndex = 4;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(59, 71);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(157, 20);
            this.txtStreet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(241, 39);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(109, 20);
            this.txtCpf.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(59, 39);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(109, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 10);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 20);
            this.txtName.TabIndex = 0;
            // 
            // btnAddEmployeer
            // 
            this.btnAddEmployeer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnAddEmployeer.Image = global::CapptaDev1.Properties.Resources.if_InterfaceExpendet_10_592607;
            this.btnAddEmployeer.Location = new System.Drawing.Point(15, 219);
            this.btnAddEmployeer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmployeer.Name = "btnAddEmployeer";
            this.btnAddEmployeer.Size = new System.Drawing.Size(57, 38);
            this.btnAddEmployeer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEmployeer.TabIndex = 30;
            this.btnAddEmployeer.TabStop = false;
            this.btnAddEmployeer.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnClean_
            // 
            this.btnClean_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnClean_.Image = global::CapptaDev1.Properties.Resources.if_broom_stick_3_896656;
            this.btnClean_.Location = new System.Drawing.Point(161, 219);
            this.btnClean_.Margin = new System.Windows.Forms.Padding(2);
            this.btnClean_.Name = "btnClean_";
            this.btnClean_.Size = new System.Drawing.Size(57, 38);
            this.btnClean_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClean_.TabIndex = 31;
            this.btnClean_.TabStop = false;
            this.btnClean_.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // btnExit_
            // 
            this.btnExit_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnExit_.Image = global::CapptaDev1.Properties.Resources.if_Exit_131885;
            this.btnExit_.Location = new System.Drawing.Point(313, 218);
            this.btnExit_.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit_.Name = "btnExit_";
            this.btnExit_.Size = new System.Drawing.Size(57, 38);
            this.btnExit_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit_.TabIndex = 32;
            this.btnExit_.TabStop = false;
            this.btnExit_.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 270);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSearcheEmployeer)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEmployeer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClean_)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit_)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox BtnSearcheEmployeer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox btnExit_;
        private System.Windows.Forms.PictureBox btnClean_;
        private System.Windows.Forms.PictureBox btnAddEmployeer;
    }
}