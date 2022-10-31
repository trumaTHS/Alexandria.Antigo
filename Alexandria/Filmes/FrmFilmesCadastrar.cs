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
            filme.Nome = TxtboxFilmeNome.Text;

            ClaBancoFilmes.NovoFilme(filme);
        }
    }
}
