using System;
using System.Drawing;
using System.Windows.Forms;

namespace projetoCrudAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Animal a = new Animal();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            txt_nome.BackColor = SystemColors.Window;
            txt_idade.BackColor = SystemColors.Window;
            txt_especie.BackColor = SystemColors.Window;
            txt_peso.BackColor = SystemColors.Window;
            txt_tamanho.BackColor = SystemColors.Window;

            bool todosCamposPreenchidos = true;

            if (string.IsNullOrWhiteSpace(txt_nome.Text))
            {
                txt_nome.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_idade.Text))
            {
                txt_idade.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (!rdb_femea.Checked && !rdb_macho.Checked)
            {
                MessageBox.Show("Por favor, selecione o sexo.");
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_especie.Text))
            {
                txt_especie.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_peso.Text))
            {
                txt_peso.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_tamanho.Text))
            {
                txt_tamanho.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }

            if (todosCamposPreenchidos)
            {
                try
                {
                    a.SetNome(txt_nome.Text);

                    // Converta os campos para inteiros antes de definir
                    a.SetIdade(int.Parse(txt_idade.Text));
                    a.SetPeso(int.Parse(txt_peso.Text));
                    a.SetTamanho(int.Parse(txt_tamanho.Text));
                    a.SetEspecie(txt_especie.Text);

                    if (rdb_femea.Checked)
                    {
                        a.SetSexo("Fêmea");
                    }
                    else if (rdb_macho.Checked)
                    {
                        a.SetSexo("Macho");
                    }

                    a.Inserir();
                    MessageBox.Show("Informações salvas com sucesso!");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erro de formatação: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao salvar as informações: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            dataGridView1.Columns["nome_animal"].HeaderText = "Nome";
            dataGridView1.Columns["idade_animal"].HeaderText = "Idade";
            dataGridView1.Columns["sexo_animal"].HeaderText = "Sexo";
            dataGridView1.Columns["especie_animal"].HeaderText = "Especie";
            dataGridView1.Columns["peso_animal"].HeaderText = "Peso";
            dataGridView1.Columns["tamanho_animal"].HeaderText = "Tamanho";

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            if (string.IsNullOrWhiteSpace(txt_nome.Text))
            {
                MessageBox.Show("Por favor, informe o nome do animal para exclusão.");
                return;
            }

            try
            {
                a.SetNome(txt_nome.Text);
                a.Excluir();
                dataGridView1.DataSource = a.Consultar(); // Atualiza a lista após exclusão
                MessageBox.Show("As informações selecionadas foram deletadas com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir as informações: " + ex.Message);
            }
        }
    

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_sexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txt_tamanho_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            // Verificar se todos os campos obrigatórios estão preenchidos
            txt_nome.BackColor = SystemColors.Window;
            txt_idade.BackColor = SystemColors.Window;
            txt_especie.BackColor = SystemColors.Window;
            txt_peso.BackColor = SystemColors.Window;
            txt_tamanho.BackColor = SystemColors.Window;

            bool todosCamposPreenchidos = true;

            if (string.IsNullOrWhiteSpace(txt_nome.Text))
            {
                txt_nome.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_idade.Text))
            {
                txt_idade.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (!rdb_femea.Checked && !rdb_macho.Checked)
            {
                MessageBox.Show("Por favor, selecione o sexo.");
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_especie.Text))
            {
                txt_especie.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_peso.Text))
            {
                txt_peso.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }
            if (string.IsNullOrWhiteSpace(txt_tamanho.Text))
            {
                txt_tamanho.BackColor = Color.Red;
                todosCamposPreenchidos = false;
            }

            if (todosCamposPreenchidos)
            {
                try
                {
                    a.SetNome(txt_nome.Text);

                    a.SetIdade(int.Parse(txt_idade.Text));
                    a.SetPeso(int.Parse(txt_peso.Text));
                    a.SetTamanho(int.Parse(txt_tamanho.Text));
                    a.SetEspecie(txt_especie.Text);

                    if (rdb_femea.Checked)
                    {
                        a.SetSexo("Fêmea");
                    }
                    else if (rdb_macho.Checked)
                    {
                        a.SetSexo("Macho");
                    }

                    a.Alterar(); 

                    dataGridView1.DataSource = a.Consultar();

                    MessageBox.Show("Informações atualizadas com sucesso!");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Erro de formatação: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar as informações: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = a.Consultar();
            txt_nome.Text = "";
            txt_especie.Text = "";
            txt_peso.Text = "";
            txt_idade.Text = "";
            txt_tamanho.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibiregistro(dataGridView1.CurrentRow.Index);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void exibiregistro(int i)
        {
            txt_nome.Text = "" + dataGridView1[0,i].Value;
            txt_especie.Text = "" + dataGridView1[3,i].Value;
            txt_peso.Text = "" + dataGridView1[4,i].Value;
            txt_idade.Text = "" + dataGridView1[1,i].Value;
            txt_tamanho.Text = "" + dataGridView1[5,i].Value;
        }
    }
}
