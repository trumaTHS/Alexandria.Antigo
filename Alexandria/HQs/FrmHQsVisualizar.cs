using Alexandria.Animes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.HQs
{
    public partial class FrmHQsVisualizar : Form
    {
        public FrmHQsVisualizar()
        {
            InitializeComponent();
        }

        private void BtnHQsUniversalismo_Click(object sender, EventArgs e)
        {
            var HQ = new ClaVerHQs();
            DataHQs.DataSource = HQ.ObterHQs();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
