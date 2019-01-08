namespace Exercicio_8
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.txtSalLiq = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtCom = new System.Windows.Forms.TextBox();
            this.lblAcres = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbMensal = new System.Windows.Forms.RadioButton();
            this.rbHora = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbVendas = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbVendas = new System.Windows.Forms.ComboBox();
            this.txtFilhos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(63, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 8);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(3, 226);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(93, 13);
            this.lblSalBruto.TabIndex = 6;
            this.lblSalBruto.Text = "Salario Liquido R$";
            // 
            // txtSalLiq
            // 
            this.txtSalLiq.Location = new System.Drawing.Point(100, 223);
            this.txtSalLiq.Name = "txtSalLiq";
            this.txtSalLiq.ReadOnly = true;
            this.txtSalLiq.Size = new System.Drawing.Size(100, 20);
            this.txtSalLiq.TabIndex = 7;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(15, 192);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(75, 13);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Descontos R$";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(100, 192);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ReadOnly = true;
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 9;
            // 
            // txtCom
            // 
            this.txtCom.Location = new System.Drawing.Point(100, 160);
            this.txtCom.Name = "txtCom";
            this.txtCom.ReadOnly = true;
            this.txtCom.Size = new System.Drawing.Size(100, 20);
            this.txtCom.TabIndex = 10;
            // 
            // lblAcres
            // 
            this.lblAcres.AutoSize = true;
            this.lblAcres.Location = new System.Drawing.Point(15, 163);
            this.lblAcres.Name = "lblAcres";
            this.lblAcres.Size = new System.Drawing.Size(69, 13);
            this.lblAcres.TabIndex = 11;
            this.lblAcres.Text = "Comissão R$";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbHora);
            this.groupBox1.Controls.Add(this.rbMensal);
            this.groupBox1.Location = new System.Drawing.Point(15, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(129, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contrato";
            // 
            // rbMensal
            // 
            this.rbMensal.AutoSize = true;
            this.rbMensal.Location = new System.Drawing.Point(6, 20);
            this.rbMensal.Name = "rbMensal";
            this.rbMensal.Size = new System.Drawing.Size(75, 17);
            this.rbMensal.TabIndex = 0;
            this.rbMensal.TabStop = true;
            this.rbMensal.Text = "Mensalista";
            this.rbMensal.UseVisualStyleBackColor = true;
            // 
            // rbHora
            // 
            this.rbHora.AutoSize = true;
            this.rbHora.Location = new System.Drawing.Point(6, 37);
            this.rbHora.Name = "rbHora";
            this.rbHora.Size = new System.Drawing.Size(58, 17);
            this.rbHora.TabIndex = 1;
            this.rbHora.TabStop = true;
            this.rbHora.Text = "Horista";
            this.rbHora.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbOther);
            this.groupBox2.Controls.Add(this.rbVendas);
            this.groupBox2.Location = new System.Drawing.Point(150, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 60);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setor";
            // 
            // rbVendas
            // 
            this.rbVendas.AutoSize = true;
            this.rbVendas.Location = new System.Drawing.Point(7, 20);
            this.rbVendas.Name = "rbVendas";
            this.rbVendas.Size = new System.Drawing.Size(61, 17);
            this.rbVendas.TabIndex = 0;
            this.rbVendas.TabStop = true;
            this.rbVendas.Text = "Vendas";
            this.rbVendas.UseVisualStyleBackColor = true;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(7, 37);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(56, 17);
            this.rbOther.TabIndex = 1;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Outros";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(12, 35);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 14;
            this.lblSalario.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(63, 32);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbVendas);
            this.groupBox3.Location = new System.Drawing.Point(283, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(180, 60);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Vendas";
            // 
            // cmbVendas
            // 
            this.cmbVendas.FormattingEnabled = true;
            this.cmbVendas.Items.AddRange(new object[] {
            "Menos ou igual a  R$100,00",
            "Maior que R$100,00 e menos que R$500,00",
            "Maior que R$500,00 e menor que R$1.000,00",
            "Maior que R$1.000,00"});
            this.cmbVendas.Location = new System.Drawing.Point(25, 20);
            this.cmbVendas.Name = "cmbVendas";
            this.cmbVendas.Size = new System.Drawing.Size(121, 21);
            this.cmbVendas.TabIndex = 0;
            // 
            // txtFilhos
            // 
            this.txtFilhos.Location = new System.Drawing.Point(250, 5);
            this.txtFilhos.Name = "txtFilhos";
            this.txtFilhos.Size = new System.Drawing.Size(100, 20);
            this.txtFilhos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nº de filhos";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(283, 152);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(283, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(283, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 262);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilhos);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAcres);
            this.Controls.Add(this.txtCom);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtSalLiq);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Salario Liquido";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.TextBox txtSalLiq;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtCom;
        private System.Windows.Forms.Label lblAcres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbHora;
        private System.Windows.Forms.RadioButton rbMensal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbVendas;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbVendas;
        private System.Windows.Forms.TextBox txtFilhos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

