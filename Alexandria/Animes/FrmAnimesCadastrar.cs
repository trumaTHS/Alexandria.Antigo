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
            anime.Nome = TxtboxNome.Text;
            anime.Nome_Original = TxtboxNome_Original.Text;
            anime.Diretor = TxtboxDiretor.Text;
            anime.Estúdio = TxtboxEstúdio.Text;
            anime.Publicação = MtxtboxPublicação.Text;
            anime.Término = MtxtboxTérmino.Text;
            anime.Estação = TxtboxEstação.Text;
            anime.Temporada = Convert.ToInt32(Math.Round(NudTemporada.Value, 0));
            anime.Episódios = Convert.ToInt32(Math.Round(NudEpisódios.Value, 0));
            anime.Gênero = TxtboxGênero.Text;
            anime.Faixa_Etária = TxtboxFaixa_Etária.Text;
            anime.Série = TxtboxSérie.Text;
            anime.Data_de_Início = MtxtboxData_de_Início.Text;
            anime.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            anime.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            anime.Resenha = TxtboxResenha.Text;

            ClaBancoAnimes.NovoAnime(anime);
        }
    }
}
