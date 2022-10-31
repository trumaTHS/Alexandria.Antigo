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
    class ClaBancoHQs
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source =C:/Users/Thiago/Documents/Programação/Alexandria (Faculdade)/Alexandria/Alexandria/db/BdAlexandria.db");
            conexao.Open();
            return conexao;
        }

        public static void NovaHQ(ClaCadastroHQs u)
        {
            // Precisamos em primeiro lugar, verificar se o usuário já exite.
            if (ExisteHQ(u))
            {
                MessageBox.Show("HQ já existe");
                return;
            }
            try
            {
                // Realizando a inserção no Banco de Dados
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_HQs (ISBN) VALUES (@ISBN)";
                cmd.Parameters.AddWithValue("@ISBN", u.ISBN);
                cmd.ExecuteNonQuery();
                MessageBox.Show("HQ cadastrada com sucesso");
                ConexaoBanco().Close();
            }
            catch
            {
                MessageBox.Show("Erro ao gravar nova HQ");
                ConexaoBanco().Close();
            }
        }
        ///////// Fim - Funções do Form F_NovoUsuario


        /////// Rotinas Gerais

        public static bool ExisteHQ(ClaCadastroHQs u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT ISBN FROM tb_HQs WHERE ISBN ='" + u.ISBN + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
