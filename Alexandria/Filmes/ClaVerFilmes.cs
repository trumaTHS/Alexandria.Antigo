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

        public DataTable ObterFilmes()

        {
            var sql = "SELECT Nome FROM tb_Filmes";

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
