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
    public partial class FrmLivros : Form
    {
        public FrmLivros()
        {
            InitializeComponent();
        }

        private void BtnLivrosVisualizar_Click(object sender, EventArgs e)
        {
            FrmLivrosVisualizar frmLivrosVisualizar = new FrmLivrosVisualizar();
            frmLivrosVisualizar.ShowDialog();
        }

        private void BtnLivrosCadastrar_Click(object sender, EventArgs e)
        {
            FrmLivrosCadastrar frmLivrosCadastrar = new FrmLivrosCadastrar();
            frmLivrosCadastrar.ShowDialog();
        }
    }
}
