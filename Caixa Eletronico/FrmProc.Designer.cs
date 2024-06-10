namespace Caixa_Eletronico
{
    partial class FrmProc
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
            NumValor = new NumericUpDown();
            label2 = new Label();
            TxtConta = new TextBox();
            BtnEnviar = new Button();
            label1 = new Label();
            LblOpcao = new Label();
            ((System.ComponentModel.ISupportInitialize)NumValor).BeginInit();
            SuspendLayout();
            // 
            // NumValor
            // 
            NumValor.Location = new Point(154, 94);
            NumValor.Name = "NumValor";
            NumValor.Size = new Size(120, 23);
            NumValor.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 138);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Conta de destino:";
            label2.Visible = false;
            // 
            // TxtConta
            // 
            TxtConta.Location = new Point(154, 156);
            TxtConta.Name = "TxtConta";
            TxtConta.Size = new Size(120, 23);
            TxtConta.TabIndex = 3;
            TxtConta.Visible = false;
            // 
            // BtnEnviar
            // 
            BtnEnviar.Location = new Point(154, 210);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(120, 23);
            BtnEnviar.TabIndex = 4;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 76);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 5;
            label1.Text = "Valor:";
            // 
            // LblOpcao
            // 
            LblOpcao.AutoSize = true;
            LblOpcao.Location = new Point(154, 32);
            LblOpcao.Name = "LblOpcao";
            LblOpcao.Size = new Size(0, 15);
            LblOpcao.TabIndex = 6;
            // 
            // FrmProc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 283);
            Controls.Add(LblOpcao);
            Controls.Add(label1);
            Controls.Add(BtnEnviar);
            Controls.Add(TxtConta);
            Controls.Add(label2);
            Controls.Add(NumValor);
            Name = "FrmProc";
            Text = "FrmProc";
            Load += FrmProc_Load;
            ((System.ComponentModel.ISupportInitialize)NumValor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumValor;
        private Label label2;
        private TextBox TxtConta;
        private Button BtnEnviar;
        private Label label1;
        private Label LblOpcao;
    }
}