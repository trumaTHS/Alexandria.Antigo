using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Animes
{
    class ClaBancoAnimes
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source =C:/Users/Thiago/Documents/Programação/Alexandria (Faculdade)/Alexandria/Alexandria/db/BdAlexandria.db");
            conexao.Open();
            return conexao;
        }

        public static void NovoAnime(ClaCadastroAnimes u)
        {
            // Precisamos em primeiro lugar, verificar se o usuário já exite.
            if (ExisteAnime(u))
            {
                MessageBox.Show("Anime já existe");
                return;
            }
            try
            {
                // Realizando a inserção no Banco de Dados
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Animes " +
                    "(Nome, Nome_Original, Diretor, Estúdio, Publicação, Término, Estação, Temporada, Episódios, Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha) " +
                    "VALUES (@Nome, @Nome_Original, @Diretor, @Estúdio, @Publicação, @Término, @Estação, @Temporada, @Episódios, @Gênero, @Faixa_Etária, @Série, @Data_de_Início, @Data_de_Conclusão, @Nota, @Resenha)";
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Nome_Original", u.Nome_Original);
                cmd.Parameters.AddWithValue("@Diretor", u.Diretor);
                cmd.Parameters.AddWithValue("@Estúdio", u.Estúdio);
                cmd.Parameters.AddWithValue("@Publicação", u.Publicação);
                cmd.Parameters.AddWithValue("@Término", u.Término);
                cmd.Parameters.AddWithValue("@Estação", u.Estação);
                cmd.Parameters.AddWithValue("@Temporada", u.Temporada);
                cmd.Parameters.AddWithValue("@Episódios", u.Episódios);
                cmd.Parameters.AddWithValue("@Gênero", u.Gênero);
                cmd.Parameters.AddWithValue("@Faixa_Etária", u.Faixa_Etária);
                cmd.Parameters.AddWithValue("@Série", u.Série);
                cmd.Parameters.AddWithValue("@Data_de_Início", u.Data_de_Início);
                cmd.Parameters.AddWithValue("@Data_de_Conclusão", u.Data_de_Conclusão);
                cmd.Parameters.AddWithValue("@Nota", u.Nota);
                cmd.Parameters.AddWithValue("@Resenha", u.Resenha);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Anime cadastrado com sucesso");
                ConexaoBanco().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao gravar novo Anime");
                ConexaoBanco().Close();
            }
        }
        ///////// Fim - Funções do Form F_NovoUsuario


        /////// Rotinas Gerais

        public static bool ExisteAnime(ClaCadastroAnimes u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT Nome FROM tb_Animes WHERE Nome ='" + u.Nome + "'";
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
