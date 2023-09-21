using PrjtAula01.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjtAula01
{
    public partial class TelaAlterarSenha : Form
    {
        public TelaAlterarSenha()
        {
            InitializeComponent();
        }

        private void TelaAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            try
            {

                if (textAlterarSenha.Text == txtConfAlterarSenha.Text)
                {
                    SqlConnection conexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());


                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandText = "AtualizarSenha";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexao;

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.Id);
                    cmd.Parameters.AddWithValue("senhaLogin", textAlterarSenha.Text);

                    conexao.Open();
                    cmd.ExecuteNonQuery();
                    conexao.Close();
                    MessageBox.Show("Senha alterada com sucesso!", "Info!");
                    UtiUI.LimpaForm(this);
                }

                else
                {
                    throw new Exception("Erro!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        
        }
    }
}
