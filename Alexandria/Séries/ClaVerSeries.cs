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

        public DataTable ObterSeries()

        {
            var sql = "SELECT Nome FROM tb_Series";

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
