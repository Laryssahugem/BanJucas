namespace PrjtAula01
{
    partial class TelaPagamento
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
            txtNomeDestino = new TextBox();
            txtNumConta = new TextBox();
            txtCodBarras = new TextBox();
            lblSaldoVal = new Label();
            lblSaldo = new Label();
            lblPagamento = new Label();
            lblValorTransf = new Label();
            txtValorTransf = new TextBox();
            btConfirmarTransf = new Button();
            lblTransfConfirmada = new Label();
            lblVoltarTransf = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtNomeDestino
            // 
            txtNomeDestino.BackColor = Color.White;
            txtNomeDestino.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNomeDestino.Location = new Point(90, 388);
            txtNomeDestino.Name = "txtNomeDestino";
            txtNomeDestino.PlaceholderText = "CPF/CNPJ do Beneficiário";
            txtNomeDestino.Size = new Size(379, 29);
            txtNomeDestino.TabIndex = 17;
            txtNomeDestino.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNumConta
            // 
            txtNumConta.BackColor = Color.White;
            txtNumConta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumConta.Location = new Point(90, 315);
            txtNumConta.Name = "txtNumConta";
            txtNumConta.PlaceholderText = "Número da conta destino";
            txtNumConta.Size = new Size(379, 29);
            txtNumConta.TabIndex = 16;
            txtNumConta.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCodBarras
            // 
            txtCodBarras.BackColor = Color.White;
            txtCodBarras.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCodBarras.Location = new Point(90, 243);
            txtCodBarras.Name = "txtCodBarras";
            txtCodBarras.PlaceholderText = "0000.0000.0000.0000.000000.0.000000000";
            txtCodBarras.Size = new Size(379, 29);
            txtCodBarras.TabIndex = 15;
            txtCodBarras.TextAlign = HorizontalAlignment.Center;
            // 
            // lblSaldoVal
            // 
            lblSaldoVal.AutoSize = true;
            lblSaldoVal.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldoVal.ForeColor = Color.Black;
            lblSaldoVal.Location = new Point(186, 141);
            lblSaldoVal.Name = "lblSaldoVal";
            lblSaldoVal.Size = new Size(121, 37);
            lblSaldoVal.TabIndex = 21;
            lblSaldoVal.Text = "R$ 50,33";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblSaldo.ForeColor = Color.Black;
            lblSaldo.Location = new Point(90, 141);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(90, 37);
            lblSaldo.TabIndex = 20;
            lblSaldo.Text = "Saldo:";
            // 
            // lblPagamento
            // 
            lblPagamento.AutoSize = true;
            lblPagamento.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblPagamento.ForeColor = Color.Black;
            lblPagamento.Location = new Point(90, 65);
            lblPagamento.Name = "lblPagamento";
            lblPagamento.Size = new Size(163, 37);
            lblPagamento.TabIndex = 19;
            lblPagamento.Text = "Pagamentos";
            // 
            // lblValorTransf
            // 
            lblValorTransf.AutoSize = true;
            lblValorTransf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblValorTransf.ForeColor = Color.Black;
            lblValorTransf.Location = new Point(706, 146);
            lblValorTransf.Name = "lblValorTransf";
            lblValorTransf.Size = new Size(273, 32);
            lblValorTransf.TabIndex = 30;
            lblValorTransf.Text = "Insira o valor a ser pago:";
            // 
            // txtValorTransf
            // 
            txtValorTransf.BackColor = Color.White;
            txtValorTransf.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtValorTransf.Location = new Point(706, 236);
            txtValorTransf.Name = "txtValorTransf";
            txtValorTransf.PlaceholderText = "0,00";
            txtValorTransf.Size = new Size(292, 35);
            txtValorTransf.TabIndex = 31;
            txtValorTransf.TextAlign = HorizontalAlignment.Center;
            // 
            // btConfirmarTransf
            // 
            btConfirmarTransf.BackColor = Color.White;
            btConfirmarTransf.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btConfirmarTransf.ForeColor = Color.Black;
            btConfirmarTransf.Location = new Point(706, 315);
            btConfirmarTransf.Name = "btConfirmarTransf";
            btConfirmarTransf.Size = new Size(292, 48);
            btConfirmarTransf.TabIndex = 32;
            btConfirmarTransf.Text = "Confirmar Pagamento";
            btConfirmarTransf.UseVisualStyleBackColor = false;
            btConfirmarTransf.Click += btConfirmarTransf_Click;
            // 
            // lblTransfConfirmada
            // 
            lblTransfConfirmada.AutoSize = true;
            lblTransfConfirmada.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTransfConfirmada.ForeColor = Color.White;
            lblTransfConfirmada.Location = new Point(703, 430);
            lblTransfConfirmada.Name = "lblTransfConfirmada";
            lblTransfConfirmada.Size = new Size(276, 37);
            lblTransfConfirmada.TabIndex = 33;
            lblTransfConfirmada.Text = "Pagamento realizado!";
            // 
            // lblVoltarTransf
            // 
            lblVoltarTransf.BackColor = Color.White;
            lblVoltarTransf.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblVoltarTransf.Location = new Point(799, 501);
            lblVoltarTransf.Name = "lblVoltarTransf";
            lblVoltarTransf.Size = new Size(133, 42);
            lblVoltarTransf.TabIndex = 34;
            lblVoltarTransf.Text = "Voltar";
            lblVoltarTransf.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(90, 203);
            label1.Name = "label1";
            label1.Size = new Size(229, 25);
            label1.TabIndex = 35;
            label1.Text = "Digite o código de barras:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(90, 360);
            label2.Name = "label2";
            label2.Size = new Size(256, 25);
            label2.TabIndex = 36;
            label2.Text = "Identificação do Beneficiário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(90, 287);
            label3.Name = "label3";
            label3.Size = new Size(199, 25);
            label3.TabIndex = 37;
            label3.Text = "Nome do Beneficiário:";
            // 
            // TelaPagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(82, 143, 235);
            ClientSize = new Size(1102, 634);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblVoltarTransf);
            Controls.Add(lblTransfConfirmada);
            Controls.Add(btConfirmarTransf);
            Controls.Add(txtValorTransf);
            Controls.Add(lblValorTransf);
            Controls.Add(txtNomeDestino);
            Controls.Add(txtNumConta);
            Controls.Add(txtCodBarras);
            Controls.Add(lblSaldoVal);
            Controls.Add(lblSaldo);
            Controls.Add(lblPagamento);
            Name = "TelaPagamento";
            Text = "TelaPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeDestino;
        private TextBox txtNumConta;
        private TextBox txtCodBarras;
        private Label lblSaldoVal;
        private Label lblSaldo;
        private Label lblPagamento;
        private Label lblValorTransf;
        private TextBox txtValorTransf;
        private Button btConfirmarTransf;
        private Label lblTransfConfirmada;
        private Button lblVoltarTransf;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}