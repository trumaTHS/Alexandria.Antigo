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
            serie.Nome = TxtboxSerieNome.Text;

            ClaBancoSeries.NovaSerie(serie);
        }
    }
}
