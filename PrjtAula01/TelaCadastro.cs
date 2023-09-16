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
    public partial class TelaCadastro : Form
    {
        Conta conta = new Conta();
        public TelaCadastro()
        {
            InitializeComponent();
        }

        private void lblCriarCadastro_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btAcessoCad_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenhaCad.Text == txtConfSenhaCad.Text)
                {
                    //Criando uma conexão

                    SqlConnection conexao =

                    new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                    //Criando um comando

                    SqlCommand cmd = new SqlCommand();



                    //criando texto do comando, tipo e conexão que será usada

                    cmd.CommandText = "pi_Correntista";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection = conexao;

                    //passando os parâmetros necessários
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("nomeCliente", txtNomeCad.Text);
                    cmd.Parameters.AddWithValue("cpf", txtCpfCad.Text);
                    cmd.Parameters.AddWithValue("rg", txtRgCad.Text);
                    cmd.Parameters.AddWithValue("dataNascimento", Convert.ToDateTime(dtDatanasc.Text));
                    cmd.Parameters.AddWithValue("genero", txtGeneroCad.Text);
                    cmd.Parameters.AddWithValue("celular", txtCelCad.Text);
                    cmd.Parameters.AddWithValue("email", txtEmailCad.Text);
                    cmd.Parameters.AddWithValue("cep", txtCepCad.Text);
                    cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text);
                    cmd.Parameters.AddWithValue("numeroEndereco", txtNumeroLogra.Text);
                    cmd.Parameters.AddWithValue("complemento", txtComplemento.Text);
                    cmd.Parameters.AddWithValue("cidade", txtCidade.Text);
                    cmd.Parameters.AddWithValue("estado", cBoxEstado.Text);
                    cmd.Parameters.AddWithValue("renda", txtRenda.Text);
                    cmd.Parameters.AddWithValue("senha", txtSenhaCad.Text);


                    conexao.Open(); // Abrindo a conexão
                    cmd.ExecuteNonQuery(); // executa o comando no Banco de dados
                    conexao.Close();
                    MessageBox.Show("Correntista cadastrado com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    UtiUI.LimpaForm(this);
                    panel1.Visible = true;

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

        private void btVoltarCad_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btCriaConta_Click(object sender, EventArgs e)
        {
            try
            {
                //Criando uma conexão
                SqlConnection conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["Prjt Aula01.Properties.Settings.strConexao"].ToString());

                //Criando um comando
                SqlCommand cmd = new SqlCommand();

                //criando texto do comando, tipo e conexão que será usada
                cmd.CommandText = "pi_Conta";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexao;

                //inserindo parâmetros à procedure
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("iCliente", conta.IdCorrentista);
                cmd.Parameters.AddWithValue("dataAbertura", conta.DataAbertura);
                cmd.Parameters.AddWithValue("Limite", conta.Limite);
                cmd.Parameters.AddWithValue("saldo", conta.Saldo);
                cmd.Parameters.AddWithValue("statusConta", conta.StatusConta);
                cmd.Parameters.AddWithValue("TipoConta", conta.TipoConta);
                cmd.Parameters.AddWithValue("senha", conta.Senha);

                //abrir a conexão
                conexao.Open();

                //executa o comando no BD e captura o retorno devolvido pelo procedimento
                conta.Id = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show(conta.Id.ToString());
                if (txtSenhaConta.Text == txtConfSenhaConta.Text)
                {

                    conta.IdCorrentista = UsuarioLogado.Id;
                    conta.DataAbertura = DateTime.Now;
                    conta.Limite = 10000;
                    conta.Saldo = Convert.ToDecimal(txtDepositoInicial.Text);
                    conta.StatusConta = "ATIVA";
                    conta.TipoConta = "Corrente";
                    conta.Senha = txtSenhaConta.Text;



                    conexao.Close();
                    MessageBox.Show("Conta criada com sucesso!!!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UsuarioLogado.Contas.Add(conta);

                    UtiUI.LimpaForm(this);

                }
                else
                {
                    throw new Exception("Os campos de senha não coincidem!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
