namespace PrjtAula01
{
    partial class TelaAlterarSenha
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
            btnAlterarSenha = new Button();
            textAlterarSenha = new TextBox();
            txtConfAlterarSenha = new TextBox();
            SuspendLayout();
            // 
            // btnAlterarSenha
            // 
            btnAlterarSenha.Location = new Point(250, 344);
            btnAlterarSenha.Name = "btnAlterarSenha";
            btnAlterarSenha.Size = new Size(251, 52);
            btnAlterarSenha.TabIndex = 0;
            btnAlterarSenha.Text = "Atualizar";
            btnAlterarSenha.UseVisualStyleBackColor = true;
            btnAlterarSenha.Click += btnAlterarSenha_Click;
            // 
            // textAlterarSenha
            // 
            textAlterarSenha.Location = new Point(241, 109);
            textAlterarSenha.Name = "textAlterarSenha";
            textAlterarSenha.Size = new Size(260, 23);
            textAlterarSenha.TabIndex = 1;
            // 
            // txtConfAlterarSenha
            // 
            txtConfAlterarSenha.Location = new Point(241, 195);
            txtConfAlterarSenha.Name = "txtConfAlterarSenha";
            txtConfAlterarSenha.Size = new Size(260, 23);
            txtConfAlterarSenha.TabIndex = 2;
            // 
            // TelaAlterarSenha
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 542);
            Controls.Add(txtConfAlterarSenha);
            Controls.Add(textAlterarSenha);
            Controls.Add(btnAlterarSenha);
            Name = "TelaAlterarSenha";
            Text = "TelaAlterarSenha";
            Load += TelaAlterarSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlterarSenha;
        private TextBox textAlterarSenha;
        private TextBox txtConfAlterarSenha;
    }
}