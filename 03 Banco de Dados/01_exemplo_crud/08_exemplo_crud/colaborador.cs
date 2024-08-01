using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;


namespace _08_exemplo_crud
{
    class colaborador : conexao
    {

        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

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

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getCodigo()
        {
            return this.codigo;
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

        public void excluir()
        {
            string query = "delete from colaborador where codigo_colaborador ='" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }


        //Criar um método para consultar
        //colocar biblioteca Using system.Data;
        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "select * from colaborador";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.fecharconexao();
            
          //Retomar a consulta SQL em formato de tabela
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
