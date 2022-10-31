using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Animes
{
    public class ClaVerAnimes
    {
        public string Nome { get; set; }

        public DataTable ObterAnimes()

        {
            var sql = "SELECT Nome FROM tb_Animes";

            var DT_Animes = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_Animes = new DataTable());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_Animes = null;
            }

            return DT_Animes;
        }
    }
}
