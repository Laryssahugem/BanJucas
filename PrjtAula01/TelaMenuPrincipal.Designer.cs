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
            cadastrarToolStripMenuItem1 = new ToolStripMenuItem();
            contaToolStripMenuItem = new ToolStripMenuItem();
            alternaContaToolStripMenuItem = new ToolStripMenuItem();
            alterarDadosToolStripMenuItem = new ToolStripMenuItem();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            tranToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            agendamentoToolStripMenuItem = new ToolStripMenuItem();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { logarToolStripMenuItem1, cadastrarToolStripMenuItem1, contaToolStripMenuItem, operaçõesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // logarToolStripMenuItem1
            // 
            logarToolStripMenuItem1.Name = "logarToolStripMenuItem1";
            logarToolStripMenuItem1.Size = new Size(49, 20);
            logarToolStripMenuItem1.Text = "Logar";
            logarToolStripMenuItem1.Click += logarToolStripMenuItem1_Click;
            // 
            // cadastrarToolStripMenuItem1
            // 
            cadastrarToolStripMenuItem1.Name = "cadastrarToolStripMenuItem1";
            cadastrarToolStripMenuItem1.Size = new Size(69, 20);
            cadastrarToolStripMenuItem1.Text = "Cadastrar";
            cadastrarToolStripMenuItem1.Click += cadastrarToolStripMenuItem1_Click;
            // 
            // contaToolStripMenuItem
            // 
            contaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alternaContaToolStripMenuItem, alterarDadosToolStripMenuItem, alterarSenhaToolStripMenuItem });
            contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            contaToolStripMenuItem.Size = new Size(51, 20);
            contaToolStripMenuItem.Text = "Conta";
            // 
            // alternaContaToolStripMenuItem
            // 
            alternaContaToolStripMenuItem.Name = "alternaContaToolStripMenuItem";
            alternaContaToolStripMenuItem.Size = new Size(180, 22);
            alternaContaToolStripMenuItem.Text = "Alternar Conta";
            alternaContaToolStripMenuItem.Click += alternaContaToolStripMenuItem_Click;
            // 
            // alterarDadosToolStripMenuItem
            // 
            alterarDadosToolStripMenuItem.Name = "alterarDadosToolStripMenuItem";
            alterarDadosToolStripMenuItem.Size = new Size(180, 22);
            alterarDadosToolStripMenuItem.Text = "Alterar Dados";
            alterarDadosToolStripMenuItem.Click += alterarDadosToolStripMenuItem_Click;
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(180, 22);
            alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            alterarSenhaToolStripMenuItem.Click += alterarSenhaToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tranToolStripMenuItem, depósitoToolStripMenuItem, saqueToolStripMenuItem, agendamentoToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // tranToolStripMenuItem
            // 
            tranToolStripMenuItem.Name = "tranToolStripMenuItem";
            tranToolStripMenuItem.Size = new Size(180, 22);
            tranToolStripMenuItem.Text = "Transferência";
            tranToolStripMenuItem.Click += tranToolStripMenuItem_Click;
            // 
            // depósitoToolStripMenuItem
            // 
            depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            depósitoToolStripMenuItem.Size = new Size(180, 22);
            depósitoToolStripMenuItem.Text = "Depósito";
            depósitoToolStripMenuItem.Click += depósitoToolStripMenuItem_Click;
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(180, 22);
            saqueToolStripMenuItem.Text = "Saque";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // agendamentoToolStripMenuItem
            // 
            agendamentoToolStripMenuItem.Name = "agendamentoToolStripMenuItem";
            agendamentoToolStripMenuItem.Size = new Size(180, 22);
            agendamentoToolStripMenuItem.Text = "Agendamento";
            agendamentoToolStripMenuItem.Click += agendamentoToolStripMenuItem_Click;
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(32, 19);
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(134, 22);
            alterarToolStripMenuItem.Text = "Alterar";
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
            Load += TelaMenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem logarToolStripMenuItem1;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem1;
        private ToolStripMenuItem contaToolStripMenuItem;
        private ToolStripMenuItem alternaContaToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem tranToolStripMenuItem;
        private ToolStripMenuItem alterarDadosToolStripMenuItem;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem agendamentoToolStripMenuItem;
    }
}