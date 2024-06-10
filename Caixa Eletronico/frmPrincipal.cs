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
    public partial class FrmPrincipal : Form
    {
        Singleton vitao;
        public FrmPrincipal()
        {
            InitializeComponent();
            vitao = Singleton.Instance;
            LblSaldo.Text = vitao.conta_logada.Saldo.ToString();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmInicial frm = new FrmInicial();
            frm.Show();
            this.Close();
        }
        private void BtnExtrato_Click(object sender, EventArgs e)
        {
            FrmExtrato frm = new FrmExtrato();
            frm.Show();
            this.Hide();
        }
        private void BtnSacar_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Saque");
            frm.Show();
            this.Hide();
        }
        private void BtnDepositar_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Depósito");
            frm.Show();
            this.Hide();
        }
        private void BtnTransferir_Click(object sender, EventArgs e)
        {
            FrmProc frm = new FrmProc("Transferência");
            frm.Show();
            this.Hide();
        }
    }
}
