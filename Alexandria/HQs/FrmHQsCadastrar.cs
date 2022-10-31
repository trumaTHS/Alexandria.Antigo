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
    public partial class FrmHQsCadastrar : Form
    {
        public FrmHQsCadastrar()
        {
            InitializeComponent();
        }

        private void BtnHQsSalvar_Click(object sender, EventArgs e)
        {
            ClaCadastroHQs HQ = new ClaCadastroHQs();
            HQ.ISBN = TxtboxHQISBN.Text;

            ClaBancoHQs.NovaHQ(HQ);
        }
    }
}
