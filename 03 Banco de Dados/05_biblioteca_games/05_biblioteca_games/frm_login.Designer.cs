namespace _05_biblioteca_games
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.btn_acessar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_alerta = new System.Windows.Forms.Label();
            this.btn_ajuda = new System.Windows.Forms.Button();
            this.cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.SystemColors.Window;
            this.txt_usuario.Location = new System.Drawing.Point(22, 41);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(144, 20);
            this.txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // txt_senha
            // 
            this.txt_senha.Location = new System.Drawing.Point(22, 92);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(144, 20);
            this.txt_senha.TabIndex = 2;
            this.txt_senha.TextChanged += new System.EventHandler(this.txt_senha_TextChanged);
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.DarkGray;
            this.btn_acessar.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_acessar.Enabled = false;
            this.btn_acessar.Location = new System.Drawing.Point(274, 50);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(75, 23);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightCoral;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.Location = new System.Drawing.Point(274, 85);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 23);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_alerta
            // 
            this.lbl_alerta.AutoSize = true;
            this.lbl_alerta.Location = new System.Drawing.Point(28, 134);
            this.lbl_alerta.Name = "lbl_alerta";
            this.lbl_alerta.Size = new System.Drawing.Size(10, 13);
            this.lbl_alerta.TabIndex = 6;
            this.lbl_alerta.Text = ".";
            // 
            // btn_ajuda
            // 
            this.btn_ajuda.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ajuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.btn_ajuda.Location = new System.Drawing.Point(355, 50);
            this.btn_ajuda.Name = "btn_ajuda";
            this.btn_ajuda.Size = new System.Drawing.Size(24, 23);
            this.btn_ajuda.TabIndex = 7;
            this.btn_ajuda.Text = " ?";
            this.btn_ajuda.UseVisualStyleBackColor = false;
            this.btn_ajuda.Click += new System.EventHandler(this.btn_ajuda_Click);
            // 
            // cb_mostrarSenha
            // 
            this.cb_mostrarSenha.AutoSize = true;
            this.cb_mostrarSenha.Location = new System.Drawing.Point(22, 114);
            this.cb_mostrarSenha.Name = "cb_mostrarSenha";
            this.cb_mostrarSenha.Size = new System.Drawing.Size(92, 17);
            this.cb_mostrarSenha.TabIndex = 8;
            this.cb_mostrarSenha.Text = "Mostar Senha";
            this.cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 165);
            this.ControlBox = false;
            this.Controls.Add(this.cb_mostrarSenha);
            this.Controls.Add(this.btn_ajuda);
            this.Controls.Add(this.lbl_alerta);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_usuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Button btn_acessar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_alerta;
        private System.Windows.Forms.Button btn_ajuda;
        private System.Windows.Forms.CheckBox cb_mostrarSenha;
    }
}