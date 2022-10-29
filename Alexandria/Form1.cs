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
    }
}
