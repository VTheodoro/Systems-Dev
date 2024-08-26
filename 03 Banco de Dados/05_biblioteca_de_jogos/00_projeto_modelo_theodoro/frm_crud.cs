using System;
using System.Data;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_crud : Form
    {
        private DataRow _registro;
        private frm_principal _principal;

        public frm_crud(DataRow registro, frm_principal principal)
        {
            InitializeComponent();
            _registro = registro;
            _principal = principal;
            PreencherCampos();
        }

        private void PreencherCampos()
        {
            if (_registro != null)
            {
                txt_nome.Text = _registro["nome_jogo"].ToString();
                txt_desenvolvedora.Text = _registro["desenvolvedora"].ToString();
                txt_estilo.Text = _registro["estilo"].ToString();
                txt_ano.Text = _registro["ano_lancamento"].ToString();

                chk_switch.Checked = Convert.ToBoolean(_registro["plataforma_switch"]);
                chk_playstation.Checked = Convert.ToBoolean(_registro["plataforma_playstation"]);
                chk_cloud.Checked = Convert.ToBoolean(_registro["plataforma_cloud"]);
                chk_xbox.Checked = Convert.ToBoolean(_registro["plataforma_xbox"]);
                chk_pc.Checked = Convert.ToBoolean(_registro["plataforma_pc"]);
                chk_multiplataforma.Checked = Convert.ToBoolean(_registro["multiplataforma"]);

                rdb_sim.Checked = Convert.ToBoolean(_registro["online"]);
                rdb_nao.Checked = !Convert.ToBoolean(_registro["online"]);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                SalvarRegistro();
                _principal.AtualizarDataGridView(); // Atualiza o DataGridView no frm_principal
                this.Close();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Erro de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txt_nome.Text) &&
                   !string.IsNullOrWhiteSpace(txt_desenvolvedora.Text) &&
                   !string.IsNullOrWhiteSpace(txt_estilo.Text) &&
                   !string.IsNullOrWhiteSpace(txt_ano.Text);
        }

        private void SalvarRegistro()
        {
            if (_registro == null)
            {
                // Código para adicionar um novo registro
                _jogo.Adicionar(txt_nome.Text, txt_desenvolvedora.Text, txt_estilo.Text, txt_ano.Text,
                                chk_switch.Checked, chk_playstation.Checked, chk_cloud.Checked, chk_xbox.Checked, chk_pc.Checked,
                                chk_multiplataforma.Checked, rdb_sim.Checked);
            }
            else
            {
                // Código para atualizar o registro existente
                _jogo.Atualizar((int)_registro["id"], txt_nome.Text, txt_desenvolvedora.Text, txt_estilo.Text, txt_ano.Text,
                                chk_switch.Checked, chk_playstation.Checked, chk_cloud.Checked, chk_xbox.Checked, chk_pc.Checked,
                                chk_multiplataforma.Checked, rdb_sim.Checked);
            }
        }
    }
}
