using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//criação de blibliotecas para conexão com o MySql
using MySql.Data;
using MySql.Data.MySqlClient;

namespace _08_exemplo_crud
{
    class conexao
    {
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        public conexao()
        {
            inicializar();
        }
        public void inicializar()
        {
            servidor = "127.0.0.1";
            //local onde está o banco de dados no localhost.
            //quando estiver online necessario saber o ip do servidor ou nome do servidor.

            database = "crud_csharp";
            //database do banco de dados que iremos utilizar

            usuario = "root";
            senha = "";
            //usuario e senha padrões de acesso

            string conexaostring;
            conexaostring = "SEVER=" + servidor + ";" + "DATABASE=" + database + ";" + "UID=" + usuario + ";" + "PASSWORD=" + senha + ";";
            //variavel conectar utilizada para localizar e acessar o banco de dados (local ou online)
            conectar = new MySqlConnection(conexaostring);

        }

        public bool abrirconexao() //try é um tratamento de erro
        {                           //oque está dentro do try deve ser executado
            try                     //oque está dentro do catch é a exessão do try
            {                       //caso o try não execut ou não funcione, será direcionado para o catch
                conectar.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não foi possivel conectar");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Ususario e senha invalidos");
                        break;
                }
                return false;
            }
        }



    }
}
