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
            manga.Nome = TxtboxNome.Text;
            manga.ISBN = TxtboxISBN.Text;
            manga.Nome_Original = TxtboxNome_Original.Text;
            manga.Autor = TxtboxAutor.Text;
            manga.Serialização = TxtboxSerialização.Text;
            manga.Editora = TxtboxEditora.Text;
            manga.Edição = Convert.ToInt32(Math.Round(NudEdição.Value, 0));
            manga.Ano = Convert.ToInt32(Math.Round(NudAno.Value, 0));
            manga.Volume = Convert.ToInt32(Math.Round(NudVolume.Value, 0));
            manga.Capítulos = Convert.ToInt32(Math.Round(NudCapítulos.Value, 0));
            manga.Gênero = TxtboxGênero.Text;
            manga.Faixa_Etária = TxtboxFaixa_Etária.Text;
            manga.Série = TxtboxSérie.Text;
            manga.Data_de_Início = MtxtboxData_de_Início.Text;
            manga.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            manga.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            manga.Resenha = TxtboxResenha.Text;

            ClaBancoMangas.NovoManga(manga);
        }
    }
}
