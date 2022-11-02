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
                cmd.CommandText = "INSERT INTO tb_HQs" +
                    "(ISBN, Nome, Nome_Original, Autor, Serialização, Editora, Edição, Ano, Volume, Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha) " +
                    "VALUES (@ISBN, @Nome, @Nome_Original, @Autor, @Serialização, @Editora, @Edição, @Ano, @Volume, @Gênero, @Faixa_Etária, @Série, @Data_de_Início, @Data_de_Conclusão, @Nota, @Resenha)";
                cmd.Parameters.AddWithValue("@ISBN", u.ISBN);
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Nome_Original", u.Nome_Original);
                cmd.Parameters.AddWithValue("@Autor", u.Autor);
                cmd.Parameters.AddWithValue("@Serialização", u.Serialização);
                cmd.Parameters.AddWithValue("@Editora", u.Editora);
                cmd.Parameters.AddWithValue("@Edição", u.Edição);
                cmd.Parameters.AddWithValue("@Ano", u.Ano);
                cmd.Parameters.AddWithValue("@Volume", u.Volume);
                cmd.Parameters.AddWithValue("@Gênero", u.Gênero);
                cmd.Parameters.AddWithValue("@Faixa_Etária", u.Faixa_Etária);
                cmd.Parameters.AddWithValue("@Série", u.Série);
                cmd.Parameters.AddWithValue("@Data_de_Início", u.Data_de_Início);
                cmd.Parameters.AddWithValue("@Data_de_Conclusão", u.Data_de_Conclusão);
                cmd.Parameters.AddWithValue("@Nota", u.Nota);
                cmd.Parameters.AddWithValue("@Resenha", u.Resenha);
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
