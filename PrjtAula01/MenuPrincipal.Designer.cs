namespace PrjtAula01
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            extratoLista = new ListBox();
            btConfig = new Button();
            pictureBox1 = new PictureBox();
            depositar = new Button();
            sacar = new Button();
            agdPagto = new Button();
            pagarTransferir = new Button();
            sairMenu = new Button();
            lblOla = new Label();
            lblNomeUser = new Label();
            lblSaldo = new Label();
            lblSaldoVal = new Label();
            lblExtrato = new Label();
            lblOperacoes = new Label();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // extratoLista
            // 
            extratoLista.BackColor = Color.White;
            extratoLista.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            extratoLista.FormattingEnabled = true;
            extratoLista.ItemHeight = 37;
            extratoLista.Items.AddRange(new object[] { "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )", "", "      ( mostrar extrato em lista )" });
            extratoLista.Location = new Point(86, 182);
            extratoLista.Name = "extratoLista";
            extratoLista.Size = new Size(406, 300);
            extratoLista.TabIndex = 0;
            extratoLista.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btConfig
            // 
            btConfig.BackColor = Color.White;
            btConfig.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btConfig.Location = new Point(86, 519);
            btConfig.Name = "btConfig";
            btConfig.Size = new Size(406, 51);
            btConfig.TabIndex = 1;
            btConfig.Text = "Configurações";
            btConfig.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(552, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 177);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // depositar
            // 
            depositar.BackColor = Color.White;
            depositar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            depositar.Location = new Point(841, 182);
            depositar.Name = "depositar";
            depositar.Size = new Size(290, 42);
            depositar.TabIndex = 3;
            depositar.Text = "Depositar";
            depositar.UseVisualStyleBackColor = false;
            depositar.Click += depositar_Click;
            // 
            // sacar
            // 
            sacar.BackColor = Color.White;
            sacar.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sacar.Location = new Point(841, 268);
            sacar.Name = "sacar";
            sacar.Size = new Size(290, 42);
            sacar.TabIndex = 4;
            sacar.Text = "Sacar";
            sacar.UseVisualStyleBackColor = false;
            sacar.Click += sacar_Click;
            // 
            // agdPagto
            // 
            agdPagto.BackColor = Color.White;
            agdPagto.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            agdPagto.Location = new Point(841, 355);
            agdPagto.Name = "agdPagto";
            agdPagto.Size = new Size(290, 42);
            agdPagto.TabIndex = 5;
            agdPagto.Text = "Agendar Pagamento";
            agdPagto.UseVisualStyleBackColor = false;
            agdPagto.Click += agdPagto_Click;
            // 
            // pagarTransferir
            // 
            pagarTransferir.BackColor = Color.White;
            pagarTransferir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            pagarTransferir.Location = new Point(841, 440);
            pagarTransferir.Name = "pagarTransferir";
            pagarTransferir.Size = new Size(290, 42);
            pagarTransferir.TabIndex = 6;
            pagarTransferir.Text = "Pagar / Transferir";
            pagarTransferir.UseVisualStyleBackColor = false;
            // 
            // sairMenu
            // 
            sairMenu.BackColor = Color.White;
            sairMenu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            sairMenu.Location = new Point(998, 528);
            sairMenu.Name = "sairMenu";
            sairMenu.Size = new Size(133, 42);
            sairMenu.TabIndex = 7;
            sairMenu.Text = "Sair";
            sairMenu.UseVisualStyleBackColor = false;
            sairMenu.Click += sairMenu_Click;
            // 
            // lblOla
            // 
            lblOla.AutoSize = true;
            lblOla.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOla.ForeColor = Color.Black;
            lblOla.Location = new Point(86, 23);
            lblOla.Name = "lblOla";
            lblOla.Size = new Size(64, 37);
            lblOla.TabIndex = 8;
            lblOla.Text = "Olá,";
            // 
            // lblNomeUser
            // 
            lblNomeUser.AutoSize = true;
            lblNomeUser.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNomeUser.ForeColor = Color.Black;
            lblNomeUser.Location = new Point(156, 23);
            lblNomeUser.Name = "lblNomeUser";
            lblNomeUser.Size = new Size(108, 37);
            lblNomeUser.TabIndex = 9;
            lblNomeUser.Text = "Usuário";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(86, 77);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 10;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(182, 77);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 11;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblExtrato
            // 
            lblExtrato.AutoSize = true;
            lblExtrato.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblExtrato.ForeColor = Color.Black;
            lblExtrato.Location = new Point(86, 131);
            lblExtrato.Name = "lblExtrato";
            lblExtrato.Size = new Size(106, 37);
            lblExtrato.TabIndex = 12;
            lblExtrato.Text = "Extrato:";
            // 
            // lblOperacoes
            // 
            lblOperacoes.AutoSize = true;
            lblOperacoes.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOperacoes.ForeColor = Color.Black;
            lblOperacoes.Location = new Point(841, 116);
            lblOperacoes.Name = "lblOperacoes";
            lblOperacoes.Size = new Size(149, 37);
            lblOperacoes.TabIndex = 13;
            lblOperacoes.Text = "Operações:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(86, 182);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(406, 304);
            listBox1.TabIndex = 14;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1217, 638);
            Controls.Add(listBox1);
            Controls.Add(lblOperacoes);
            Controls.Add(lblExtrato);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblNomeUser);
            Controls.Add(lblOla);
            Controls.Add(sairMenu);
            Controls.Add(pagarTransferir);
            Controls.Add(agdPagto);
            Controls.Add(sacar);
            Controls.Add(depositar);
            Controls.Add(pictureBox1);
            Controls.Add(btConfig);
            Controls.Add(extratoLista);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
            Load += MenuPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox extratoLista;
        private Button btConfig;
        private PictureBox pictureBox1;
        private Button depositar;
        private Button sacar;
        private Button agdPagto;
        private Button pagarTransferir;
        private Button sairMenu;
        private Label lblOla;
        private Label lblNomeUser;
        private Label lblSaldo;
        private Label lblSaldoVal;
        private Label lblExtrato;
        private Label lblOperacoes;
        private ListBox listBox1;
    }
}