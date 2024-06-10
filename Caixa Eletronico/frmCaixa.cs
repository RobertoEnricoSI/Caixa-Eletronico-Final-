using Caixa_Eletronico.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Caixa_Eletronico
{
    public partial class frmPrincipal : Form
    {
        Singleton s;
        public FrmPrincipal()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btA_Click(object sender, EventArgs e)
        {
            Conta c = s.BuscarConta(txA.Text);
            if (c != null)
            {
                s.conta_logada = c;
                frmPrincipal frm = new frmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Conta nao existe!");
                txA.Text = "";
            }
        }
    }
}
