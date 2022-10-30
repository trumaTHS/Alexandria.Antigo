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
    public partial class FrmFilmes : Form
    {
        public FrmFilmes()
        {
            InitializeComponent();
        }

        private void BtnFilmesVisualizar_Click(object sender, EventArgs e)
        {
            FrmFilmesVisualizar frmFilmesVisualizar = new FrmFilmesVisualizar();
            frmFilmesVisualizar.ShowDialog();
        }

        private void BtnFilmesCadastrar_Click(object sender, EventArgs e)
        {
            FrmFilmesCadastrar frmFilmesCadastrar = new FrmFilmesCadastrar();
            frmFilmesCadastrar.ShowDialog();
        }
    }
}
