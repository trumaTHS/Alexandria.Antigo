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
    public partial class FrmLivrosVisualizar : Form
    {
        public FrmLivrosVisualizar()
        {
            InitializeComponent();
        }

        private void BtnLivrosUniversalismo_Click(object sender, EventArgs e)
        {
            var livro = new ClaVerLivros();
            DataLivros.DataSource = livro.ObterLivros();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
