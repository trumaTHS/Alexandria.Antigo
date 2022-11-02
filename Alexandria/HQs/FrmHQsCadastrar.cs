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
            HQ.Nome = TxtboxNome.Text;
            HQ.ISBN = TxtboxISBN.Text;
            HQ.Nome_Original = TxtboxNome_Original.Text;
            HQ.Autor = TxtboxAutor.Text;
            HQ.Serialização = TxtboxSerialização.Text;
            HQ.Editora = TxtboxEditora.Text;
            HQ.Edição = Convert.ToInt32(Math.Round(NudEdição.Value, 0));
            HQ.Ano = Convert.ToInt32(Math.Round(NudAno.Value, 0));
            HQ.Volume = Convert.ToInt32(Math.Round(NudVolume.Value, 0));
            HQ.Gênero = TxtboxGênero.Text;
            HQ.Faixa_Etária = TxtboxFaixa_Etária.Text;
            HQ.Série = TxtboxSérie.Text;
            HQ.Data_de_Início = MtxtboxData_de_Início.Text;
            HQ.Data_de_Conclusão = MtxtboxData_de_Conclusão.Text;
            HQ.Nota = Convert.ToInt32(Math.Round(NudNota.Value, 0));
            HQ.Resenha = TxtboxResenha.Text;

            ClaBancoHQs.NovaHQ(HQ);
        }
    }
}
