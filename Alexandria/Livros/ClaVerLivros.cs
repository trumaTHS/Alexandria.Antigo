using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria
{
    public class ClaVerLivros
    {
        public string ISBN { get; set; }
        public string Nome { get; set; }
        public string Nome_Original { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public int Edição { get; set; }
        public int Ano { get; set; }
        public string Tradutor { get; set; }
        public int Volume { get; set; }
        public int Páginas { get; set; }
        public string Gênero { get; set; }
        public string Faixa_Etária { get; set; }
        public string Série { get; set; }
        public string Data_de_Início { get; set; }
        public string Data_de_Conclusão { get; set; }
        public int Nota { get; set; }
        public string Resenha { get; set; }

        public DataTable ObterLivros()

        {
            var sql = "SELECT ISBN, Nome, Nome_Original, Autor, Editora, Edição, Ano, Tradutor, Volume, Páginas, " +
                "Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha FROM tb_Livros";

            var DT_Livros = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_Livros = new DataTable());
                    }
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_Livros = null;
            }
            
            return DT_Livros;
        }
    }
}
