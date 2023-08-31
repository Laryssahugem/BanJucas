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
            loginToolStripMenuItem = new ToolStripMenuItem();
            logarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            operaçõesToolStripMenuItem = new ToolStripMenuItem();
            depósitoToolStripMenuItem = new ToolStripMenuItem();
            saqueToolStripMenuItem = new ToolStripMenuItem();
            transferênciaToolStripMenuItem = new ToolStripMenuItem();
            tranfereToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { loginToolStripMenuItem, operaçõesToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1098, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logarToolStripMenuItem, cadastrarToolStripMenuItem });
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(50, 20);
            loginToolStripMenuItem.Text = "Entrar";
            loginToolStripMenuItem.Click += loginToolStripMenuItem_Click;
            // 
            // logarToolStripMenuItem
            // 
            logarToolStripMenuItem.Name = "logarToolStripMenuItem";
            logarToolStripMenuItem.Size = new Size(180, 22);
            logarToolStripMenuItem.Text = "Logar";
            logarToolStripMenuItem.Click += logarToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(180, 22);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            cadastrarToolStripMenuItem.Click += cadastrarToolStripMenuItem_Click;
            // 
            // operaçõesToolStripMenuItem
            // 
            operaçõesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depósitoToolStripMenuItem, saqueToolStripMenuItem, transferênciaToolStripMenuItem, tranfereToolStripMenuItem });
            operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            operaçõesToolStripMenuItem.Size = new Size(75, 20);
            operaçõesToolStripMenuItem.Text = "Operações";
            operaçõesToolStripMenuItem.Visible = false;
            // 
            // depósitoToolStripMenuItem
            // 
            depósitoToolStripMenuItem.Name = "depósitoToolStripMenuItem";
            depósitoToolStripMenuItem.Size = new Size(183, 22);
            depósitoToolStripMenuItem.Text = "Depósitar";
            depósitoToolStripMenuItem.Click += depósitoToolStripMenuItem_Click;
            // 
            // saqueToolStripMenuItem
            // 
            saqueToolStripMenuItem.Name = "saqueToolStripMenuItem";
            saqueToolStripMenuItem.Size = new Size(183, 22);
            saqueToolStripMenuItem.Text = "Sacar";
            saqueToolStripMenuItem.Click += saqueToolStripMenuItem_Click;
            // 
            // transferênciaToolStripMenuItem
            // 
            transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            transferênciaToolStripMenuItem.Size = new Size(183, 22);
            transferênciaToolStripMenuItem.Text = "Agendar Pagamento";
            transferênciaToolStripMenuItem.Click += transferênciaToolStripMenuItem_Click;
            // 
            // tranfereToolStripMenuItem
            // 
            tranfereToolStripMenuItem.Name = "tranfereToolStripMenuItem";
            tranfereToolStripMenuItem.Size = new Size(183, 22);
            tranfereToolStripMenuItem.Text = "Transferir";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(38, 20);
            logoutToolStripMenuItem.Text = "Sair";
            logoutToolStripMenuItem.Visible = false;
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
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem operaçõesToolStripMenuItem;
        private ToolStripMenuItem depósitoToolStripMenuItem;
        private ToolStripMenuItem saqueToolStripMenuItem;
        private ToolStripMenuItem transferênciaToolStripMenuItem;
        private ToolStripMenuItem logarToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem tranfereToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}