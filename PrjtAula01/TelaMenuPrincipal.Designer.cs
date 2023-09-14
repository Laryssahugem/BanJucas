namespace PrjtAula01
{
    partial class TelaMenuPrincipal
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
            menuStrip1 = new MenuStrip();
            logarToolStripMenuItem1 = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem1 = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            depósitarToolStripMenuItem = new ToolStripMenuItem();
            sacarToolStripMenuItem1 = new ToolStripMenuItem();
            tranferirToolStripMenuItem1 = new ToolStripMenuItem();
            agendarPagamentoToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { logarToolStripMenuItem1, cadastrarToolStripMenuItem, criarContaToolStripMenuItem1, operaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // logarToolStripMenuItem1
            // 
            logarToolStripMenuItem1.Name = "logarToolStripMenuItem1";
            logarToolStripMenuItem1.Size = new Size(49, 20);
            logarToolStripMenuItem1.Text = "Logar";
            logarToolStripMenuItem1.Click += logarToolStripMenuItem1_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(69, 20);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click_1;
            // 
            // criarContaToolStripMenuItem1
            // 
            criarContaToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { criarContaToolStripMenuItem, alterarToolStripMenuItem });
            criarContaToolStripMenuItem1.Name = "criarContaToolStripMenuItem1";
            criarContaToolStripMenuItem1.Size = new Size(51, 20);
            criarContaToolStripMenuItem1.Text = "Conta";
            criarContaToolStripMenuItem1.Click += criarContaToolStripMenuItem1_Click;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(134, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            criarContaToolStripMenuItem.Click += criarContaToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(134, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depósitarToolStripMenuItem, sacarToolStripMenuItem1, tranferirToolStripMenuItem1, agendarPagamentoToolStripMenuItem1 });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // depósitarToolStripMenuItem
            // 
            depósitarToolStripMenuItem.Name = "depósitarToolStripMenuItem";
            depósitarToolStripMenuItem.Size = new Size(183, 22);
            depósitarToolStripMenuItem.Text = "Depósitar";
            // 
            // sacarToolStripMenuItem1
            // 
            sacarToolStripMenuItem1.Name = "sacarToolStripMenuItem1";
            sacarToolStripMenuItem1.Size = new Size(183, 22);
            sacarToolStripMenuItem1.Text = "Sacar";
            // 
            // tranferirToolStripMenuItem1
            // 
            tranferirToolStripMenuItem1.Name = "tranferirToolStripMenuItem1";
            tranferirToolStripMenuItem1.Size = new Size(183, 22);
            tranferirToolStripMenuItem1.Text = "Tranferir";
            // 
            // agendarPagamentoToolStripMenuItem1
            // 
            agendarPagamentoToolStripMenuItem1.Name = "agendarPagamentoToolStripMenuItem1";
            agendarPagamentoToolStripMenuItem1.Size = new Size(183, 22);
            agendarPagamentoToolStripMenuItem1.Text = "Agendar Pagamento";
            // 
            // TelaMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 554);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaMenuPrincipal";
            Text = "Menu Principal";
            Load += TelaLogin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem logarToolStripMenuItem1;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem1;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem depósitarToolStripMenuItem;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem sacarToolStripMenuItem1;
        private ToolStripMenuItem tranferirToolStripMenuItem1;
        private ToolStripMenuItem agendarPagamentoToolStripMenuItem1;
    }
}