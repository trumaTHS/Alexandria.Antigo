using Alexandria.Livros;
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
    public partial class FrmMangas : Form
    {
        public FrmMangas()
        {
            InitializeComponent();
        }

        private void BtnMangasVisualizar_Click(object sender, EventArgs e)
        {
            FrmMangasVisualizar frmMangasVisualizar = new FrmMangasVisualizar();
            frmMangasVisualizar.ShowDialog();
        }

        private void BtnMangasCadastrar_Click(object sender, EventArgs e)
        {
            FrmMangasCadastrar frmMangasCadastrar = new FrmMangasCadastrar();
            frmMangasCadastrar.ShowDialog();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
