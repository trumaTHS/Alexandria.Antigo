using Alexandria.Mangás;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Livros
{
    public partial class FrmMangasVisualizar : Form
    {
        public FrmMangasVisualizar()
        {
            InitializeComponent();
        }

        private void BtnMangasUniversalismo_Click(object sender, EventArgs e)
        {
            var manga = new ClaVerMangas();
            DataMangas.DataSource = manga.ObterMangas();
        }
    }
}
