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
            
            FrmInicio frmInicio = new FrmInicio();
            frmInicio.ShowDialog();
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
            System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/alexandria");
        }

        private void BtnFAQ_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/faq");
        }

        private void BtnNotasAtt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/notas-de-atualiza%C3%A7%C3%A3o");
        }

        private void BtnFuturasAtt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/futuras-atualiza%C3%A7%C3%B5es");
        }

        private void BtnSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/Alexandria");
        }

        private void BtnGitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Spavatii/Alexandria");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void FrmAlexandria_Load(object sender, EventArgs e)
        {

        }
    }
}
