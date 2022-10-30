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
            livro.Nome = TxtboxLivroNome.Text;
            livro.ISBN = TxtboxLivroISBN.Text;

            ClaBancoLivros.NovoLivro(livro);
        }
    }
}
