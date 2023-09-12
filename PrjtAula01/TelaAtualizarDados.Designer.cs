namespace PrjtAula01
{
    partial class TelaAtualizarDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAtualizarDados));
            dtDatanasc = new DateTimePicker();
            txtComplemento = new TextBox();
            cBoxEstado = new ComboBox();
            txtRenda = new TextBox();
            txtLogradouro = new TextBox();
            txtNumeroLogra = new TextBox();
            pictureBox1 = new PictureBox();
            lblAtzCadastro = new Label();
            btVoltarUpdate = new Button();
            btAtuaizaInfo = new Button();
            txtConfSenhaUpDate = new TextBox();
            txtSenhaUpdate = new TextBox();
            txtCidade = new TextBox();
            txtCepCad = new TextBox();
            txtGeneroCad = new TextBox();
            txtEmailCad = new TextBox();
            txtCelCad = new TextBox();
            txtRgCad = new TextBox();
            txtCpfCad = new TextBox();
            txtNomeCad = new TextBox();
            btnLimpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtDatanasc
            // 
            dtDatanasc.Location = new Point(4, 270);
            dtDatanasc.Name = "dtDatanasc";
            dtDatanasc.Size = new Size(300, 23);
            dtDatanasc.TabIndex = 45;
            // 
            // txtComplemento
            // 
            txtComplemento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtComplemento.Location = new Point(391, 264);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.PlaceholderText = "Complemento";
            txtComplemento.Size = new Size(300, 29);
            txtComplemento.TabIndex = 44;
            txtComplemento.TextAlign = HorizontalAlignment.Center;
            // 
            // cBoxEstado
            // 
            cBoxEstado.AutoCompleteCustomSource.AddRange(new string[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF" });
            cBoxEstado.FormattingEnabled = true;
            cBoxEstado.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO", "DF" });
            cBoxEstado.Location = new Point(391, 362);
            cBoxEstado.Name = "cBoxEstado";
            cBoxEstado.Size = new Size(300, 23);
            cBoxEstado.TabIndex = 43;
            // 
            // txtRenda
            // 
            txtRenda.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRenda.Location = new Point(391, 415);
            txtRenda.Name = "txtRenda";
            txtRenda.PlaceholderText = "Renda Mensal";
            txtRenda.Size = new Size(300, 29);
            txtRenda.TabIndex = 42;
            txtRenda.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtLogradouro.Location = new Point(391, 151);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.PlaceholderText = "Logradouro";
            txtLogradouro.Size = new Size(300, 29);
            txtLogradouro.TabIndex = 41;
            txtLogradouro.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumeroLogra
            // 
            txtNumeroLogra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumeroLogra.Location = new Point(391, 209);
            txtNumeroLogra.Name = "txtNumeroLogra";
            txtNumeroLogra.PlaceholderText = "Número Logradouro";
            txtNumeroLogra.Size = new Size(300, 29);
            txtNumeroLogra.TabIndex = 40;
            txtNumeroLogra.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(468, 494);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 124);
            pictureBox1.TabIndex = 39;
            pictureBox1.TabStop = false;
            // 
            // lblAtzCadastro
            // 
            lblAtzCadastro.AutoSize = true;
            lblAtzCadastro.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblAtzCadastro.ForeColor = Color.White;
            lblAtzCadastro.Location = new Point(4, 43);
            lblAtzCadastro.Name = "lblAtzCadastro";
            lblAtzCadastro.Size = new Size(250, 37);
            lblAtzCadastro.TabIndex = 38;
            lblAtzCadastro.Text = "Atualize seus dados";
            // 
            // btVoltarUpdate
            // 
            btVoltarUpdate.BackColor = Color.White;
            btVoltarUpdate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarUpdate.Location = new Point(847, 428);
            btVoltarUpdate.Name = "btVoltarUpdate";
            btVoltarUpdate.Size = new Size(203, 54);
            btVoltarUpdate.TabIndex = 37;
            btVoltarUpdate.Text = "Voltar";
            btVoltarUpdate.UseVisualStyleBackColor = false;
            // 
            // btAtuaizaInfo
            // 
            btAtuaizaInfo.BackColor = Color.White;
            btAtuaizaInfo.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btAtuaizaInfo.Location = new Point(847, 239);
            btAtuaizaInfo.Name = "btAtuaizaInfo";
            btAtuaizaInfo.Size = new Size(203, 54);
            btAtuaizaInfo.TabIndex = 36;
            btAtuaizaInfo.Text = "Atualizar";
            btAtuaizaInfo.UseVisualStyleBackColor = false;
            btAtuaizaInfo.Click += btAtuaizaInfo_Click;
            // 
            // txtConfSenhaUpDate
            // 
            txtConfSenhaUpDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaUpDate.Location = new Point(786, 151);
            txtConfSenhaUpDate.Name = "txtConfSenhaUpDate";
            txtConfSenhaUpDate.PlaceholderText = "Confirme sua senha";
            txtConfSenhaUpDate.Size = new Size(300, 29);
            txtConfSenhaUpDate.TabIndex = 35;
            txtConfSenhaUpDate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaUpdate
            // 
            txtSenhaUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaUpdate.Location = new Point(786, 98);
            txtSenhaUpdate.Name = "txtSenhaUpdate";
            txtSenhaUpdate.PlaceholderText = "Digite sua Senha";
            txtSenhaUpdate.Size = new Size(300, 29);
            txtSenhaUpdate.TabIndex = 34;
            txtSenhaUpdate.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCidade.Location = new Point(391, 315);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(300, 29);
            txtCidade.TabIndex = 33;
            txtCidade.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCepCad
            // 
            txtCepCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCepCad.Location = new Point(391, 98);
            txtCepCad.Name = "txtCepCad";
            txtCepCad.PlaceholderText = "Cep";
            txtCepCad.Size = new Size(300, 29);
            txtCepCad.TabIndex = 32;
            txtCepCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtGeneroCad
            // 
            txtGeneroCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtGeneroCad.Location = new Point(4, 315);
            txtGeneroCad.Name = "txtGeneroCad";
            txtGeneroCad.PlaceholderText = "Gênero";
            txtGeneroCad.Size = new Size(300, 29);
            txtGeneroCad.TabIndex = 31;
            txtGeneroCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEmailCad
            // 
            txtEmailCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmailCad.Location = new Point(4, 415);
            txtEmailCad.Name = "txtEmailCad";
            txtEmailCad.PlaceholderText = "email@email.com";
            txtEmailCad.Size = new Size(300, 29);
            txtEmailCad.TabIndex = 30;
            txtEmailCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCelCad
            // 
            txtCelCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCelCad.Location = new Point(4, 362);
            txtCelCad.Name = "txtCelCad";
            txtCelCad.PlaceholderText = "Celular";
            txtCelCad.Size = new Size(300, 29);
            txtCelCad.TabIndex = 29;
            txtCelCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRgCad
            // 
            txtRgCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtRgCad.Location = new Point(4, 209);
            txtRgCad.Name = "txtRgCad";
            txtRgCad.PlaceholderText = "00.000.000-0";
            txtRgCad.Size = new Size(300, 29);
            txtRgCad.TabIndex = 28;
            txtRgCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCpfCad
            // 
            txtCpfCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCpfCad.Location = new Point(4, 151);
            txtCpfCad.Name = "txtCpfCad";
            txtCpfCad.PlaceholderText = "000.000.000-00";
            txtCpfCad.Size = new Size(300, 29);
            txtCpfCad.TabIndex = 27;
            txtCpfCad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeCad
            // 
            txtNomeCad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeCad.Location = new Point(4, 98);
            txtNomeCad.Name = "txtNomeCad";
            txtNomeCad.PlaceholderText = "Nome Completo";
            txtNomeCad.Size = new Size(300, 29);
            txtNomeCad.TabIndex = 26;
            txtNomeCad.TextAlign = HorizontalAlignment.Center;
            txtNomeCad.TextChanged += txtNomeCad_TextChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.White;
            btnLimpar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLimpar.Location = new Point(847, 331);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(203, 54);
            btnLimpar.TabIndex = 46;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // TelaAtualizarDados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1091, 660);
            Controls.Add(btnLimpar);
            Controls.Add(dtDatanasc);
            Controls.Add(txtComplemento);
            Controls.Add(cBoxEstado);
            Controls.Add(txtRenda);
            Controls.Add(txtLogradouro);
            Controls.Add(txtNumeroLogra);
            Controls.Add(pictureBox1);
            Controls.Add(lblAtzCadastro);
            Controls.Add(btVoltarUpdate);
            Controls.Add(btAtuaizaInfo);
            Controls.Add(txtConfSenhaUpDate);
            Controls.Add(txtSenhaUpdate);
            Controls.Add(txtCidade);
            Controls.Add(txtCepCad);
            Controls.Add(txtGeneroCad);
            Controls.Add(txtEmailCad);
            Controls.Add(txtCelCad);
            Controls.Add(txtRgCad);
            Controls.Add(txtCpfCad);
            Controls.Add(txtNomeCad);
            Name = "TelaAtualizarDados";
            Text = "TelaAtualizarDados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtDatanasc;
        private TextBox txtComplemento;
        private ComboBox cBoxEstado;
        private TextBox txtRenda;
        private TextBox txtLogradouro;
        private TextBox txtNumeroLogra;
        private PictureBox pictureBox1;
        private Label lblAtzCadastro;
        private Button btVoltarUpdate;
        private Button btAtuaizaInfo;
        private TextBox txtConfSenhaUpDate;
        private TextBox txtSenhaUpdate;
        private TextBox txtCidade;
        private TextBox txtCepCad;
        private TextBox txtGeneroCad;
        private TextBox txtEmailCad;
        private TextBox txtCelCad;
        private TextBox txtRgCad;
        private TextBox txtCpfCad;
        private TextBox txtNomeCad;
        private Button btnLimpar;
    }
}