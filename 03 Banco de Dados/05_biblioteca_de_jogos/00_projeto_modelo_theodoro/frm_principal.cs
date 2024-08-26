using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_principal : Form
    {
        private jogo _jogo = new jogo();
        public string nomeProjeto = "Biblioteca Games";

        public frm_principal()
        {
            InitializeComponent();
            // Configuração dos eventos
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            reiniciarToolStripMenuItem.Click += reiniciarToolStripMenuItem_Click;
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            adicionarGameToolStripMenuItem.Click += adicionarGameToolStripMenuItem_Click;
            toolStripSair.Click += toolStripSair_Click;
            toolStripAdicionar.Click += toolStripAdicionar_Click;
            btn_consultar.Click += btn_consultar_Click;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?\nCertifique-se de salvar todo seu progresso.", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo reiniciar a biblioteca?\nIsso pode corrigir alguns problemas.", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair do seu Usuário atual?", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_login f = new frm_login();
                f.Show();
                this.Hide();
            }
        }

        private void adicionarGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCrudForm(null);
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            sairToolStripMenuItem_Click(sender, e);
        }

        private void toolStripAdicionar_Click(object sender, EventArgs e)
        {
            adicionarGameToolStripMenuItem_Click(sender, e);
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            AtualizarDataGridView();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                exibirRegistroJogo(rowIndex);
            }
        }

        public void AtualizarDataGridView()
        {
            DataTable dt = _jogo.Consultar();
            dataGridView1.DataSource = dt;

            // Atualiza os cabeçalhos das colunas
            dataGridView1.Columns["nome_jogo"].HeaderText = "Nome";
            dataGridView1.Columns["desenvolvedora"].HeaderText = "Desenvolvedora";
            dataGridView1.Columns["estilo"].HeaderText = "Estilo";
            dataGridView1.Columns["ano_lancamento"].HeaderText = "Ano de Lançamento";
            dataGridView1.Columns["plataforma_switch"].HeaderText = "Switch";
            dataGridView1.Columns["plataforma_playstation"].HeaderText = "PlayStation";
            dataGridView1.Columns["plataforma_cloud"].HeaderText = "Cloud";
            dataGridView1.Columns["plataforma_xbox"].HeaderText = "Xbox";
            dataGridView1.Columns["plataforma_pc"].HeaderText = "PC";
            dataGridView1.Columns["multiplataforma"].HeaderText = "Multiplataforma";
            dataGridView1.Columns["online"].HeaderText = "Online";
        }

        private void OpenCrudForm(DataRow registro)
        {
            frm_crud fCrud = new frm_crud(registro, this); // Passa o DataRow e a referência ao frm_principal
            fCrud.Show();
        }

        private void exibirRegistroJogo(int i)
        {
            if (dataGridView1.Rows.Count > i)
            {
                DataGridViewRow row = dataGridView1.Rows[i];

                txt_nome.Text = row.Cells["nome_jogo"].Value?.ToString();
                txt_desenvolvedora.Text = row.Cells["desenvolvedora"].Value?.ToString();
                txt_estilo.Text = row.Cells["estilo"].Value?.ToString();
                txt_ano.Text = row.Cells["ano_lancamento"].Value?.ToString();

                chk_switch.Checked = Convert.ToBoolean(row.Cells["plataforma_switch"].Value);
                chk_playstation.Checked = Convert.ToBoolean(row.Cells["plataforma_playstation"].Value);
                chk_cloud.Checked = Convert.ToBoolean(row.Cells["plataforma_cloud"].Value);
                chk_xbox.Checked = Convert.ToBoolean(row.Cells["plataforma_xbox"].Value);
                chk_pc.Checked = Convert.ToBoolean(row.Cells["plataforma_pc"].Value);
                chk_multiplataforma.Checked = Convert.ToBoolean(row.Cells["multiplataforma"].Value);

                rdb_sim.Checked = Convert.ToBoolean(row.Cells["online"].Value);
                rdb_nao.Checked = !Convert.ToBoolean(row.Cells["online"].Value);
            }
        }


    }
}
}
