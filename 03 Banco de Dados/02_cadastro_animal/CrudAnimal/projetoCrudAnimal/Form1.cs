using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoCrudAnimal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        animal a = new animal();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
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
                    a.setNome(txt_nome.Text);
                    a.setIdade(txt_idade.Text);
                    a.setEspecie(txt_especie.Text);
                    a.setPeso(txt_peso.Text);
                    a.setTamanho(txt_tamanho.Text);

                    if (rdb_femea.Checked)
                    {
                        a.setSexo("Fêmea");
                    }
                    else if (rdb_macho.Checked)
                    {
                        a.setSexo("Macho");
                    }

                    a.inserir();

                    MessageBox.Show("Informações salvas com sucesso!");
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
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                a.setNome(txt_nome.Text);
                a.excluir();
                dataGridView1.DataSource = a.Consultar();
            }
            finally
            {
                MessageBox.Show("As Informações Selecionadas Foram Deletadas.");
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
    }
}
