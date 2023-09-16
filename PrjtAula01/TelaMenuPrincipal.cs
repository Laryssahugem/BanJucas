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
            menuStrip1.Items[0].Text = "Logar";

            menuStrip1.Items[1].Visible = true;

            menuStrip1.Items[2].Visible = false;

            menuStrip1.Items[3].Visible = false;
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
                    menuStrip1.Items[2].Visible = false;
                    menuStrip1.Items[3].Visible = false;

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
    }
}
