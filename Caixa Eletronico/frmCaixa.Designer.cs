namespace Caixa_Eletronico
{
    partial class Form1
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
            lblC = new Label();
            txA = new TextBox();
            btA = new Button();
            SuspendLayout();
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(36, 87);
            lblC.Name = "lblC";
            lblC.Size = new Size(39, 15);
            lblC.TabIndex = 0;
            lblC.Text = "Conta";
            // 
            // txA
            // 
            txA.BackColor = SystemColors.Control;
            txA.Location = new Point(81, 84);
            txA.Name = "txA";
            txA.Size = new Size(208, 23);
            txA.TabIndex = 2;
            // 
            // btA
            // 
            btA.BackColor = SystemColors.Control;
            btA.Location = new Point(147, 126);
            btA.Name = "btA";
            btA.Size = new Size(75, 23);
            btA.TabIndex = 3;
            btA.Text = "Acessar";
            btA.UseVisualStyleBackColor = false;
            btA.Click += btA_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(521, 243);
            Controls.Add(btA);
            Controls.Add(txA);
            Controls.Add(lblC);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblC;
        private TextBox txA;
        private Button btA;
    }
}