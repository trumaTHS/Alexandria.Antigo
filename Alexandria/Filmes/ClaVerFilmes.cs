using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Filmes
{
    public class ClaVerFilmes
    {
        public string Nome { get; set; }
        public string Nome_Original { get; set; }
        public string Diretor { get; set; }
        public string Elenco_Principal { get; set; }
        public string Estúdio { get; set; }
        public int Ano { get; set; }
        public int Ordem { get; set; }
        public string Duração { get; set; }
        public string Gênero { get; set; }
        public string Faixa_Etária { get; set; }
        public string Série { get; set; }
        public string Data_de_Início { get; set; }
        public string Data_de_Conclusão { get; set; }
        public int Nota { get; set; }
        public string Resenha { get; set; }

        public DataTable ObterFilmes()

        {
            var sql = "SELECT Nome, Nome_Original, Diretor, Elenco_Principal, Estúdio, Ano, Ordem, Duração, Gênero, Faixa_Etária, Série, " +
                "Data_de_Início, Data_de_Conclusão, Nota, Resenha FROM tb_Filmes";

            var DT_Filmes = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_Filmes = new DataTable());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_Filmes = null;
            }

            return DT_Filmes;
        }
    }
}
