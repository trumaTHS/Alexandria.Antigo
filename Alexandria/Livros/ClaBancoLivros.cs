using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria
{
    class ClaBancoLivros
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source =C:/Users/Thiago/Documents/Programação/Alexandria (Faculdade)/Alexandria/Alexandria/db/BdAlexandria.db");
            conexao.Open();
            return conexao;
        }

        public static void NovoLivro(ClaCadastroLivros u)
        {
            // Precisamos em primeiro lugar, verificar se o usuário já exite.
            if (ExisteLivro(u))
            {
                MessageBox.Show("Livro já existe");
                return;
            }
            try
            {
                // Realizando a inserção no Banco de Dados
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Livros (ISBN, Nome) VALUES (@ISBN, @Nome)";
                cmd.Parameters.AddWithValue("@ISBN", u.ISBN);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Livro cadastrado com sucesso");
                ConexaoBanco().Close();
            }
            catch
            {
                MessageBox.Show("Erro ao gravar novo Livro");
                ConexaoBanco().Close();
            }
        }
        ///////// Fim - Funções do Form F_NovoUsuario


        /////// Rotinas Gerais

        public static bool ExisteLivro(ClaCadastroLivros u)
        {
            bool res;
            
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT ISBN FROM tb_Livros WHERE ISBN ='" + u.ISBN + "'";
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
