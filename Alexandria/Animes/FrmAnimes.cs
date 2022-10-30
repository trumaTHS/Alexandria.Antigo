using Alexandria.Animes;
using Alexandria.Filmes;
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
    public partial class FrmAnimes : Form
    {
        public FrmAnimes()
        {
            InitializeComponent();
        }

        private void BtnAnimesVisualizar_Click(object sender, EventArgs e)
        {
            FrmAnimesVisualizar frmAnimesVisualizar = new FrmAnimesVisualizar();
            frmAnimesVisualizar.ShowDialog();
        }

        private void BtnAnimesCadastrar_Click(object sender, EventArgs e)
        {
            FrmAnimesCadastrar frmAnimesCadastrar = new FrmAnimesCadastrar();
            frmAnimesCadastrar.ShowDialog();
        }
    }
}
