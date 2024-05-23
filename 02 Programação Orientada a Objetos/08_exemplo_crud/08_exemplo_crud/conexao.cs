using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca de conexão do SQL
using MySql.Data;
using MySql.Data.MySqlClient;
namespace _08_exemplo_crud
{
    class conexao
    {
        //Criação das variaveis
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;
        //Construtor
        public conexao()
        {
            inicializar();
        }
        //Inicializar conexão com a sql
        public void inicializar()
        {
            servidor = "127.0.0.1";
            /*127.0.0.1 - número do servidor local ou seja o
            proprio computador, para conexões online necessário
            colocar o numero do servidor na internet.*/
            database = "crud_csharp";
            //Database que iremos criar futuramente
            usuario = "root";
            senha = "";
            /*usuário e senha são padrões (root e senha branco)
            para conexões remota necessário substituir por usuario
            e senha fornecido */
            string conexaostring;
            conexaostring = "SERVER=" + servidor + ";" + "DATABASE= " +
                database + ";" + "UID=" + usuario + ";" + "PASSWORD =" +
                senha + ";";
            conectar = new MySqlConnection(conexaostring);
            //MySqlConnection - utilizar a string conexaostring para 
            //conectar ao banco de dados
        }
        //Abertura do banco de dados
        public bool abrirconexao()
        {    //Try Catch é um tratamento de erro para códigos
            try
            {
                conectar.Open();
                return true;
            }
            catch (MySqlException ex) //Catch - Caso o try não execute 
            {                         //o catch entra em ação
                switch (ex.Number)
                {
                    case 0:
                        System.Windows.Forms.MessageBox.Show("Não Foi possivel conectar.");
                        break;
                    case 1045:
                        System.Windows.Forms.MessageBox.Show("Usuário e senha invalidos!");
                        break;
                }
                return false;
            }
        }
        public bool fecharconexao()
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







