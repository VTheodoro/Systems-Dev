using System;
using System.Drawing;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_login : Form
    {
        public string nomeProjeto = "Biblioteca Games"; // Nome do projeto

        // Informações de login padrão
        private string usuario = "admin";
        private string senha = "123";

        private bool verificacao = false; // Verificação do login

        public frm_login()
        {
            InitializeComponent();
            // Configuração dos eventos
            txt_senha.TextChanged += txt_senha_TextChanged;
            txt_usuario.TextChanged += txt_usuario_TextChanged;
            cb_mostrarSenha.CheckedChanged += cb_mostrarSenha_CheckedChanged;
            btn_acessar.Click += btn_acessar_Click;
            btn_sair.Click += btn_sair_Click;
            lbl_ajuda.Click += lbl_ajuda_Click;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_usuario.Text == usuario)
            {
                txt_usuario.BackColor = Color.LightGreen;
            }
            else
            {
                txt_usuario.BackColor = Color.LightCoral;
            }
            VerificarCampos();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            if (txt_senha.Text == senha)
            {
                txt_senha.BackColor = Color.LightGreen;
            }
            else
            {
                txt_senha.BackColor = Color.LightCoral;
            }
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            if (txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                verificacao = true;
                btn_acessar.Cursor = Cursors.Hand;
                btn_acessar.BackColor = Color.FromArgb(23, 154, 254); // Altera a cor do botão
                btn_acessar.Enabled = true;
            }
            else
            {
                verificacao = false;
                btn_acessar.Cursor = Cursors.No;
                btn_acessar.BackColor = Color.FromArgb(1, 75, 131); // Cor padrão do botão
                btn_acessar.Enabled = false;
            }
        }

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = cb_mostrarSenha.Checked ? '\0' : '*'; // Mostrar ou ocultar senha
        }

        private void btn_acessar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                frm_principal f = new frm_principal();
                f.Show();
                this.Hide();

                txt_usuario.BackColor = Color.LightGreen;
                txt_senha.BackColor = Color.LightGreen;
            }
            else
            {
                btn_acessar.BackColor = Color.FromArgb(1, 75, 131); // Cor padrão do botão
                btn_acessar.Enabled = false;
            }
        }

        private void lbl_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O LOGIN PADRÃO DOS CÓDIGOS DE VICTOR THEODORO É\n-\nUSUÁRIO: admin\nSENHA: 123", "Ajuda com o Login");
        }
    }
}
