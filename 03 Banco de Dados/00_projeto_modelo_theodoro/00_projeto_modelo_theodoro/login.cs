using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace _00_projeto_modelo_theodoro
{
    class login
    {
        public int consultar_login()
        {
            this.abrirconexao();

            string mSQL = "Select count(usuario) from login where usuario = '" + getUsuario_l() + "' and senha = '" + getsenha_l() + "'";

            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            Int32 resultado_query = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();

            int valor_login;
            valor_login = resultado_query;
            this.fecharconexao();
            return valor_login;
        }

    }
}
