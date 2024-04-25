namespace _05_exemplo_polimorfismo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_set = new System.Windows.Forms.Button();
            this.txt_cpf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_cpf = new System.Windows.Forms.Label();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_vencimento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdb_comissionado = new System.Windows.Forms.RadioButton();
            this.rdb_horista = new System.Windows.Forms.RadioButton();
            this.rdb_assalariado = new System.Windows.Forms.RadioButton();
            this.btn_verificar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_set);
            this.groupBox1.Controls.Add(this.txt_cpf);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sobrenome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empregado";
            // 
            // btn_set
            // 
            this.btn_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_set.Location = new System.Drawing.Point(40, 125);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(112, 51);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Armazenar";
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_cpf
            // 
            this.txt_cpf.Location = new System.Drawing.Point(68, 83);
            this.txt_cpf.Name = "txt_cpf";
            this.txt_cpf.Size = new System.Drawing.Size(100, 20);
            this.txt_cpf.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF";
            // 
            // txt_sobrenome
            // 
            this.txt_sobrenome.Location = new System.Drawing.Point(68, 57);
            this.txt_sobrenome.Name = "txt_sobrenome";
            this.txt_sobrenome.Size = new System.Drawing.Size(100, 20);
            this.txt_sobrenome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(68, 32);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_cpf);
            this.groupBox2.Controls.Add(this.lbl_sobrenome);
            this.groupBox2.Controls.Add(this.lbl_nome);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbl_vencimento);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(414, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 128);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // lbl_cpf
            // 
            this.lbl_cpf.AutoSize = true;
            this.lbl_cpf.Location = new System.Drawing.Point(86, 64);
            this.lbl_cpf.Name = "lbl_cpf";
            this.lbl_cpf.Size = new System.Drawing.Size(10, 13);
            this.lbl_cpf.TabIndex = 12;
            this.lbl_cpf.Text = "-";
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Location = new System.Drawing.Point(86, 48);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(10, 13);
            this.lbl_sobrenome.TabIndex = 11;
            this.lbl_sobrenome.Text = "-";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(86, 32);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(10, 13);
            this.lbl_nome.TabIndex = 10;
            this.lbl_nome.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "CPF:";
            // 
            // lbl_vencimento
            // 
            this.lbl_vencimento.AutoSize = true;
            this.lbl_vencimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vencimento.Location = new System.Drawing.Point(139, 94);
            this.lbl_vencimento.Name = "lbl_vencimento";
            this.lbl_vencimento.Size = new System.Drawing.Size(18, 20);
            this.lbl_vencimento.TabIndex = 1;
            this.lbl_vencimento.Text = "0";
            this.lbl_vencimento.Click += new System.EventHandler(this.lbl_vencimento_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Sobrenome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data do Vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nome:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdb_comissionado);
            this.groupBox3.Controls.Add(this.rdb_horista);
            this.groupBox3.Controls.Add(this.rdb_assalariado);
            this.groupBox3.Location = new System.Drawing.Point(236, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 128);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Empregado";
            // 
            // rdb_comissionado
            // 
            this.rdb_comissionado.AutoSize = true;
            this.rdb_comissionado.Location = new System.Drawing.Point(28, 81);
            this.rdb_comissionado.Name = "rdb_comissionado";
            this.rdb_comissionado.Size = new System.Drawing.Size(90, 17);
            this.rdb_comissionado.TabIndex = 2;
            this.rdb_comissionado.TabStop = true;
            this.rdb_comissionado.Text = "Comissionado";
            this.rdb_comissionado.UseVisualStyleBackColor = true;
            // 
            // rdb_horista
            // 
            this.rdb_horista.AutoSize = true;
            this.rdb_horista.Location = new System.Drawing.Point(28, 58);
            this.rdb_horista.Name = "rdb_horista";
            this.rdb_horista.Size = new System.Drawing.Size(58, 17);
            this.rdb_horista.TabIndex = 1;
            this.rdb_horista.TabStop = true;
            this.rdb_horista.Text = "Horista";
            this.rdb_horista.UseVisualStyleBackColor = true;
            // 
            // rdb_assalariado
            // 
            this.rdb_assalariado.AutoSize = true;
            this.rdb_assalariado.Location = new System.Drawing.Point(28, 35);
            this.rdb_assalariado.Name = "rdb_assalariado";
            this.rdb_assalariado.Size = new System.Drawing.Size(79, 17);
            this.rdb_assalariado.TabIndex = 0;
            this.rdb_assalariado.TabStop = true;
            this.rdb_assalariado.Text = "Assalariado";
            this.rdb_assalariado.UseVisualStyleBackColor = true;
            // 
            // btn_verificar
            // 
            this.btn_verificar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_verificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_verificar.Location = new System.Drawing.Point(457, 170);
            this.btn_verificar.Name = "btn_verificar";
            this.btn_verificar.Size = new System.Drawing.Size(125, 67);
            this.btn_verificar.TabIndex = 3;
            this.btn_verificar.Text = "Verificar e Mostrar";
            this.btn_verificar.UseVisualStyleBackColor = false;
            this.btn_verificar.Click += new System.EventHandler(this.btn_verificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 249);
            this.Controls.Add(this.btn_verificar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_cpf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_vencimento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdb_comissionado;
        private System.Windows.Forms.RadioButton rdb_horista;
        private System.Windows.Forms.RadioButton rdb_assalariado;
        private System.Windows.Forms.Button btn_verificar;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.Label lbl_cpf;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

