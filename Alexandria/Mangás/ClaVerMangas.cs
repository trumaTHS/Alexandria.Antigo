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

        public DataTable ObterMangas()

        {
            var sql = "SELECT ISBN FROM tb_Mangas";

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
