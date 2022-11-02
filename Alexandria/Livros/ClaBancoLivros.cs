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
                cmd.CommandText = "INSERT INTO tb_Livros " +
                    "(ISBN, Nome, Nome_Original, Autor, Editora, Edição, Ano, Tradutor, Volume, Páginas, Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha) " +
                    "VALUES (@ISBN, @Nome, @Nome_Original, @Autor, @Editora, @Edição, @Ano, @Tradutor, @Volume, @Páginas, @Gênero, @Faixa_Etária, @Série, @Data_de_Início, @Data_de_Conclusão, @Nota, @Resenha)";
                cmd.Parameters.AddWithValue("@ISBN", u.ISBN);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Nome_Original", u.Nome_Original);
                cmd.Parameters.AddWithValue("@Autor", u.Autor);
                cmd.Parameters.AddWithValue("@Editora", u.Editora);
                cmd.Parameters.AddWithValue("@Edição", u.Edição);
                cmd.Parameters.AddWithValue("@Ano", u.Ano);
                cmd.Parameters.AddWithValue("@Tradutor", u.Tradutor);
                cmd.Parameters.AddWithValue("@Volume", u.Volume);
                cmd.Parameters.AddWithValue("@Páginas", u.Páginas);
                cmd.Parameters.AddWithValue("@Gênero", u.Gênero);
                cmd.Parameters.AddWithValue("@Faixa_Etária", u.Faixa_Etária);
                cmd.Parameters.AddWithValue("@Série", u.Série);
                cmd.Parameters.AddWithValue("@Data_de_Início", u.Data_de_Início);
                cmd.Parameters.AddWithValue("@Data_de_Conclusão", u.Data_de_Conclusão);
                cmd.Parameters.AddWithValue("@Nota", u.Nota);
                cmd.Parameters.AddWithValue("@Resenha", u.Resenha);
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
