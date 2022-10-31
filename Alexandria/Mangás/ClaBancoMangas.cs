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
    class ClaBancoMangas
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source =C:/Users/Thiago/Documents/Programação/Alexandria (Faculdade)/Alexandria/Alexandria/db/BdAlexandria.db");
            conexao.Open();
            return conexao;
        }

        public static void NovoManga(ClaCadastroMangas u)
        {
            // Precisamos em primeiro lugar, verificar se o usuário já exite.
            if (ExisteManga(u))
            {
                MessageBox.Show("Mangá já existe");
                return;
            }
            try
            {
                // Realizando a inserção no Banco de Dados
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Mangas (ISBN) VALUES (@ISBN)";
                cmd.Parameters.AddWithValue("@ISBN", u.ISBN);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mangá cadastrado com sucesso");
                ConexaoBanco().Close();
            }
            catch
            {
                MessageBox.Show("Erro ao gravar novo Mangá");
                ConexaoBanco().Close();
            }
        }
        ///////// Fim - Funções do Form F_NovoUsuario


        /////// Rotinas Gerais

        public static bool ExisteManga(ClaCadastroMangas u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT ISBN FROM tb_Mangas WHERE ISBN ='" + u.ISBN + "'";
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
