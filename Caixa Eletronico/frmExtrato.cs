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
    public partial class FrmExtrato : Form
    {
        Singleton s;//mudar
        public FrmExtrato()
        {
            InitializeComponent();
            s = Singleton.Instance;
        }

        private void Recarregar()//mudar
        {
            var source = new BindingSource();
            source.DataSource = s.conta_logada.Transacoes;
            DgvExtrato.DataSource = source;
        }

        private void frmExtrato_Load(object sender, EventArgs e)
        {
            Recarregar();//mudar
        }

        private void BtVoltar_Click(object sender, EventArgs e)//mudar
        {
            frmPrincipal frm = new frmPrincipal();
            frm.Show();
            this.Close();
        }
    }
}
