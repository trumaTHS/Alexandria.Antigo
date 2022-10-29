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
    public partial class FrmAlexandria : Form
    {
        public FrmAlexandria()
        {
            InitializeComponent();
        }

        private void BtnObrasFisicas_Click(object sender, EventArgs e)
        {
            FrmObrasFisicas frmObrasFisicas = new FrmObrasFisicas();
            frmObrasFisicas.ShowDialog();
        }

        private void BtnObrasVisuais_Click(object sender, EventArgs e)
        {
            FrmObrasVisuais frmObrasVisuais = new FrmObrasVisuais();
            frmObrasVisuais.ShowDialog();
        }

        private void BtnAlexandria_Click(object sender, EventArgs e)
        {
            FrmAlexandriaDesc frmAlexandriaDesc = new FrmAlexandriaDesc();
            frmAlexandriaDesc.ShowDialog();
        }

        private void BtnFAQ_Click(object sender, EventArgs e)
        {
            FrmFAQ frmFAQ = new FrmFAQ();
            frmFAQ.ShowDialog();
        }

        private void BtnNotasAtt_Click(object sender, EventArgs e)
        {
            FrmNotasAtt frmNotasAtt = new FrmNotasAtt();
            frmNotasAtt.ShowDialog();
        }

        private void BtnFuturasAtt_Click(object sender, EventArgs e)
        {
            FrmFuturasAtt frmFuturasAtt = new FrmFuturasAtt();
            frmFuturasAtt.ShowDialog();
        }

        private void BtnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Spavatii/Alexandria");
        }
    }
}
