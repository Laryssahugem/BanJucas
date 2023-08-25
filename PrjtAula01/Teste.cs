using PrjtAula01.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjtAula01
{
    public partial class Teste : Form
    {
        ContaPastaClasses minhaConta;

        public Teste()
        {
            InitializeComponent();
        }

        private void Teste_Load(object sender, EventArgs e)
        {
            //Conta minhaConta = new Conta();
            //minhaConta.Saldo = 1000;
            //minhaConta.Status = "Ativa";

            //MessageBox.Show(minhaConta.Saldo.ToString() + " " + minhaConta.Status, "Minha Conta");

            minhaConta = new ContaPastaClasses(2, 0, 1000, "Ativa", 0, DateTime.Now, null, "Corrente");
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            //Método informal - Concatenando (Separando o método por bloco)
            //lblTotalSaldo.Text = "Saldo: R$ " + minhaConta.Depositar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2");

            //Método formal - Template String sempre começar com $ (Técnica de programação que une texto com variáveis)

            try
            {

                if (txtVlrDpst.Text == String.Empty)
                {
                    throw new Exception("Digite um valor para depositar.");
                }

                lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Depositar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2")}.";

                //MessageBox.Show(Conta.RetornarSaldoTodasContas(), "Valor Total de depósitos");
                txtVlrDpst.Clear();
                txtVlrDpst.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVlrDpst.Text == String.Empty)
                {
                    throw new Exception("Digite um valor para sacar.");
                }

                lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Sacar(Convert.ToDouble(txtVlrDpst.Text)).ToString("n2")}.";
                txtVlrDpst.Clear();
                txtVlrDpst.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally //Bloco que SEMPRE será executado (Ex: Erro de conexão, comunicação, fecha automaticamente o programa ou arquivo
            {
                txtVlrDpst.Focus();
            }

        }

        private void btnVerSaldo_Click(object sender, EventArgs e)
        {
            lblTotalSaldo.Text = $"Saldo: R$ {minhaConta.Saldo.ToString("n2")}";
            lblTotalSaldo.Show();
        }

        private void txtVlrDpst_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(txtVlrDpst.Text, out var valorDigitado))
            {
                txtVlrDpst.Clear();
            }
        }

        private void btnEsconderSaldo_Click(object sender, EventArgs e)
        {
            lblTotalSaldo.Hide();
        }
    }
}
