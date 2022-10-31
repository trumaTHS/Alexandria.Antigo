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
    public partial class FrmAnimesCadastrar : Form
    {
        public FrmAnimesCadastrar()
        {
            InitializeComponent();
        }

        private void BtnAnimesSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroAnimes anime = new ClaCadastroAnimes();
            anime.Nome = TxtboxAnimeNome.Text;

            ClaBancoAnimes.NovoAnime(anime);
        }
    }
}
