using DTO;
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
    public partial class TelaAtualizarDados : Form
    {
        Conta conta = new Conta();
        public TelaAtualizarDados()
        {
            InitializeComponent();
        }

        private void btAtuaizaInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaUpdate.Text == txtConfSenhaUpDate.Text)
                {
                    //Criando uma conexão

                    SqlConnection conexao =

                    new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando

                    SqlCommand cmd = new SqlCommand();

                    //criando texto do comando, tipo e conexão que será usada

                    cmd.CommandText = "pu_AtualizarClientes";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection = conexao;

                    cmd.Parameters.AddWithValue("idCliente", UsuarioLogado.Id);
                    cmd.Parameters.AddWithValue("nomeCliente", txtNomeCad.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCad.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCad.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtDatanasc.Text));
                    cmd.Parameters.AddWithValue("genero", txtGeneroCad.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelCad.Text);
                    cmd.Parameters.AddWithValue("cep", txtCepCad.Text);
                    cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                    cmd.Parameters.AddWithValue("numeroEndereco", txtNumeroLogra.Text);
                    cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cBoxEstado.Text);
                    cmd.Parameters.AddWithValue("renda", txtRenda.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCad.Text);              
                    cmd.Parameters.AddWithValue("Senha", txtSenhaUpdate.Text);

                    conexao.Open(); // Abrindo a conexão
                    cmd.ExecuteNonQuery(); // executa o comando no Banco de dados
                    conexao.Close();
                    MessageBox.Show("Correntista Atualizado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            UtiUI.LimpaForm(this);
        }

        private void txtNomeCad_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelaAtualizarDados_Load(object sender, EventArgs e)
        {
            txtNomeCad.Text = UsuarioLogado.NomeCorrentista;
            dtDatanasc.Text = Convert.ToString(UsuarioLogado.DataNascimento);
            txtLogradouro.Text = UsuarioLogado.Logradouro;
            txtNumeroLogra.Text = UsuarioLogado.Numero;
            txtComplemento.Text = UsuarioLogado.Complemento;
            txtCidade.Text = UsuarioLogado.Cidade;
            cBoxEstado.Text = UsuarioLogado.Estado;
            txtCpfCad.Text = UsuarioLogado.Cpf;
            txtCelCad.Text = UsuarioLogado.Celular;
            txtRgCad.Text = UsuarioLogado.Rg;
            txtEmailCad.Text = UsuarioLogado.Email;
            txtCepCad.Text = UsuarioLogado.Cep;
            txtGeneroCad.Text = UsuarioLogado.Genero;
            txtRenda.Text = Convert.ToString(UsuarioLogado.RendaMensal);

        }
    }
}
