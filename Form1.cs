using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ds2_banco
{
    public partial class frmContaCliente : Form
    {
        public frmContaCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrarMov_Click(object sender, EventArgs e)
        {
            double parse;
            
            if (!string.IsNullOrWhiteSpace(txtNome.Text) && !string.IsNullOrWhiteSpace(txtSobrenome.Text) && !string.IsNullOrWhiteSpace(txtCPF.Text))
            {
                if (double.TryParse(txtNumero.Text, out parse) && double.TryParse(txtLimite.Text, out parse) && double.TryParse(txtSaldo.Text, out parse))
                {
                    if (double.TryParse(txtValor.Text, out parse))
                    {
                        Cliente cli = new Cliente();
                        cli.nome = txtNome.Text;
                        cli.sobrenome = txtSobrenome.Text;
                        cli.cpf = txtCPF.Text;

                        Conta cc = new Conta(cli);
                        cc.numero = int.Parse(txtNumero.Text);
                        cc.limite = double.Parse(txtLimite.Text);
                        cc.saldo = double.Parse(txtSaldo.Text);

                        if (rdoSaque.Checked)
                        {
                            cc.sacar(int.Parse(txtValor.Text));
                        }
                        else
                        {
                            cc.depositar(int.Parse(txtValor.Text));
                        }

                        MessageBox.Show($"O seu novo saldo é: {cc.saldo}", "Novo Saldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string message;

                        message = string.IsNullOrWhiteSpace(txtValor.Text) ? "Está faltando valor no campo Valor!" : $"{txtValor.Text} não é um número!";

                        MessageBox.Show(message, "Valor Incorreto no Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    string message;

                    if (!double.TryParse(txtNumero.Text, out parse))
                    {
                        message = string.IsNullOrWhiteSpace(txtNumero.Text) ? "Está faltando valor no campo Número!" : $"{txtNumero.Text} não é um número!";

                        MessageBox.Show(message, "Valor Incorreto no Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!double.TryParse(txtLimite.Text, out parse))
                    {
                        message = string.IsNullOrWhiteSpace(txtLimite.Text) ? "Está faltando valor no campo Limite!" : $"{txtLimite.Text} não é um número!";

                        MessageBox.Show(message, "Valor Incorreto no Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        message = string.IsNullOrWhiteSpace(txtSaldo.Text) ? "Está faltando valor no campo Saldo!" : $"{txtSaldo.Text} não é um número!";

                        MessageBox.Show(message, "Valor Incorreto no Campo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    MessageBox.Show("Está faltando valor no campo Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (string.IsNullOrWhiteSpace(txtSobrenome.Text))
                {
                    MessageBox.Show("Está faltando valor no campo Sobrenome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Está faltando valor no campo CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtCPF.Clear();

            txtNumero.Clear();
            txtLimite.Clear();
            txtSaldo.Clear();

            txtValor.Clear();

            rdoSaque.Checked = true;
            txtNome.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Você deseja mesmo sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
        }
    }
}
