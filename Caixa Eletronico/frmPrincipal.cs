using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caixa_Eletronico
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            btV = new Button();
            btD = new Button();
            btT = new Button();
            btE = new Button();
            btS = new Button();
            this.label1 = new Label();
            SuspendLayout();
            // 
            // btV
            // 
            btV.Location = new Point(12, 12);
            btV.Name = "btV";
            btV.Size = new Size(63, 26);
            btV.TabIndex = 0;
            btV.Text = "Voltar";
            btV.UseVisualStyleBackColor = true;
            // 
            // btD
            // 
            btD.Location = new Point(157, 102);
            btD.Name = "btD";
            btD.Size = new Size(75, 23);
            btD.TabIndex = 1;
            btD.Text = "Depositar";
            btD.UseVisualStyleBackColor = true;
            // 
            // btT
            // 
            btT.Location = new Point(157, 142);
            btT.Name = "btT";
            btT.Size = new Size(75, 23);
            btT.TabIndex = 2;
            btT.Text = "Trannsferir";
            btT.UseVisualStyleBackColor = true;
            // 
            // btE
            // 
            btE.Location = new Point(157, 180);
            btE.Name = "btE";
            btE.Size = new Size(75, 23);
            btE.TabIndex = 3;
            btE.Text = "Extrato";
            btE.UseVisualStyleBackColor = true;
            // 
            // btS
            // 
            btS.Location = new Point(157, 62);
            btS.Name = "btS";
            btS.Size = new Size(75, 23);
            btS.TabIndex = 4;
            btS.Text = "Sacar";
            btS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new Size(38, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // frmPrincipal
            // 
            ClientSize = new Size(441, 277);
            Controls.Add(this.label1);
            Controls.Add(btS);
            Controls.Add(btE);
            Controls.Add(btT);
            Controls.Add(btD);
            Controls.Add(btV);
            Name = "frmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
