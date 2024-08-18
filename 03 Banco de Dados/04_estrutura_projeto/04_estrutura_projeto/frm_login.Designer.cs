namespace _04_estrutura_projeto
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
            btn_acessar = new Button();
            btn_sair = new Button();
            txt_usuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_senha = new TextBox();
            SuspendLayout();
            // 
            // btn_acessar
            // 
            btn_acessar.BackColor = Color.PaleGreen;
            btn_acessar.BackgroundImage = Properties.Resources.person_user_customer_man_male_man_boy_people_1687;
            btn_acessar.BackgroundImageLayout = ImageLayout.None;
            btn_acessar.Location = new Point(276, 46);
            btn_acessar.Name = "btn_acessar";
            btn_acessar.Size = new Size(136, 41);
            btn_acessar.TabIndex = 0;
            btn_acessar.Text = "Acessar";
            btn_acessar.UseVisualStyleBackColor = false;
            btn_acessar.Click += btn_acessar_Click;
            // 
            // btn_sair
            // 
            btn_sair.BackColor = Color.LightCoral;
            btn_sair.BackgroundImage = Properties.Resources.Logout_37127;
            btn_sair.BackgroundImageLayout = ImageLayout.None;
            btn_sair.Location = new Point(276, 102);
            btn_sair.Name = "btn_sair";
            btn_sair.Size = new Size(136, 41);
            btn_sair.TabIndex = 1;
            btn_sair.Text = "Sair";
            btn_sair.UseVisualStyleBackColor = false;
            btn_sair.Click += btn_sair_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(48, 56);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(168, 23);
            txt_usuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 38);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 94);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 5;
            label2.Text = "Senha:";
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(48, 112);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(168, 23);
            txt_senha.TabIndex = 4;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 188);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(txt_senha);
            Controls.Add(label1);
            Controls.Add(txt_usuario);
            Controls.Add(btn_sair);
            Controls.Add(btn_acessar);
            MinimizeBox = false;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_acessar;
        private Button btn_sair;
        private TextBox txt_usuario;
        private Label label1;
        private Label label2;
        private TextBox txt_senha;
    }
}