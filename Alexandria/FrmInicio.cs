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
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void TimerInicio_Tick(object sender, EventArgs e)
        {
            if (ProbarInicio.Value == 100)
            {

                TimerInicio.Stop();
                Close();
                return;
            }

            else
            {
                ProbarInicio.Value = ProbarInicio.Value + 1;
            }
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            TimerInicio.Stop();
            Close();
        }

        private void BtnDesconhecido_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int d20 = new int();

            d20 = rand.Next(0, 20);

            if (d20 == 0)
                System.Diagnostics.Process.Start("https://pt.wikipedia.org/wiki/Biblioteca_de_Alexandria%22");
            else if (d20 == 2)
                System.Diagnostics.Process.Start("https://sites.google.com/view/projeto-alexandria/Alexandria%22");
            else if (d20 == 4)
                System.Diagnostics.Process.Start("https://i.imgur.com/xbEBacb.jpeg%22");
            else if (d20 == 6)
                System.Diagnostics.Process.Start("https://i.imgur.com/j0PJ9t0.gif%22");
            else if (d20 == 8)
                System.Diagnostics.Process.Start("https://www.baixelivros.com.br/%22");
            else if (d20 == 10)
                System.Diagnostics.Process.Start("https://www.ecycle.com.br/memento-mori/");
            else if (d20 == 12)
                System.Diagnostics.Process.Start("https://www.gilbertogodoy.com.br/ler-post/8-grandes-perguntas-filosoficas-complexas%22");
            else if (d20 == 14)
                System.Diagnostics.Process.Start("http://praler.org/2012/04/03/100-livros-para-ler-antes-de-morrer/%22");
            else if (d20 == 16)
                System.Diagnostics.Process.Start("https://www.revistabula.com/12089-199-filmes-para-ver-antes-de-morrer/%22");
            else if (d20 == 17)
                System.Diagnostics.Process.Start("https://otakubfx.com.br/animes-para-assistir-antes-de-morrer-lista-obrigatoria/%22");
            else if (d20 == 18)
                System.Diagnostics.Process.Start("https://livroecafe.com/2017/02/11/hqs-que-voce-precisa-ler/%22");
            else if (d20 == 19)
                System.Diagnostics.Process.Start("https://cosmonerd.com.br/animes-e-mangas/22-mangas-para-ler-antes-de-morrer/%22");
            else if (d20 == 20)
                System.Diagnostics.Process.Start("https://filmow.com/listas/101-series-para-se-ver-antes-de-morrer-l97755/%22");
        }
    }
}
