namespace Caixa_Eletronico
{
    partial class FrmPrincipal
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
            LblSaldo = new Label();
            label1 = new Label();
            BtnExtrato = new Button();
            BtnTransferir = new Button();
            BtnDepositar = new Button();
            BtnSacar = new Button();
            BtnVoltar = new Button();
            SuspendLayout();
            // 
            // LblSaldo
            // 
            LblSaldo.AutoSize = true;
            LblSaldo.Location = new Point(168, 16);
            LblSaldo.Name = "LblSaldo";
            LblSaldo.Size = new Size(0, 15);
            LblSaldo.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 16);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 13;
            label1.Text = "Saldo: ";
            // 
            // BtnExtrato
            // 
            BtnExtrato.Location = new Point(12, 161);
            BtnExtrato.Name = "BtnExtrato";
            BtnExtrato.Size = new Size(75, 23);
            BtnExtrato.TabIndex = 12;
            BtnExtrato.Text = "Extrato";
            BtnExtrato.UseVisualStyleBackColor = true;
            BtnExtrato.Click += BtnExtrato_Click;
            // 
            // BtnTransferir
            // 
            BtnTransferir.Location = new Point(12, 132);
            BtnTransferir.Name = "BtnTransferir";
            BtnTransferir.Size = new Size(75, 23);
            BtnTransferir.TabIndex = 11;
            BtnTransferir.Text = "Transferir";
            BtnTransferir.UseVisualStyleBackColor = true;
            BtnTransferir.Click += BtnTransferir_Click;
            // 
            // BtnDepositar
            // 
            BtnDepositar.Location = new Point(12, 103);
            BtnDepositar.Name = "BtnDepositar";
            BtnDepositar.Size = new Size(75, 23);
            BtnDepositar.TabIndex = 10;
            BtnDepositar.Text = "Depositar";
            BtnDepositar.UseVisualStyleBackColor = true;
            BtnDepositar.Click += BtnDepositar_Click;
            // 
            // BtnSacar
            // 
            BtnSacar.Location = new Point(12, 74);
            BtnSacar.Name = "BtnSacar";
            BtnSacar.Size = new Size(75, 23);
            BtnSacar.TabIndex = 9;
            BtnSacar.Text = "Sacar";
            BtnSacar.UseVisualStyleBackColor = true;
            BtnSacar.Click += BtnSacar_Click;
            // 
            // BtnVoltar
            // 
            BtnVoltar.Location = new Point(12, 12);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(75, 23);
            BtnVoltar.TabIndex = 8;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 258);
            Controls.Add(LblSaldo);
            Controls.Add(label1);
            Controls.Add(BtnExtrato);
            Controls.Add(BtnTransferir);
            Controls.Add(BtnDepositar);
            Controls.Add(BtnSacar);
            Controls.Add(BtnVoltar);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSaldo;
        private Label label1;
        private Button BtnExtrato;
        private Button BtnTransferir;
        private Button BtnDepositar;
        private Button BtnSacar;
        private Button BtnVoltar;
    }
}