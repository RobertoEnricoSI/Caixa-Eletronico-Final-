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

namespace Caixa_Eletronico
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            Singleton s;
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Close();
        }

        private void btExtrato_Click(object sender, EventArgs e)
        {
            FrmExtrato frm = new FrmExtrato();
            frm.Show();
            this.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblSaldo.Text = s.conta_logada.Saldo.ToString();
        }

        private void lblSaldo_Click(object sender, EventArgs e)
        {

        }

        private void btSaque_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Saque");
            frm.Show();
            this.Hide();
        }

        private void btDeposita_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Depósito");
            frm.Show();
            this.Hide();
        }

        private void btTrans_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Transferência");
            frm.Show();
            this.Hide();
        }
    }
}