using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace projetoCrudAnimal
{
    class Animal : conexao
    {
        private string nome;
        private int idade;
        private string sexo;
        private string especie;
        private int peso;
        private int tamanho;

        public void SetNome(string nome) => this.nome = nome;
        public string GetNome() => this.nome;

        public void SetIdade(int idade) => this.idade = idade;
        public int GetIdade() => this.idade;

        public void SetSexo(string sexo) => this.sexo = sexo;
        public string GetSexo() => this.sexo;

        public void SetEspecie(string especie) => this.especie = especie;
        public string GetEspecie() => this.especie;

        public void SetPeso(int peso) => this.peso = peso;
        public int GetPeso() => this.peso;

        public void SetTamanho(int tamanho) => this.tamanho = tamanho;
        public int GetTamanho() => this.tamanho;

        public void Inserir()
        {
            string query = "INSERT INTO animal (nome_animal, idade_animal, sexo_animal, especie_animal, peso_animal, tamanho_animal) " +
                           "VALUES (@nome, @idade, @sexo, @especie, @peso, @tamanho)";

            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@nome", GetNome());
                    cmd.Parameters.AddWithValue("@idade", GetIdade());
                    cmd.Parameters.AddWithValue("@sexo", GetSexo());
                    cmd.Parameters.AddWithValue("@especie", GetEspecie());
                    cmd.Parameters.AddWithValue("@peso", GetPeso());
                    cmd.Parameters.AddWithValue("@tamanho", GetTamanho());

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao inserir dados: " + ex.Message);
                    }
                }
                this.fecharconexao();
            }
        }

        public void Excluir()
        {
            string query = "DELETE FROM animal WHERE nome_animal = @nome";

            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                {
                    cmd.Parameters.AddWithValue("@nome", GetNome());

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao excluir dados: " + ex.Message);
                    }
                }
                this.fecharconexao();
            }
        }

        public void Alterar()
        {
            string query = "UPDATE animal SET idade_animal = @idade, sexo_animal = @sexo, especie_animal = @especie, peso_animal = @peso, tamanho_animal = @tamanho WHERE nome_animal = @nome";

            if (this.abrirconexao())
            {
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conectar))
                    {

                        cmd.Parameters.AddWithValue("@nome", GetNome());
                        cmd.Parameters.AddWithValue("@idade", GetIdade());
                        cmd.Parameters.AddWithValue("@sexo", GetSexo());
                        cmd.Parameters.AddWithValue("@especie", GetEspecie());
                        cmd.Parameters.AddWithValue("@peso", GetPeso());
                        cmd.Parameters.AddWithValue("@tamanho", GetTamanho());

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("Nenhum registro encontrado para atualizar.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    System.Windows.Forms.MessageBox.Show("Erro ao atualizar dados: " + ex.Message);
                }
                finally
                {
                    this.fecharconexao();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Não foi possível abrir a conexão com o banco de dados.");
            }
        }

       
        public DataTable Consultar()
        {
            DataTable dt = new DataTable();
            string mSQL = "SELECT * FROM animal";

            if (this.abrirconexao())
            {
                using (MySqlCommand cmd = new MySqlCommand(mSQL, conectar))
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
                this.fecharconexao();
            }

            return dt;
        }
    }
}
