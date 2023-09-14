namespace PrjtAula01
{
    partial class TelaDeposito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeposito));
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblDeposito = new Label();
            txtIdentificacao = new TextBox();
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            pictureBox1 = new PictureBox();
            txtValorDeposito = new TextBox();
            lblValorDeposito = new Label();
            btConfirmarDeposito = new Button();
            lblVoltarDeposito = new Button();
            lblDepositoConfirmado = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(190, 150);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 14;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(94, 150);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 13;
            lblSaldo.Text = "Saldo:";
            // 
            // lblDeposito
            // 
            lblDeposito.AutoSize = true;
            lblDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDeposito.ForeColor = Color.Black;
            lblDeposito.Location = new Point(94, 75);
            lblDeposito.Name = "lblDeposito";
            lblDeposito.Size = new Size(125, 37);
            lblDeposito.TabIndex = 12;
            lblDeposito.Text = "Depósito";
            // 
            // txtIdentificacao
            // 
            txtIdentificacao.BackColor = Color.White;
            txtIdentificacao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentificacao.Location = new Point(78, 377);
            txtIdentificacao.Name = "txtIdentificacao";
            txtIdentificacao.PlaceholderText = "Quem está depositando?";
            txtIdentificacao.Size = new Size(300, 29);
            txtIdentificacao.TabIndex = 4;
            txtIdentificacao.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(78, 299);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "Nome do beneficiário";
            txtNomeDestino.Size = new Size(300, 29);
            txtNomeDestino.TabIndex = 3;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(78, 229);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Número da conta destino";
            txtNumConta.Size = new Size(300, 29);
            txtNumConta.TabIndex = 2;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(533, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 177);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // txtValorDeposito
            // 
            txtValorDeposito.BackColor = Color.White;
            txtValorDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorDeposito.Location = new Point(837, 216);
            txtValorDeposito.Name = "txtValorDeposito";
            txtValorDeposito.PlaceholderText = "R$ 0,00";
            txtValorDeposito.Size = new Size(300, 43);
            txtValorDeposito.TabIndex = 5;
            txtValorDeposito.TextAlign = HorizontalAlignment.Center;
            // 
            // lblValorDeposito
            // 
            lblValorDeposito.AutoSize = true;
            lblValorDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorDeposito.ForeColor = Color.Black;
            lblValorDeposito.Location = new Point(822, 150);
            lblValorDeposito.Name = "lblValorDeposito";
            lblValorDeposito.Size = new Size(315, 37);
            lblValorDeposito.TabIndex = 21;
            lblValorDeposito.Text = "Insira o valor a depositar:";
            // 
            // btConfirmarDeposito
            // 
            btConfirmarDeposito.BackColor = Color.Black;
            btConfirmarDeposito.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarDeposito.ForeColor = Color.White;
            btConfirmarDeposito.Location = new Point(837, 320);
            btConfirmarDeposito.Name = "btConfirmarDeposito";
            btConfirmarDeposito.Size = new Size(300, 48);
            btConfirmarDeposito.TabIndex = 6;
            btConfirmarDeposito.Text = "Confirmar depósito";
            btConfirmarDeposito.UseVisualStyleBackColor = false;
            btConfirmarDeposito.Click += btConfirmarDeposito_Click;
            // 
            // lblVoltarDeposito
            // 
            lblVoltarDeposito.BackColor = Color.White;
            lblVoltarDeposito.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarDeposito.Location = new Point(1004, 514);
            lblVoltarDeposito.Name = "lblVoltarDeposito";
            lblVoltarDeposito.Size = new Size(133, 42);
            lblVoltarDeposito.TabIndex = 7;
            lblVoltarDeposito.Text = "Voltar";
            lblVoltarDeposito.UseVisualStyleBackColor = false;
            lblVoltarDeposito.Click += lblVoltarDeposito_Click;
            // 
            // lblDepositoConfirmado
            // 
            lblDepositoConfirmado.AutoSize = true;
            lblDepositoConfirmado.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoConfirmado.ForeColor = Color.White;
            lblDepositoConfirmado.Location = new Point(866, 425);
            lblDepositoConfirmado.Name = "lblDepositoConfirmado";
            lblDepositoConfirmado.Size = new Size(249, 37);
            lblDepositoConfirmado.TabIndex = 24;
            lblDepositoConfirmado.Text = "Depósito realizado!";
            // 
            // TelaDeposito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1222, 642);
            Controls.Add(lblDepositoConfirmado);
            Controls.Add(lblVoltarDeposito);
            Controls.Add(btConfirmarDeposito);
            Controls.Add(lblValorDeposito);
            Controls.Add(txtValorDeposito);
            Controls.Add(pictureBox1);
            Controls.Add(txtIdentificacao);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblDeposito);
            Name = "TelaDeposito";
            Text = "TelaDeposito";
            Load += Extra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblDeposito;
        private TextBox txtIdentificacao;
        private TextBox txtNomeDestino;
        private TextBox txtNumConta;
        private PictureBox pictureBox1;
        private TextBox txtValorDeposito;
        private Label lblValorDeposito;
        private Button btConfirmarDeposito;
        private Button lblVoltarDeposito;
        private Label lblDepositoConfirmado;
    }
}