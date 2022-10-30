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
    public partial class FrmObrasFisicas : Form
    {
        public FrmObrasFisicas()
        {
            InitializeComponent();
        }

        private void BtnLivros_Click(object sender, EventArgs e)
        {
            FrmLivros frmLivros = new FrmLivros();
            frmLivros.ShowDialog();
        }
    }
}
