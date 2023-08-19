namespace PrjtAula01
{
    partial class TelaAgendamento
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
            lblPagamento = new Label();
            lblSaldo = new Label();
            lblSaldoVal = new Label();
            label3 = new Label();
            txtValorTransf = new TextBox();
            btConfirmarTransf = new Button();
            lblVoltarTransf = new Button();
            label1 = new Label();
            dtDataAgendamento = new DateTimePicker();
            button1 = new Button();
            listAgendamentos = new ListBox();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamento.ForeColor = Color.White;
            lblPagamento.Location = new Point(37, 65);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(197, 37);
            lblPagamento.TabIndex = 20;
            lblPagamento.Text = "Agendamentos";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(37, 134);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 21;
            lblSaldo.Text = "Saldo:";
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(133, 134);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 22;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(37, 337);
            label3.Name = "label3";
            label3.Size = new Size(273, 32);
            label3.TabIndex = 34;
            label3.Text = "Insira o valor a ser pago:";
            // 
            // txtValorTransf
            // 
            txtValorTransf.BackColor = Color.White;
            txtValorTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTransf.Location = new Point(37, 399);
            txtValorTransf.Name = "txtValorTransf";
            txtValorTransf.PlaceholderText = "0,00";
            txtValorTransf.Size = new Size(314, 35);
            txtValorTransf.TabIndex = 35;
            txtValorTransf.TextAlign = HorizontalAlignment.Center;
            txtValorTransf.TextChanged += txtValorTransf_TextChanged;
            // 
            // btConfirmarTransf
            // 
            btConfirmarTransf.BackColor = Color.White;
            btConfirmarTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarTransf.ForeColor = Color.Black;
            btConfirmarTransf.Location = new Point(50, 491);
            btConfirmarTransf.Name = "btConfirmarTransf";
            btConfirmarTransf.Size = new Size(292, 48);
            btConfirmarTransf.TabIndex = 36;
            btConfirmarTransf.Text = "Confirmar Agendamento";
            btConfirmarTransf.UseVisualStyleBackColor = false;
            // 
            // lblVoltarTransf
            // 
            lblVoltarTransf.BackColor = Color.White;
            lblVoltarTransf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarTransf.Location = new Point(878, 559);
            lblVoltarTransf.Name = "lblVoltarTransf";
            lblVoltarTransf.Size = new Size(133, 42);
            lblVoltarTransf.TabIndex = 37;
            lblVoltarTransf.Text = "Voltar";
            lblVoltarTransf.UseVisualStyleBackColor = false;
            lblVoltarTransf.Click += lblVoltarTransf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(37, 209);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 38;
            label1.Text = "Escolha data de pagamento:";
            // 
            // dtDataAgendamento
            // 
            dtDataAgendamento.CalendarForeColor = Color.IndianRed;
            dtDataAgendamento.CalendarMonthBackground = Color.FromArgb(255, 128, 255);
            dtDataAgendamento.CalendarTitleBackColor = SystemColors.ActiveCaptionText;
            dtDataAgendamento.CalendarTitleForeColor = SystemColors.ButtonHighlight;
            dtDataAgendamento.CalendarTrailingForeColor = Color.FromArgb(255, 128, 128);
            dtDataAgendamento.Location = new Point(37, 268);
            dtDataAgendamento.Name = "dtDataAgendamento";
            dtDataAgendamento.Size = new Size(314, 23);
            dtDataAgendamento.TabIndex = 40;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(797, 494);
            button1.Name = "button1";
            button1.Size = new Size(273, 42);
            button1.TabIndex = 41;
            button1.Text = "Visualizar Agendamentos";
            button1.UseVisualStyleBackColor = false;
            // 
            // listAgendamentos
            // 
            listAgendamentos.FormattingEnabled = true;
            listAgendamentos.ItemHeight = 15;
            listAgendamentos.Location = new Point(691, 200);
            listAgendamentos.Name = "listAgendamentos";
            listAgendamentos.Size = new Size(462, 274);
            listAgendamentos.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(691, 139);
            label2.Name = "label2";
            label2.Size = new Size(181, 32);
            label2.TabIndex = 43;
            label2.Text = "Agendamentos:";
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(50, 559);
            button2.Name = "button2";
            button2.Size = new Size(292, 48);
            button2.TabIndex = 44;
            button2.Text = "Cancelar Agendamento";
            button2.UseVisualStyleBackColor = false;
            // 
            // TelaAgendamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1191, 631);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listAgendamentos);
            Controls.Add(button1);
            Controls.Add(dtDataAgendamento);
            Controls.Add(label1);
            Controls.Add(lblVoltarTransf);
            Controls.Add(btConfirmarTransf);
            Controls.Add(txtValorTransf);
            Controls.Add(label3);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaAgendamento";
            Text = "TelaAgendamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPagamento;
        private Label lblSaldo;
        private Label lblSaldoVal;
        private Label label3;
        private TextBox txtValorTransf;
        private Button btConfirmarTransf;
        private Button lblVoltarTransf;
        private Label label1;
        private DateTimePicker dtDataAgendamento;
        private Button button1;
        private ListBox listAgendamentos;
        private Label label2;
        private Button button2;
    }
}