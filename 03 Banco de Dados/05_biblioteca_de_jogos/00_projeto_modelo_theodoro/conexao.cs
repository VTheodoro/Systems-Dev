using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_projeto_modelo_theodoro
{
    class conexao
    {
        public MySqlConnection conectar;
        private string servidor;
        private string database;
        private string usuario;
        private string senha;

        public Conexao()
        {
            servidor = "127.0.0.1";
            database = "crud_jogos";
            usuario = "root";
            senha = "";
            string conexaostring = $"SERVER={servidor};DATABASE={database};UID={usuario};PASSWORD={senha};";
            conectar = new MySqlConnection(conexaostring);
        }

        public bool AbrirConexao()
        {
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                //caso tenha de erros de conexão ---->
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possível conectar ao servidor.");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário ou senha inválidos.");
                        break;
                }
                return false;
            }
        }

        public bool FecharConexao()
        {
            try
            {
                conectar.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
