namespace PrjtAula01
{
    partial class TeleCadastroConta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeleCadastroConta));
            lblDepositoinicial = new Label();
            txtDepositoInicial = new TextBox();
            txtConfSenhaConta = new TextBox();
            txtSenhaConta = new TextBox();
            btVoltarCad = new Button();
            btCriaConta = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblDepositoinicial
            // 
            lblDepositoinicial.AutoSize = true;
            lblDepositoinicial.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDepositoinicial.ForeColor = Color.White;
            lblDepositoinicial.Location = new Point(26, 98);
            lblDepositoinicial.Name = "lblDepositoinicial";
            lblDepositoinicial.Size = new Size(318, 37);
            lblDepositoinicial.TabIndex = 39;
            lblDepositoinicial.Text = "Insira seu Depósito Inicial";
            // 
            // txtDepositoInicial
            // 
            txtDepositoInicial.BackColor = Color.White;
            txtDepositoInicial.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtDepositoInicial.Location = new Point(26, 184);
            txtDepositoInicial.Name = "txtDepositoInicial";
            txtDepositoInicial.PlaceholderText = "R$ 0,00";
            txtDepositoInicial.Size = new Size(318, 43);
            txtDepositoInicial.TabIndex = 40;
            txtDepositoInicial.TextAlign = HorizontalAlignment.Center;
            // 
            // txtConfSenhaConta
            // 
            txtConfSenhaConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfSenhaConta.Location = new Point(646, 205);
            txtConfSenhaConta.Name = "txtConfSenhaConta";
            txtConfSenhaConta.PlaceholderText = "Confirme sua senha";
            txtConfSenhaConta.Size = new Size(318, 33);
            txtConfSenhaConta.TabIndex = 42;
            txtConfSenhaConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSenhaConta
            // 
            txtSenhaConta.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenhaConta.Location = new Point(646, 152);
            txtSenhaConta.Name = "txtSenhaConta";
            txtSenhaConta.PlaceholderText = "Crie sua senha";
            txtSenhaConta.Size = new Size(318, 33);
            txtSenhaConta.TabIndex = 41;
            txtSenhaConta.TextAlign = HorizontalAlignment.Center;
            // 
            // btVoltarCad
            // 
            btVoltarCad.BackColor = Color.White;
            btVoltarCad.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btVoltarCad.Location = new Point(701, 391);
            btVoltarCad.Name = "btVoltarCad";
            btVoltarCad.Size = new Size(203, 54);
            btVoltarCad.TabIndex = 44;
            btVoltarCad.Text = "Voltar";
            btVoltarCad.UseVisualStyleBackColor = false;
            // 
            // btCriaConta
            // 
            btCriaConta.BackColor = Color.White;
            btCriaConta.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btCriaConta.Location = new Point(701, 293);
            btCriaConta.Name = "btCriaConta";
            btCriaConta.Size = new Size(203, 54);
            btCriaConta.TabIndex = 43;
            btCriaConta.Text = "Criar Conta";
            btCriaConta.UseVisualStyleBackColor = false;
            btCriaConta.Click += btCriaConta_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(396, 222);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(646, 72);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 46;
            label1.Text = "Insira sua Senha:";
            // 
            // TeleCadastroConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1006, 653);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btVoltarCad);
            Controls.Add(btCriaConta);
            Controls.Add(txtConfSenhaConta);
            Controls.Add(txtSenhaConta);
            Controls.Add(txtDepositoInicial);
            Controls.Add(lblDepositoinicial);
            Name = "TeleCadastroConta";
            Text = "TelaCadastroConta";
            Load += TeleCadastroConta_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDepositoinicial;
        private TextBox txtDepositoInicial;
        private TextBox txtConfSenhaConta;
        private TextBox txtSenhaConta;
        private Button btVoltarCad;
        private Button btCriaConta;
        private PictureBox pictureBox1;
        private Label label1;
    }
}