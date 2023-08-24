using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
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
          

            //Criando uma conexão

            SqlConnection conexao =

            new SqlConnection(ConfigurationManager.ConnectionStrings["PrjtAula01.Properties.Settings.strConexao"].ToString());

            SqlDataReader leitor; //declarando uma variável do tipo leitor de dados

 

            //Criando um comando

            SqlCommand cmd = new SqlCommand();

 

            //criando texto do comando, tipo e conexão que será usada

            cmd.CommandText = "psValidacaoLogin";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = conexao;

            //passando os parâmetros necessários
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("cpf", caixaLogin.Text);
            cmd.Parameters.AddWithValue("senha", senhaLogin.Text);


            // Método static limpacaixa
            // UtiUI.LimpaForm(this);
            //código quando o botão ENTRAR for clicado

            if (caixaLogin.Text == String.Empty || senhaLogin.Text == String.Empty)
            {
                lblMsgLogin.Text = "Dados não informados!";
                caixaLogin.Focus();
                
            }

            else if (caixaLogin.Text == "12345678900" && senhaLogin.Text == "123456")
            {
                TelaLoginPrincipal telaLogin = new TelaLoginPrincipal();

                // instanciei a classe / criei o objeto
                MenuPrincipal TelaMenu = new MenuPrincipal();

                //usando metodo show
                TelaMenu.Show();
            }

            else if (caixaLogin.TextLength < 11 || senhaLogin.TextLength < 6)
            {
                lblMsgLogin.Text = "Preencha os dados corretamente";
                
            }

            Conta MinhaConta = new Conta();

            MinhaConta.Status = "ATIVA";

            MessageBox.Show(MinhaConta.Status);

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