using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrjtAula01.Classes;

namespace PrjtAula01
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeposito janelaDeposito = new TelaDeposito();
            janelaDeposito.MdiParent = this;
            janelaDeposito.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque janelaSaque = new TelaSaque();
            janelaSaque.MdiParent = this;
            janelaSaque.Show();
        }

        private void transferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia janelaTransferencia = new TelaTransferencia();
            janelaTransferencia.MdiParent = this;
            janelaTransferencia.Show();
        }

        private void logarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastro janelaCadastro = new TelaCadastro();
            janelaCadastro.MdiParent = this;
            janelaCadastro.Show();
        }

        private void deposítarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                // instanciei a classe / criei o objeto
                TelaLoginPrincipal TelaLoginPrin = new TelaLoginPrincipal();

                //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
                TelaLoginPrin.MdiParent = this;

                //usando metodo show
                TelaLoginPrin.Show();
                if (this.menuStrip1.Items[0].Text == "Logar")
                {
                    TelaLogin telaLogin = new TelaLogin();
                    TelaLoginPrin.MdiParent = this;
                    TelaLoginPrin.Show();
                }
                else
                {
                    menuStrip1.Items[0].Text = "Logar";
                    menuStrip1.Items[2].Visible = false;
                    menuStrip1.Items[1].Visible = false;
                    menuStrip1.Items[1].Visible = false;
                }
               
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var telaLogin = new TelaLoginPrincipal();

            // instanciei a classe / criei o objeto
            TelaCadastro TelaCad = new TelaCadastro();


            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            TelaCad.MdiParent = this;

            //usando metodo show
            TelaCad.Show();

            // instanciei a classe / criei o objeto
            TeleCadastroConta telaCadastroConta = new TeleCadastroConta();


            //definindo a janela "pai" para o form TelaLogin, ou seja, obrigando a tela criada a ser aberta dentro do Form principal
            telaCadastroConta.MdiParent = this;

            //usando metodo show
            telaCadastroConta.Show();
        }
    }
}
