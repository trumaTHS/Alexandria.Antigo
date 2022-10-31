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
                cmd.CommandText = "INSERT INTO tb_Filmes (Nome) VALUES (@Nome)";
                cmd.Parameters.AddWithValue("@Nome", u.Nome);
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
