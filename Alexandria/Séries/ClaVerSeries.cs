using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Séries
{
    public class ClaVerSeries
    {
        public string Nome { get; set; }
        public string Nome_Original { get; set; }
        public string Diretor { get; set; }
        public string Elenco_Principal { get; set; }
        public string Estúdio { get; set; }
        public string Publicação { get; set; }
        public string Término { get; set; }
        public int Temporada { get; set; }
        public int Episódios { get; set; }
        public string Gênero { get; set; }
        public string Faixa_Etária { get; set; }
        public string Série { get; set; }
        public string Data_de_Início { get; set; }
        public string Data_de_Conclusão { get; set; }
        public int Nota { get; set; }
        public string Resenha { get; set; }

        public DataTable ObterSeries()

        {
            var sql = "SELECT Nome, Nome_Original, Diretor, Elenco_Principal, Estúdio, Publicação, Término, Temporada, Episódios, " +
                "Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha FROM tb_Series";

            var DT_Series = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_Series = new DataTable());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_Series = null;
            }

            return DT_Series;
        }
    }
}
