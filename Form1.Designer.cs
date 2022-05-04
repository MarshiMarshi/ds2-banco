
namespace ds2_banco
{
    partial class frmContaCliente
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
            this.grpDadosCliente = new System.Windows.Forms.GroupBox();
            this.grpDadosConta = new System.Windows.Forms.GroupBox();
            this.grpMovimentacao = new System.Windows.Forms.GroupBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLimite = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.rdoSaque = new System.Windows.Forms.RadioButton();
            this.rdoDeposito = new System.Windows.Forms.RadioButton();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnRegistrarMov = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.grpDadosCliente.SuspendLayout();
            this.grpDadosConta.SuspendLayout();
            this.grpMovimentacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDadosCliente
            // 
            this.grpDadosCliente.Controls.Add(this.txtCPF);
            this.grpDadosCliente.Controls.Add(this.txtSobrenome);
            this.grpDadosCliente.Controls.Add(this.txtNome);
            this.grpDadosCliente.Controls.Add(this.lblCPF);
            this.grpDadosCliente.Controls.Add(this.lblSobrenome);
            this.grpDadosCliente.Controls.Add(this.lblNome);
            this.grpDadosCliente.Location = new System.Drawing.Point(36, 44);
            this.grpDadosCliente.Name = "grpDadosCliente";
            this.grpDadosCliente.Size = new System.Drawing.Size(228, 135);
            this.grpDadosCliente.TabIndex = 0;
            this.grpDadosCliente.TabStop = false;
            this.grpDadosCliente.Text = "Dados do Cliente";
            // 
            // grpDadosConta
            // 
            this.grpDadosConta.Controls.Add(this.txtSaldo);
            this.grpDadosConta.Controls.Add(this.txtLimite);
            this.grpDadosConta.Controls.Add(this.txtNumero);
            this.grpDadosConta.Controls.Add(this.lblSaldo);
            this.grpDadosConta.Controls.Add(this.lblLimite);
            this.grpDadosConta.Controls.Add(this.lblNumero);
            this.grpDadosConta.Location = new System.Drawing.Point(36, 185);
            this.grpDadosConta.Name = "grpDadosConta";
            this.grpDadosConta.Size = new System.Drawing.Size(228, 128);
            this.grpDadosConta.TabIndex = 1;
            this.grpDadosConta.TabStop = false;
            this.grpDadosConta.Text = "Dados da Conta";
            // 
            // grpMovimentacao
            // 
            this.grpMovimentacao.Controls.Add(this.txtValor);
            this.grpMovimentacao.Controls.Add(this.lblValor);
            this.grpMovimentacao.Controls.Add(this.lblOperacao);
            this.grpMovimentacao.Controls.Add(this.rdoDeposito);
            this.grpMovimentacao.Controls.Add(this.rdoSaque);
            this.grpMovimentacao.Location = new System.Drawing.Point(304, 74);
            this.grpMovimentacao.Name = "grpMovimentacao";
            this.grpMovimentacao.Size = new System.Drawing.Size(228, 135);
            this.grpMovimentacao.TabIndex = 2;
            this.grpMovimentacao.TabStop = false;
            this.grpMovimentacao.Text = "Movimentação";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Location = new System.Drawing.Point(25, 61);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(64, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(25, 94);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(26, 31);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número:";
            // 
            // lblLimite
            // 
            this.lblLimite.AutoSize = true;
            this.lblLimite.Location = new System.Drawing.Point(26, 57);
            this.lblLimite.Name = "lblLimite";
            this.lblLimite.Size = new System.Drawing.Size(37, 13);
            this.lblLimite.TabIndex = 1;
            this.lblLimite.Text = "Limite:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(28, 83);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            // 
            // rdoSaque
            // 
            this.rdoSaque.AutoSize = true;
            this.rdoSaque.Location = new System.Drawing.Point(28, 52);
            this.rdoSaque.Name = "rdoSaque";
            this.rdoSaque.Size = new System.Drawing.Size(56, 17);
            this.rdoSaque.TabIndex = 0;
            this.rdoSaque.TabStop = true;
            this.rdoSaque.Text = "Saque";
            this.rdoSaque.UseVisualStyleBackColor = true;
            // 
            // rdoDeposito
            // 
            this.rdoDeposito.AutoSize = true;
            this.rdoDeposito.Location = new System.Drawing.Point(119, 52);
            this.rdoDeposito.Name = "rdoDeposito";
            this.rdoDeposito.Size = new System.Drawing.Size(67, 17);
            this.rdoDeposito.TabIndex = 1;
            this.rdoDeposito.TabStop = true;
            this.rdoDeposito.Text = "Depósito";
            this.rdoDeposito.UseVisualStyleBackColor = true;
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(16, 27);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(57, 13);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.Text = "Operação:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(25, 99);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(126, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(95, 58);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(69, 91);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(126, 20);
            this.txtCPF.TabIndex = 5;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(79, 28);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(116, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtLimite
            // 
            this.txtLimite.Location = new System.Drawing.Point(69, 54);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.Size = new System.Drawing.Size(126, 20);
            this.txtLimite.TabIndex = 4;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(69, 80);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(126, 20);
            this.txtSaldo.TabIndex = 5;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(65, 96);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(139, 20);
            this.txtValor.TabIndex = 4;
            // 
            // btnRegistrarMov
            // 
            this.btnRegistrarMov.Location = new System.Drawing.Point(286, 253);
            this.btnRegistrarMov.Name = "btnRegistrarMov";
            this.btnRegistrarMov.Size = new System.Drawing.Size(129, 43);
            this.btnRegistrarMov.TabIndex = 3;
            this.btnRegistrarMov.Text = "Registrar Movimentação";
            this.btnRegistrarMov.UseVisualStyleBackColor = true;
            this.btnRegistrarMov.Click += new System.EventHandler(this.btnRegistrarMov_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(421, 253);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(129, 43);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(468, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair do Programa";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmContaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 344);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnRegistrarMov);
            this.Controls.Add(this.grpMovimentacao);
            this.Controls.Add(this.grpDadosConta);
            this.Controls.Add(this.grpDadosCliente);
            this.Name = "frmContaCliente";
            this.Text = "Nova Cliente";
            this.grpDadosCliente.ResumeLayout(false);
            this.grpDadosCliente.PerformLayout();
            this.grpDadosConta.ResumeLayout(false);
            this.grpDadosConta.PerformLayout();
            this.grpMovimentacao.ResumeLayout(false);
            this.grpMovimentacao.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDadosCliente;
        private System.Windows.Forms.GroupBox grpDadosConta;
        private System.Windows.Forms.GroupBox grpMovimentacao;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtLimite;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblLimite;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.RadioButton rdoDeposito;
        private System.Windows.Forms.RadioButton rdoSaque;
        private System.Windows.Forms.Button btnRegistrarMov;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

