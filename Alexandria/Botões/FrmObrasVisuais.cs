using Alexandria.Botões;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class FrmObrasVisuais : Form
    {
        public FrmObrasVisuais()
        {
            InitializeComponent();
        }

        private void BtnFilmes_Click(object sender, EventArgs e)
        {
            FrmFilmes frmFilmes = new FrmFilmes();
            frmFilmes.ShowDialog();
        }

        private void BtnAnimes_Click(object sender, EventArgs e)
        {
            FrmAnimes frmAnimes = new FrmAnimes();
            frmAnimes.ShowDialog();
        }

        private void BtnSeries_Click(object sender, EventArgs e)
        {
            FrmSeries frmSeries = new FrmSeries();
            frmSeries.ShowDialog();
        }
    }
}
