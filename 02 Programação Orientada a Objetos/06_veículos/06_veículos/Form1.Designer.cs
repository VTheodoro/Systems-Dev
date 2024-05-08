namespace _06_veículos
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
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_caminhao = new System.Windows.Forms.RadioButton();
            this.rdb_carro = new System.Windows.Forms.RadioButton();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.txt_modelo = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_armazenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_cor = new System.Windows.Forms.Label();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.lbl_modelo = new System.Windows.Forms.Label();
            this.lbl_portas = new System.Windows.Forms.Label();
            this.lbl_carga = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(203, 211);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(123, 62);
            this.btn_mostrar.TabIndex = 0;
            this.btn_mostrar.Text = "Imprimir Informações";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_caminhao);
            this.groupBox1.Controls.Add(this.rdb_carro);
            this.groupBox1.Location = new System.Drawing.Point(23, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do Veículo:";
            // 
            // rdb_caminhao
            // 
            this.rdb_caminhao.AutoSize = true;
            this.rdb_caminhao.Location = new System.Drawing.Point(23, 55);
            this.rdb_caminhao.Name = "rdb_caminhao";
            this.rdb_caminhao.Size = new System.Drawing.Size(72, 17);
            this.rdb_caminhao.TabIndex = 1;
            this.rdb_caminhao.TabStop = true;
            this.rdb_caminhao.Text = "Caminhão";
            this.rdb_caminhao.UseVisualStyleBackColor = true;
            // 
            // rdb_carro
            // 
            this.rdb_carro.AutoSize = true;
            this.rdb_carro.Location = new System.Drawing.Point(23, 32);
            this.rdb_carro.Name = "rdb_carro";
            this.rdb_carro.Size = new System.Drawing.Size(50, 17);
            this.rdb_carro.TabIndex = 0;
            this.rdb_carro.TabStop = true;
            this.rdb_carro.Text = "Carro";
            this.rdb_carro.UseVisualStyleBackColor = true;
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(18, 276);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 20);
            this.txt_ano.TabIndex = 2;
            // 
            // txt_modelo
            // 
            this.txt_modelo.Location = new System.Drawing.Point(18, 233);
            this.txt_modelo.Name = "txt_modelo";
            this.txt_modelo.Size = new System.Drawing.Size(100, 20);
            this.txt_modelo.TabIndex = 3;
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(18, 321);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(100, 20);
            this.txt_cor.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ano de Fabricação";
            // 
            // btn_armazenar
            // 
            this.btn_armazenar.Location = new System.Drawing.Point(18, 370);
            this.btn_armazenar.Name = "btn_armazenar";
            this.btn_armazenar.Size = new System.Drawing.Size(123, 62);
            this.btn_armazenar.TabIndex = 10;
            this.btn_armazenar.Text = "Armazenar Informações";
            this.btn_armazenar.UseVisualStyleBackColor = true;
            this.btn_armazenar.Click += new System.EventHandler(this.btn_armazenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ano de Fabricação:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cor:";
            // 
            // lbl_cor
            // 
            this.lbl_cor.AutoSize = true;
            this.lbl_cor.Location = new System.Drawing.Point(522, 233);
            this.lbl_cor.Name = "lbl_cor";
            this.lbl_cor.Size = new System.Drawing.Size(10, 13);
            this.lbl_cor.TabIndex = 16;
            this.lbl_cor.Text = "-";
            // 
            // lbl_ano
            // 
            this.lbl_ano.AutoSize = true;
            this.lbl_ano.Location = new System.Drawing.Point(522, 276);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(10, 13);
            this.lbl_ano.TabIndex = 15;
            this.lbl_ano.Text = "-";
            // 
            // lbl_modelo
            // 
            this.lbl_modelo.AutoSize = true;
            this.lbl_modelo.Location = new System.Drawing.Point(522, 252);
            this.lbl_modelo.Name = "lbl_modelo";
            this.lbl_modelo.Size = new System.Drawing.Size(10, 13);
            this.lbl_modelo.TabIndex = 14;
            this.lbl_modelo.Text = "-";
            // 
            // lbl_portas
            // 
            this.lbl_portas.AutoSize = true;
            this.lbl_portas.Location = new System.Drawing.Point(522, 296);
            this.lbl_portas.Name = "lbl_portas";
            this.lbl_portas.Size = new System.Drawing.Size(10, 13);
            this.lbl_portas.TabIndex = 22;
            this.lbl_portas.Text = "-";
            // 
            // lbl_carga
            // 
            this.lbl_carga.AutoSize = true;
            this.lbl_carga.Location = new System.Drawing.Point(522, 315);
            this.lbl_carga.Name = "lbl_carga";
            this.lbl_carga.Size = new System.Drawing.Size(10, 13);
            this.lbl_carga.TabIndex = 20;
            this.lbl_carga.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(476, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Portas:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(403, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Capacidade de Carga:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 517);
            this.Controls.Add(this.lbl_portas);
            this.Controls.Add(this.lbl_carga);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_cor);
            this.Controls.Add(this.lbl_ano);
            this.Controls.Add(this.lbl_modelo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_armazenar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_modelo);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_mostrar);
            this.Name = "Form1";
            this.Text = "Gerenciamento de Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_caminhao;
        private System.Windows.Forms.RadioButton rdb_carro;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.TextBox txt_modelo;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_armazenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_cor;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.Label lbl_modelo;
        private System.Windows.Forms.Label lbl_portas;
        private System.Windows.Forms.Label lbl_carga;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
    }
}

