using System;
using MySql.Data.MySqlClient;

namespace _00_projeto_modelo_theodoro
{
    class Login
    {
        private conexao dbConexao;
        private string usuario;
        private string senha;

        public Login()
        {
            dbConexao = new conexao();
        }

        public void SetUsuario(string usuario)
        {
            this.usuario = usuario;
        }

        public void SetSenha(string senha)
        {
            this.senha = senha;
        }

        public int ConsultarLogin()
        {
            int valor_login = 0;    

            try
            {
                if (dbConexao.abrirconexao())
                {
                    string mSQL = "SELECT COUNT(usuario) FROM login WHERE usuario = @usuario AND senha = @senha";

                    using (MySqlCommand cmd = new MySqlCommand(mSQL, dbConexao.conectar))
                    {
                        cmd.Parameters.AddWithValue("@usuario", this.usuario);
                        cmd.Parameters.AddWithValue("@senha", this.senha);

                        valor_login = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                dbConexao.fecharconexao();
            }
            

            return valor_login;
        }
    }
}
