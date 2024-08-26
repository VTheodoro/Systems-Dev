using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace _00_projeto_modelo_theodoro
{
    public class jogo : conexao
    {
        // Propriedades do jogo
        public string Nome { get; set; }
        public string Desenvolvedora { get; set; }
        public string Estilo { get; set; }
        public int AnoLancamento { get; set; }
        public bool PlataformaSwitch { get; set; }
        public bool PlataformaPlaystation { get; set; }
        public bool PlataformaCloud { get; set; }
        public bool PlataformaXbox { get; set; }
        public bool PlataformaPC { get; set; }
        public bool Online { get; set; }
        public bool Multiplataforma { get; set; }

        // Construtor padrão
        public jogo() { }

        // Construtor com parâmetros
        public jogo(string nome, string desenvolvedora, string estilo, int anoLancamento, bool plataformaSwitch, bool plataformaPlaystation,
                    bool plataformaCloud, bool plataformaXbox, bool plataformaPC, bool online, bool multiplataforma)
        {
            Nome = nome;
            Desenvolvedora = desenvolvedora;
            Estilo = estilo;
            AnoLancamento = anoLancamento;
            PlataformaSwitch = plataformaSwitch;
            PlataformaPlaystation = plataformaPlaystation;
            PlataformaCloud = plataformaCloud;
            PlataformaXbox = plataformaXbox;
            PlataformaPC = plataformaPC;
            Online = online;
            Multiplataforma = multiplataforma;
        }

        // Inserir jogo no banco de dados
        public void Inserir()
        {
            string query = "INSERT INTO jogos (nome_jogo, desenvolvedora, estilo, ano_lancamento, plataforma_switch, plataforma_playstation, plataforma_cloud, plataforma_xbox, plataforma_pc, online, multiplataforma) " +
                           "VALUES (@nome, @desenvolvedora, @estilo, @anoLancamento, @plataformaSwitch, @plataformaPlaystation, @plataformaCloud, @plataformaXbox, @plataformaPC, @online, @multiplataforma)";

            if (this.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@desenvolvedora", Desenvolvedora);
                    cmd.Parameters.AddWithValue("@estilo", Estilo);
                    cmd.Parameters.AddWithValue("@anoLancamento", AnoLancamento);
                    cmd.Parameters.AddWithValue("@plataformaSwitch", PlataformaSwitch);
                    cmd.Parameters.AddWithValue("@plataformaPlaystation", PlataformaPlaystation);
                    cmd.Parameters.AddWithValue("@plataformaCloud", PlataformaCloud);
                    cmd.Parameters.AddWithValue("@plataformaXbox", PlataformaXbox);
                    cmd.Parameters.AddWithValue("@plataformaPC", PlataformaPC);
                    cmd.Parameters.AddWithValue("@online", Online);
                    cmd.Parameters.AddWithValue("@multiplataforma", Multiplataforma);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Jogo inserido com sucesso!");
                    }
                    catch (MySqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    }
                }
                this.FecharConexao();
            }
        }

        // Consultar jogos no banco de dados
        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM jogos";

            if (this.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        try
                        {
                            da.Fill(dt);
                        }
                        catch (MySqlException ex)
                        {
                            System.Windows.Forms.MessageBox.Show("Erro ao consultar dados: " + ex.Message);
                        }
                    }
                }
                this.FecharConexao();
            }

            return dt;
        }

        // Atualizar um jogo no banco de dados
        public void Atualizar(int id)
        {
            string query = "UPDATE jogos SET nome_jogo = @nome, desenvolvedora = @desenvolvedora, estilo = @estilo, ano_lancamento = @anoLancamento, " +
                           "plataforma_switch = @plataformaSwitch, plataforma_playstation = @plataformaPlaystation, plataforma_cloud = @plataformaCloud, " +
                           "plataforma_xbox = @plataformaXbox, plataforma_pc = @plataformaPC, online = @online, multiplataforma = @multiplataforma " +
                           "WHERE id = @id";

            if (this.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@nome", Nome);
                    cmd.Parameters.AddWithValue("@desenvolvedora", Desenvolvedora);
                    cmd.Parameters.AddWithValue("@estilo", Estilo);
                    cmd.Parameters.AddWithValue("@anoLancamento", AnoLancamento);
                    cmd.Parameters.AddWithValue("@plataformaSwitch", PlataformaSwitch);
                    cmd.Parameters.AddWithValue("@plataformaPlaystation", PlataformaPlaystation);
                    cmd.Parameters.AddWithValue("@plataformaCloud", PlataformaCloud);
                    cmd.Parameters.AddWithValue("@plataformaXbox", PlataformaXbox);
                    cmd.Parameters.AddWithValue("@plataformaPC", PlataformaPC);
                    cmd.Parameters.AddWithValue("@online", Online);
                    cmd.Parameters.AddWithValue("@multiplataforma", Multiplataforma);
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Jogo atualizado com sucesso!");
                    }
                    catch (MySqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
                    }
                }
                this.FecharConexao();
            }
        }

        // Excluir um jogo do banco de dados
        public void Excluir(int id)
        {
            string query = "DELETE FROM jogos WHERE id = @id";

            if (this.AbrirConexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        System.Windows.Forms.MessageBox.Show("Jogo excluído com sucesso!");
                    }
                    catch (MySqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao excluir dados: " + ex.Message);
                    }
                }
                this.FecharConexao();
            }
        }
    }
}
