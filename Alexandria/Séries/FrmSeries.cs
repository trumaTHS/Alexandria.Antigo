using Alexandria.Animes;
using Alexandria.Séries;
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
    public partial class FrmSeries : Form
    {
        public FrmSeries()
        {
            InitializeComponent();
        }

        private void BtnSeriesVisualizar_Click(object sender, EventArgs e)
        {
            FrmSeriesVisualizar frmSeriesVisualizar = new FrmSeriesVisualizar();
            frmSeriesVisualizar.ShowDialog();
        }

        private void BtnSeriesCadastrar_Click(object sender, EventArgs e)
        {
            FrmSeriesCadastrar frmSeriesCadastrar = new FrmSeriesCadastrar();
            frmSeriesCadastrar.ShowDialog();
        }
    }
}
