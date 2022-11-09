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
    public partial class FrmFilmesCadastrar : Form
    {
        public FrmFilmesCadastrar()
        {
            InitializeComponent();
        }

        private void BtnFilmesSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroFilmes filme = new ClaCadastroFilmes();
            filme.Nome = TxtboxNome.Text;
            filme.Nome_Original = TxtboxNome_Original.Text;
            filme.Diretor = TxtboxDiretor.Text;
            filme.Elenco_Principal = TxtboxElenco_Principal.Text;
            filme.Estúdio = TxtboxEstúdio.Text;
            filme.Ano = Convert.ToInt32(Math.Round(NudAno.Value, 0));
            filme.Ordem = Convert.ToInt32(Math.Round(NudOrdem.Value, 0));
            filme.Duração = MtxtboxDuração.Text;
            filme.Gênero = TxtboxGênero.Text;
            filme.Faixa_Etária = TxtboxFaixa_Etária.Text;
            filme.Série = TxtboxSérie.Text;
            filme.Data_de_Início = MtxtboxData_de_Início.Text;
            filme.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            filme.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            filme.Resenha = TxtboxResenha.Text;

            ClaBancoFilmes.NovoFilme(filme);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
