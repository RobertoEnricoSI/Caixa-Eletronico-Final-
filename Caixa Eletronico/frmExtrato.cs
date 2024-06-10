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
        Singleton vitinho;
        public FrmExtrato()
        {
            InitializeComponent();
            vitinho = Singleton.Instance;
        }

        private void Recarregar()
        {
            var source = new BindingSource();
            source.DataSource = vitinho.conta_logada.Transacoes;
            DgvExtrato.DataSource = source;
        }

        private void frmExtrato_Load(object sender, EventArgs e)
        {
            Recarregar();
        }

        private void BtVoltar_Click(object sender, EventArgs e)
        {
            FrmCaixa frm = new FrmCaixa();
            frm.Show();
            this.Close();
        }
    }
}
