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

        public DataTable ObterLivros()

        {
            var sql = "SELECT ISBN, Nome FROM tb_Livros";

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
