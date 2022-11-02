using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Mangás
{
    public class ClaVerMangas
    {
        public string ISBN { get; set; }
        public string Nome { get; set; }
        public string Nome_Original { get; set; }
        public string Autor { get; set; }
        public string Serialização { get; set; }
        public string Editora { get; set; }
        public int Edição { get; set; }
        public int Ano { get; set; }
        public int Volume { get; set; }
        public int Capítulos { get; set; }
        public string Gênero { get; set; }
        public string Faixa_Etária { get; set; }
        public string Série { get; set; }
        public string Data_de_Início { get; set; }
        public string Data_de_Conclusão { get; set; }
        public int Nota { get; set; }
        public string Resenha { get; set; }

        public DataTable ObterMangas()

        {
            var sql = "SELECT ISBN, Nome, Nome_Original, Autor, Serialização, Editora, Edição, Ano, Volume, Capítulos, " +
                "Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha FROM tb_Mangas";

            var DT_Mangas = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_Mangas = new DataTable());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_Mangas = null;
            }

            return DT_Mangas;
        }
    }
}
