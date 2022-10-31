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
    public partial class FrmMangasCadastrar : Form
    {
        public FrmMangasCadastrar()
        {
            InitializeComponent();
        }

        private void BtnMangasSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroMangas manga = new ClaCadastroMangas();
            manga.ISBN = TxtboxMangaISBN.Text;

            ClaBancoMangas.NovoManga(manga);
        }
    }
}
