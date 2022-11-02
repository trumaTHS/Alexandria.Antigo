using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexandria.Filmes
{
    class ClaBancoFilmes
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source =C:/Users/Thiago/Documents/Programação/Alexandria (Faculdade)/Alexandria/Alexandria/db/BdAlexandria.db");
            conexao.Open();
            return conexao;
        }

        public static void NovoFilme(ClaCadastroFilmes u)
        {
            // Precisamos em primeiro lugar, verificar se o usuário já exite.
            if (ExisteFilme(u))
            {
                MessageBox.Show("Filme já existe");
                return;
            }
            try
            {
                // Realizando a inserção no Banco de Dados
                var cmd = ConexaoBanco().CreateCommand();
                cmd.CommandText = "INSERT INTO tb_Filmes " +
                    "(Nome, Nome_Original, Diretor, Elenco_Principal, Estúdio, Ano, Ordem, Duração, Gênero, Faixa_Etária, Série, Data_de_Início, Data_de_Conclusão, Nota, Resenha) " +
                    "VALUES (@Nome, @Nome_Original, @Diretor, @Elenco_Principal, @Estúdio, @Ano, @Ordem, @Duração, @Gênero, @Faixa_Etária, @Série, @Data_de_Início, @Data_de_Conclusão, @Nota, @Resenha)";
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
                cmd.Parameters.AddWithValue("@Nome_Original", u.Nome);
                cmd.Parameters.AddWithValue("@Diretor", u.Nome);
                cmd.Parameters.AddWithValue("@Elenco_Principal", u.Nome);
                cmd.Parameters.AddWithValue("@Estúdio", u.Nome);
                cmd.Parameters.AddWithValue("@Ano", u.Nome);
                cmd.Parameters.AddWithValue("@Ordem", u.Nome);
                cmd.Parameters.AddWithValue("@Duração", u.Nome);
                cmd.Parameters.AddWithValue("@Gênero", u.Nome);
                cmd.Parameters.AddWithValue("@Faixa_Etária", u.Nome);
                cmd.Parameters.AddWithValue("@Série", u.Nome);
                cmd.Parameters.AddWithValue("@Data_de_Início", u.Nome);
                cmd.Parameters.AddWithValue("@Data_de_Conclusão", u.Nome);
                cmd.Parameters.AddWithValue("@Nota", u.Nome);
                cmd.Parameters.AddWithValue("@Resenha", u.Nome);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Filme cadastrado com sucesso");
                ConexaoBanco().Close();
            }
            catch
            {
                MessageBox.Show("Erro ao gravar novo Filme");
                ConexaoBanco().Close();
            }
        }
        ///////// Fim - Funções do Form F_NovoUsuario


        /////// Rotinas Gerais

        public static bool ExisteFilme(ClaCadastroFilmes u)
        {
            bool res;

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var cmd = ConexaoBanco().CreateCommand();
            cmd.CommandText = "SELECT Nome FROM tb_Filmes WHERE Nome ='" + u.Nome + "'";
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
