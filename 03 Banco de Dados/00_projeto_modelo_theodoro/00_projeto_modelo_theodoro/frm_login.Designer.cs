namespace _00_projeto_modelo_theodoro
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
            this.cb_mostrarSenha = new System.Windows.Forms.CheckBox();
            this.lbl_ajuda = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_alerta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_usuario.Location = new System.Drawing.Point(73, 116);
            this.txt_usuario.Margin = new System.Windows.Forms.Padding(5);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(518, 26);
            this.txt_usuario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUÁRIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(69, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "SENHA";
            // 
            // txt_senha
            // 
            this.txt_senha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.txt_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_senha.Location = new System.Drawing.Point(73, 183);
            this.txt_senha.Margin = new System.Windows.Forms.Padding(5);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.PasswordChar = '*';
            this.txt_senha.Size = new System.Drawing.Size(518, 26);
            this.txt_senha.TabIndex = 2;
            // 
            // btn_acessar
            // 
            this.btn_acessar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(75)))), ((int)(((byte)(131)))));
            this.btn_acessar.Cursor = System.Windows.Forms.Cursors.No;
            this.btn_acessar.Enabled = false;
            this.btn_acessar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_acessar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_acessar.Location = new System.Drawing.Point(192, 258);
            this.btn_acessar.Margin = new System.Windows.Forms.Padding(5);
            this.btn_acessar.Name = "btn_acessar";
            this.btn_acessar.Size = new System.Drawing.Size(265, 45);
            this.btn_acessar.TabIndex = 4;
            this.btn_acessar.Text = "Acessar";
            this.btn_acessar.UseVisualStyleBackColor = false;
            this.btn_acessar.Click += new System.EventHandler(this.btn_acessar_Click_1);
            // 
            // cb_mostrarSenha
            // 
            this.cb_mostrarSenha.AutoSize = true;
            this.cb_mostrarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_mostrarSenha.Location = new System.Drawing.Point(76, 219);
            this.cb_mostrarSenha.Margin = new System.Windows.Forms.Padding(5);
            this.cb_mostrarSenha.Name = "cb_mostrarSenha";
            this.cb_mostrarSenha.Size = new System.Drawing.Size(108, 19);
            this.cb_mostrarSenha.TabIndex = 6;
            this.cb_mostrarSenha.Text = "Exibir Senha";
            this.cb_mostrarSenha.UseVisualStyleBackColor = true;
            this.cb_mostrarSenha.CheckedChanged += new System.EventHandler(this.cb_mostrarSenha_CheckedChanged);
            // 
            // lbl_ajuda
            // 
            this.lbl_ajuda.AutoSize = true;
            this.lbl_ajuda.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl_ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajuda.Location = new System.Drawing.Point(12, 350);
            this.lbl_ajuda.Name = "lbl_ajuda";
            this.lbl_ajuda.Size = new System.Drawing.Size(211, 15);
            this.lbl_ajuda.TabIndex = 8;
            this.lbl_ajuda.Text = "Não consigo acessar o software";
            this.lbl_ajuda.Click += new System.EventHandler(this.lbl_ajuda_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.LightCoral;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Location = new System.Drawing.Point(576, 14);
            this.btn_sair.Margin = new System.Windows.Forms.Padding(5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(76, 25);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::_00_projeto_modelo_theodoro.Properties.Resources.logo_vt_bg_none;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(228, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 129);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_alerta
            // 
            this.lbl_alerta.AutoSize = true;
            this.lbl_alerta.Location = new System.Drawing.Point(209, 219);
            this.lbl_alerta.Name = "lbl_alerta";
            this.lbl_alerta.Size = new System.Drawing.Size(14, 20);
            this.lbl_alerta.TabIndex = 10;
            this.lbl_alerta.Text = ".";
            this.lbl_alerta.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(666, 384);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_alerta);
            this.Controls.Add(this.lbl_ajuda);
            this.Controls.Add(this.cb_mostrarSenha);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_acessar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_usuario);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(153)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.CheckBox cb_mostrarSenha;
        private System.Windows.Forms.Label lbl_ajuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_alerta;
    }
}