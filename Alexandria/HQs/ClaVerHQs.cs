using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.HQs
{
    public class ClaVerHQs
    {
        public string ISBN { get; set; }

        public DataTable ObterHQs()

        {
            var sql = "SELECT ISBN FROM tb_HQs";

            var DT_HQs = new DataTable();

            try
            {

                using (var con = new SQLiteConnection(ClaConexao.StrCon))

                {
                    con.Open();
                    using (var da = new SQLiteDataAdapter(sql, con))
                    {
                        da.Fill(DT_HQs = new DataTable());
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DT_HQs = null;
            }

            return DT_HQs;
        }
    }
}
