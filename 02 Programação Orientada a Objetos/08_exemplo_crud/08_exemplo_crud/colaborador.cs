using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;


namespace _08_exemplo_crud
{
    class colaborador : conexao
    {

        private string nome;
        private string sobrenome;
        private string cpf;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCPF()
        {
            return this.cpf;
        }


        //método para inserir as informações
        public void inserir()
        {
            string query = "insert into colaborador(nome_colaborador,sobrenome_colaborador,cpf_colaborador)Values('" + getNome() + "','" + getSobrenome() + "','" + getCPF() + "')";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }       
                
         }



    }
}
