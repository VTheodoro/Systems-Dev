using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_login : Form
    { 
        private string nomeProjeto = "Projeto Exemplo Theodoro"; //<--- alterar nome do projeto conforme necessário :D

        //exemplo de informações de login padrões (alterar se necessário)
        private string usuario = "admin";
        private string senha = "123";

        private bool verificacao = false; //verificação do login

        public frm_login()
        {
            InitializeComponent();

            //verificação em tempo real das informações digitadas nos txts
            txt_senha.TextChanged += new EventHandler(txt_senha_TextChanged);
            txt_usuario.TextChanged += new EventHandler(txt_usuario_TextChanged);
        }


        private void btn_sair_Click_1(object sender, EventArgs e) //botão de sair do login
        {
            if (MessageBox.Show("Deseja mesmo sair?", nomeProjeto, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //métodos que verificam a mudança de texto do usuário e da senha --->
        private void txt_usuario_TextChanged(object sender, EventArgs e)
        {
            if (txt_usuario.Text == usuario)
            {
                txt_usuario.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txt_usuario.BackColor = System.Drawing.Color.LightCoral;
                lbl_alerta.Text = "USUÁRIO INVÁLIDO!";
                lbl_alerta.ForeColor = System.Drawing.Color.Red;
            }
            VerificarCampos();
        }

        private void txt_senha_TextChanged(object sender, EventArgs e)
        {
            if (txt_senha.Text == senha)
            {
                txt_senha.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                txt_senha.BackColor = System.Drawing.Color.LightCoral;
                lbl_alerta.Text = "SENHA INVÁLIDA!";
                lbl_alerta.ForeColor = System.Drawing.Color.Red;

            }
            VerificarCampos();
        }


        //método para verificar o login --->
        private void VerificarCampos()
        {
            if (txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                verificacao = true;
                btn_acessar.Cursor = Cursors.Hand;
                btn_acessar.BackColor = Color.FromArgb(23, 154, 254); //altera a cor do botão se ambos estiverem corretos
                btn_acessar.Enabled = true; //habilita o botão dnv
                lbl_alerta.Text = ""; //limpa a mensagem de alerta

            }
            else
            {
                verificacao = false;
                btn_acessar.Cursor = Cursors.No;
                btn_acessar.BackColor = Color.FromArgb(1, 75, 131); //volta a cor do botão pra cinza 
                btn_acessar.Enabled = false; //desabilita o botão dnv
            }
        }

        private void btn_ajuda_Click_1(object sender, EventArgs e)
        {
        }

        private void cb_mostrarSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_mostrarSenha.Checked)
            {
                txt_senha.PasswordChar = '\0'; //mostra a senha
            }
            else
            {
                txt_senha.PasswordChar = '*'; //oculta a senha
            }
        }

        private void btn_acessar_Click_1(object sender, EventArgs e)
        {
            if (txt_usuario.Text == usuario && txt_senha.Text == senha)
            {
                frm_principal f = new frm_principal();
                f.Show();
                txt_usuario.BackColor = System.Drawing.Color.LightGreen;
                txt_senha.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                btn_acessar.BackColor = Color.FromArgb(1, 75, 131);
                btn_acessar.Enabled = false; //desabilita o botão
            }
        }

        private void lbl_ajuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O LOGIN PADRÃO DOS CÓDIGOS DE VICTOR THEODORO É\n-\nUSUÁRIO: admin\nSENHA: 123", "Ajuda com o Login");
        }

    }

}
