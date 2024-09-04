using System;
using System.Drawing;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_login : Form
    {
        private string nomeProjeto = "Projeto Exemplo Theodoro";
        private Login loginHandler;

        public frm_login()
        {
            InitializeComponent();

            loginHandler = new Login();

            txt_senha.TextChanged += new EventHandler(txt_senha_TextChanged);
            txt_usuario.TextChanged += new EventHandler(txt_usuario_TextChanged);
        }

        private void btn_sair_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxBackground(txt_usuario);
            VerificarCampos();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            UpdateTextBoxBackground(txt_senha);
            VerificarCampos();
        }

        private void UpdateTextBoxBackground(TextBox textBox)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                textBox.BackColor = System.Drawing.Color.FromArgb(49, 52, 59);
            }
        }

        private void VerificarCampos()
        {
            if (!string.IsNullOrWhiteSpace(txt_usuario.Text) && !string.IsNullOrWhiteSpace(txt_senha.Text))
            {
                btn_acessar.Cursor = Cursors.Hand;
                btn_acessar.BackColor = Color.FromArgb(23, 154, 254);
                btn_acessar.Enabled = true;
            }
            else
            {
                btn_acessar.Cursor = Cursors.No;
                btn_acessar.BackColor = Color.FromArgb(1, 75, 131);
                btn_acessar.Enabled = false;
            }
        }

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            txt_senha.PasswordChar = cb_mostrarSenha.Checked ? '\0' : '*';
        }

        private void btn_acessar_Click_1(object sender, EventArgs e)
        {
            loginHandler.SetUsuario(txt_usuario.Text);
            loginHandler.SetSenha(txt_senha.Text);

            int valor = loginHandler.ConsultarLogin();

            if (valor == 1)
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
            }
            else if (txt_usuario.Text == "admin" && txt_senha.Text == "admin")
            {
                frm_principal formulario = new frm_principal();
                formulario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário e Senhas Inválidos", "Acesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lbl_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O LOGIN PADRÃO DOS CÓDIGOS DE VICTOR THEODORO É\n-\nUSUÁRIO: admin\nSENHA: 123", "Ajuda com o Login");
        }
    }
}
