namespace PrjtAula01
{
    partial class TelaAlternaConta
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
            cbxAlternaConta = new ComboBox();
            textBox1 = new TextBox();
            btnAlternarConta = new Button();
            SuspendLayout();
            // 
            // cbxAlternaConta
            // 
            cbxAlternaConta.FormattingEnabled = true;
            cbxAlternaConta.Location = new Point(226, 84);
            cbxAlternaConta.Name = "cbxAlternaConta";
            cbxAlternaConta.Size = new Size(269, 23);
            cbxAlternaConta.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(226, 166);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 1;
            // 
            // btnAlternarConta
            // 
            btnAlternarConta.Location = new Point(281, 280);
            btnAlternarConta.Name = "btnAlternarConta";
            btnAlternarConta.Size = new Size(156, 42);
            btnAlternarConta.TabIndex = 2;
            btnAlternarConta.Text = "Alternar conta";
            btnAlternarConta.UseVisualStyleBackColor = true;
            btnAlternarConta.Click += button1_Click;
            // 
            // TelaAlternaConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAlternarConta);
            Controls.Add(textBox1);
            Controls.Add(cbxAlternaConta);
            Name = "TelaAlternaConta";
            Text = "TelaAlternaConta";
            Load += TelaAlternaConta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxAlternaConta;
        private TextBox textBox1;
        private Button btnAlternarConta;
    }
}