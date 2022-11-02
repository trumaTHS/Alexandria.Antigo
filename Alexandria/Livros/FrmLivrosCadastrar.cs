using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria
{
    public partial class FrmLivrosCadastrar : Form
    {
        public FrmLivrosCadastrar()
        {
            InitializeComponent();
        }

        private void BtnLivrosSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroLivros livro = new ClaCadastroLivros();
            livro.Nome = TxtboxNome.Text;
            livro.ISBN = TxtboxISBN.Text;
            livro.Nome_Original = TxtboxNome_Original.Text;
            livro.Autor = TxtboxAutor.Text;
            livro.Editora = TxtboxEditora.Text;
            livro.Edição = Convert.ToInt32(Math.Round(NudEdição.Value, 0));
            livro.Ano = Convert.ToInt32(Math.Round(NudAno.Value, 0));
            livro.Tradutor = TxtboxTradutor.Text;
            livro.Volume = Convert.ToInt32(Math.Round(NudVolume.Value, 0));
            livro.Páginas = Convert.ToInt32(Math.Round(NudPáginas.Value, 0));
            livro.Gênero = TxtboxGênero.Text;
            livro.Faixa_Etária = TxtboxFaixa_Etária.Text;
            livro.Série = TxtboxSérie.Text;
            livro.Data_de_Início = MtxtboxData_de_Início.Text;
            livro.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            livro.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            livro.Resenha = TxtboxResenha.Text;

        ClaBancoLivros.NovoLivro(livro);
        }
    }
}
