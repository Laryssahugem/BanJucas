using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using DTO;
using PrjtAula01.Classes;

namespace PrjtAula01
{
    public partial class TelaLoginPrincipal : Form
    {
        public TelaLoginPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Criando uma conex�o

                SqlConnection conexao =

                new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

                SqlDataReader leitor; //declarando uma vari�vel do tipo leitor de dados



                //Criando um comando

                SqlCommand cmd = new SqlCommand();



                //criando texto do comando, tipo e conex�o que ser� usada

                cmd.CommandText = "psValidacaoLogin";

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection = conexao;

                //passando os par�metros necess�rios
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("cpf", caixaLogin.Text);
                cmd.Parameters.AddWithValue("senha", senhaLogin.Text);

                conexao.Open(); // Abrindo a conex�o

                leitor = cmd.ExecuteReader();
                // igualando o leitor ao resultado trazido do BD

                if (leitor.HasRows) // se o leitor encontra linhas de dados
                {
                    leitor.Read();
                    //UtiUI.LimpaForm(this);


                    UsuarioLogado.Id = leitor.GetInt32(0);
                    UsuarioLogado.NomeCorrentista = leitor.GetString(1);
                    UsuarioLogado.Cpf = leitor.GetString(2);
                    UsuarioLogado.Rg = leitor.GetString(3);
                    UsuarioLogado.DataNascimento = leitor.GetDateTime(4);
                    UsuarioLogado.Genero = leitor.GetString(5);
                    UsuarioLogado.Celular = leitor.GetString(6);
                    UsuarioLogado.Cep = leitor.GetString(7);
                    UsuarioLogado.Logradouro = leitor.GetString(8);
                    UsuarioLogado.Numero = leitor.GetString(9);
                    UsuarioLogado.Complemento = leitor.GetString(10);
                    UsuarioLogado.Cidade = leitor.GetString(11);
                    UsuarioLogado.Estado = leitor.GetString(12);
                    UsuarioLogado.RendaMensal = leitor.GetDecimal(13);
                    UsuarioLogado.Email = leitor.GetString(14);
                    UsuarioLogado.Senha = leitor.GetString(15);


                    //fechando leitor
                    leitor.Close();
                    //ler novamente o leitor
                    leitor = cmd.ExecuteReader();

                    cmd.CommandText = "ps_buscaContasPorIdCorrentista";

                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Connection = conexao;

                    //verificar se h� linhas retornadas do leitor
                    if (leitor.HasRows)
                    {
                        //repete a leitura e enquanto h� linhas segue na estrutura
                        //de repeti��o
                        while (leitor.Read())
                        {
                            //cria uma conta na mem�ria
                            Conta conta = new Conta();
                            //passa os dados do leitor para a conta na mem�ria - objeto conta
                            conta.Id = leitor.GetInt32(0);
                            conta.IdCorrentista = leitor.GetInt32(1);
                            conta.Saldo = leitor.GetDecimal(2);
                            if (!leitor.IsDBNull(3))
                            {
                                conta.Limite = leitor.GetDecimal(3);
                            }
                            conta.TipoConta = leitor.GetString(4);
                            conta.DataAbertura = leitor.GetDateTime(5);
                            conta.StatusConta = leitor.GetString(6);
                            conta.Senha = leitor.GetString(7);



                            //adiciona a conta rec�m criada na mem�ria para a colection de contas
                            UsuarioLogado.Contas.Add(conta);
                        }
                    }
                    leitor.Close(); //fecha leitor
                    conexao.Close(); //fecha conexao com BD


                    Form telaLogin = Application.OpenForms["TelaLogin"];

                    //acessando o formul�rio aberto atrav�s da vari�vel janelaPrincipal

                    MenuStrip menuPrincipal = (MenuStrip)telaLogin.Controls[0];

                    menuPrincipal.Items[0].Text = "Logout";

                    menuPrincipal.Items[1].Visible = true;

                    menuPrincipal.Items[2].Visible = true;

                    menuPrincipal.Items[3].Visible = true;

                    // menuPrincipal.Items[3].Visible = true;

                    // menuPrincipal.Items[4].Visible = true;

                    // menuPrincipal.Items[4].Text = UsuarioLogado.NomeCorrentista;

                    // menuPrincipal.Items[5].Visible = true;

                    // menuPrincipal.Items[6].Visible = true;

                    // menuPrincipal.Items[6].Text = UsuarioLogado.Contas[0].Id.ToString();



                    MessageBox.Show($"Ol�,{UsuarioLogado.NomeCorrentista}!\n" +

                     $"Voc� foi logado na conta {UsuarioLogado.Contas[0].Id.ToString()}\n" +

                    $"Para trocar de conta, utilize o menu Conta\\Alternar Conta");

                    // MessageBox.Show($"{CorrentistaLogado.Id.ToString()},{CorrentistaLogado.NomeCorrentista},{CorrentistaLogado.DataNascimento.ToString()},{CorrentistaLogado.Logradouro}," +

                    //    $"{CorrentistaLogado.Numero},{CorrentistaLogado.Complemento},{CorrentistaLogado.Cidade}," +

                    //    $"{CorrentistaLogado.Estado},{CorrentistaLogado.Cpf},{CorrentistaLogado.Senha},{CorrentistaLogado.Celular}");

                    this.Close();

                }
                else
                {
                    MessageBox.Show("Usu�rio ou senha incorretos!");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void criarCadastro_Click(object sender, EventArgs e)
        {
            // instanciei a classe / criei o objeto
            TelaCadastro TelaLogin = new TelaCadastro();

            //usando metodo show
            TelaLogin.Show();

        }

        private void caixaLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaLoginPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}