namespace PrjtAula01
{
    partial class TelaLogin
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
            operaçõesToolStripMenuItem1 = new ToolStripMenuItem();
            deposítarToolStripMenuItem = new ToolStripMenuItem();
            sacarToolStripMenuItem = new ToolStripMenuItem();
            tranferirToolStripMenuItem = new ToolStripMenuItem();
            agendarPagamentoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            criarContaToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { logarToolStripMenuItem1, cadastrarToolStripMenuItem, operaçõesToolStripMenuItem1 });
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
            // operaçõesToolStripMenuItem1
            // 
            operaçõesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { deposítarToolStripMenuItem, sacarToolStripMenuItem, tranferirToolStripMenuItem, agendarPagamentoToolStripMenuItem, toolStripSeparator1, criarContaToolStripMenuItem, alterarToolStripMenuItem });
            operaçõesToolStripMenuItem1.Enabled = false;
            operaçõesToolStripMenuItem1.Name = "operaçõesToolStripMenuItem1";
            operaçõesToolStripMenuItem1.Size = new Size(75, 20);
            operaçõesToolStripMenuItem1.Text = "Operações";
            // 
            // deposítarToolStripMenuItem
            // 
            deposítarToolStripMenuItem.Name = "deposítarToolStripMenuItem";
            deposítarToolStripMenuItem.Size = new Size(183, 22);
            deposítarToolStripMenuItem.Text = "Depósitar";
            deposítarToolStripMenuItem.Click += deposítarToolStripMenuItem_Click;
            // 
            // sacarToolStripMenuItem
            // 
            sacarToolStripMenuItem.Name = "sacarToolStripMenuItem";
            sacarToolStripMenuItem.Size = new Size(183, 22);
            sacarToolStripMenuItem.Text = "Sacar";
            // 
            // tranferirToolStripMenuItem
            // 
            tranferirToolStripMenuItem.Name = "tranferirToolStripMenuItem";
            tranferirToolStripMenuItem.Size = new Size(183, 22);
            tranferirToolStripMenuItem.Text = "Tranferir";
            // 
            // agendarPagamentoToolStripMenuItem
            // 
            agendarPagamentoToolStripMenuItem.Name = "agendarPagamentoToolStripMenuItem";
            agendarPagamentoToolStripMenuItem.Size = new Size(183, 22);
            agendarPagamentoToolStripMenuItem.Text = "Agendar Pagamento";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(180, 6);
            // 
            // criarContaToolStripMenuItem
            // 
            criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            criarContaToolStripMenuItem.Size = new Size(183, 22);
            criarContaToolStripMenuItem.Text = "Criar Conta";
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(183, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // TelaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 554);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "TelaLogin";
            Text = "TelaLogin";
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
        private ToolStripMenuItem operaçõesToolStripMenuItem1;
        private ToolStripMenuItem deposítarToolStripMenuItem;
        private ToolStripMenuItem sacarToolStripMenuItem;
        private ToolStripMenuItem tranferirToolStripMenuItem;
        private ToolStripMenuItem agendarPagamentoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem criarContaToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
    }
}