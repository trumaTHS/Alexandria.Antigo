using Alexandria.HQs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Séries
{
    public partial class FrmSeriesCadastrar : Form
    {
        public FrmSeriesCadastrar()
        {
            InitializeComponent();
        }

        private void BtnSeriesSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroSeries serie = new ClaCadastroSeries();
            serie.Nome = TxtboxNome.Text;
            serie.Nome_Original = TxtboxNome_Original.Text;
            serie.Diretor = TxtboxDiretor.Text;
            serie.Elenco_Principal = TxtboxElenco_Principal.Text;
            serie.Estúdio = TxtboxEstúdio.Text;
            serie.Publicação = MtxtboxPublicação.Text;
            serie.Término = MtxtboxTérmino.Text;
            serie.Temporada = Convert.ToInt32(Math.Round(NudTemporada.Value, 0));
            serie.Episódios = Convert.ToInt32(Math.Round(NudEpisódios.Value, 0));
            serie.Gênero = TxtboxGênero.Text;
            serie.Faixa_Etária = TxtboxFaixa_Etária.Text;
            serie.Série = TxtboxSérie.Text;
            serie.Data_de_Início = MtxtboxData_de_Início.Text;
            serie.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            serie.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            serie.Resenha = TxtboxResenha.Text;

            ClaBancoSeries.NovaSerie(serie);
        }
    }
}
