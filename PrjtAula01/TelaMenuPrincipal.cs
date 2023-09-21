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
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
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
                    TelaMenuPrincipal telaLogin = new TelaMenuPrincipal();
                    TelaLoginPrin.MdiParent = this;
                    TelaLoginPrin.Show();
                }
                else
                {
                    menuStrip1.Items[0].Text = "Logar";
                    menuStrip1.Items[1].Visible = true;
                    menuStrip1.Items[2].Visible = true;
                    menuStrip1.Items[3].Visible = true;

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.MdiParent = this;
            telaCadastro.Show();
        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            menuStrip1.Items[0].Text = "Logar";

            menuStrip1.Items[1].Visible = true;

            menuStrip1.Items[2].Visible = false;

            menuStrip1.Items[3].Visible = false;
        }

        private void alterarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAtualizarDados telaAtualizarDados = new TelaAtualizarDados();
            telaAtualizarDados.MdiParent = this;
            telaAtualizarDados.Show();
        }

        private void tranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaTransferencia telaTransferencia = new TelaTransferencia();
            telaTransferencia.MdiParent = this;
            telaTransferencia.Show();
        }

        private void depósitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeposito telaDeposito = new TelaDeposito();
            telaDeposito.MdiParent = this;
            telaDeposito.Show();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAlterarSenha telaAlterarSenha = new TelaAlterarSenha();
            telaAlterarSenha.MdiParent = this;
            telaAlterarSenha.Show();
        }

        private void saqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaSaque telaSaque = new TelaSaque();
            telaSaque.MdiParent = this;
            telaSaque.Show();
        }

        private void agendamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaAgendamento telaAgendamento = new TelaAgendamento();
            telaAgendamento.MdiParent = this;
            telaAgendamento.Show();
        }

        private void alternaContaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
