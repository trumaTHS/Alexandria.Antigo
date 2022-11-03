using Alexandria.HQs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Botões
{
    public partial class FrmHQs : Form
    {
        public FrmHQs()
        {
            InitializeComponent();
        }

        private void BtnHQsVisualizar_Click(object sender, EventArgs e)
        {
            FrmHQsVisualizar frmHQsVisualizar = new FrmHQsVisualizar();
            frmHQsVisualizar.ShowDialog();
        }

        private void BtnHQsCadastrar_Click(object sender, EventArgs e)
        {
            FrmHQsCadastrar frmHQsCadastrar = new FrmHQsCadastrar();
            frmHQsCadastrar.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
