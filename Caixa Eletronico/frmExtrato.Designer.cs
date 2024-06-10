namespace Caixa_Eletronico
{
    partial class FrmExtrato
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
            DgvExtrato = new DataGridView();
            BtVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).BeginInit();
            SuspendLayout();
            // 
            // DgvExtrato
            // 
            DgvExtrato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvExtrato.Location = new Point(12, 12);
            DgvExtrato.Name = "DgvExtrato";
            DgvExtrato.Size = new Size(504, 297);
            DgvExtrato.TabIndex = 0;
            // 
            // BtVoltar
            // 
            BtVoltar.Location = new Point(522, 150);
            BtVoltar.Name = "BtVoltar";
            BtVoltar.Size = new Size(75, 23);
            BtVoltar.TabIndex = 1;
            BtVoltar.Text = "Voltar";
            BtVoltar.UseVisualStyleBackColor = true;
            BtVoltar.Click += BtVoltar_Click;
            // 
            // FrmExtrato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 321);
            Controls.Add(BtVoltar);
            Controls.Add(DgvExtrato);
            Name = "FrmExtrato";
            Text = "FrmExtrato";
            Load += frmExtrato_Load;
            ((System.ComponentModel.ISupportInitialize)DgvExtrato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvExtrato;
        private Button BtVoltar;
    }
}