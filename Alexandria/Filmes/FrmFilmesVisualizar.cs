using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Filmes
{
    public partial class FrmFilmesVisualizar : Form
    {
        public FrmFilmesVisualizar()
        {
            InitializeComponent();
        }

        private void BtnFilmesUniversalismo_Click(object sender, EventArgs e)
        {
            var filme = new ClaVerFilmes();
            DataFilmes.DataSource = filme.ObterFilmes();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
