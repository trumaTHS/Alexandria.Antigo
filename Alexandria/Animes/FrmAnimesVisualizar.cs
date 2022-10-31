using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Animes
{
    public partial class FrmAnimesVisualizar : Form
    {
        public FrmAnimesVisualizar()
        {
            InitializeComponent();
        }

        private void BtnAnimesUniversalismo_Click(object sender, EventArgs e)
        {
            var anime = new ClaVerAnimes();
            DataAnimes.DataSource = anime.ObterAnimes();
        }
    }
}
