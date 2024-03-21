namespace aula_04_eleitores
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
            this.txt_eleitores = new System.Windows.Forms.TextBox();
            this.txt_branco = new System.Windows.Forms.TextBox();
            this.txt_nulosIn = new System.Windows.Forms.TextBox();
            this.txt_validosIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nulos = new System.Windows.Forms.Label();
            this.txt_validos = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_res_branco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_res_nulos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_res_validos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_eleitores
            // 
            this.txt_eleitores.Location = new System.Drawing.Point(16, 58);
            this.txt_eleitores.Name = "txt_eleitores";
            this.txt_eleitores.Size = new System.Drawing.Size(123, 20);
            this.txt_eleitores.TabIndex = 0;
            // 
            // txt_branco
            // 
            this.txt_branco.Location = new System.Drawing.Point(16, 101);
            this.txt_branco.Name = "txt_branco";
            this.txt_branco.Size = new System.Drawing.Size(123, 20);
            this.txt_branco.TabIndex = 1;
            // 
            // txt_nulosIn
            // 
            this.txt_nulosIn.Location = new System.Drawing.Point(195, 58);
            this.txt_nulosIn.Name = "txt_nulosIn";
            this.txt_nulosIn.Size = new System.Drawing.Size(116, 20);
            this.txt_nulosIn.TabIndex = 2;
            // 
            // txt_validosIn
            // 
            this.txt_validosIn.Location = new System.Drawing.Point(195, 101);
            this.txt_validosIn.Name = "txt_validosIn";
            this.txt_validosIn.Size = new System.Drawing.Size(116, 20);
            this.txt_validosIn.TabIndex = 3;
            this.txt_validosIn.TextChanged += new System.EventHandler(this.txt_votosIn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o total de eleitores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de votos em branco:";
            // 
            // txt_nulos
            // 
            this.txt_nulos.AutoSize = true;
            this.txt_nulos.Location = new System.Drawing.Point(192, 42);
            this.txt_nulos.Name = "txt_nulos";
            this.txt_nulos.Size = new System.Drawing.Size(119, 13);
            this.txt_nulos.TabIndex = 6;
            this.txt_nulos.Text = "Número de votos nulos:";
            this.txt_nulos.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_validos
            // 
            this.txt_validos.AutoSize = true;
            this.txt_validos.Location = new System.Drawing.Point(192, 85);
            this.txt_validos.Name = "txt_validos";
            this.txt_validos.Size = new System.Drawing.Size(127, 13);
            this.txt_validos.TabIndex = 7;
            this.txt_validos.Text = "Número de votos válidos:";
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(111, 141);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(106, 43);
            this.btn_resultado.TabIndex = 8;
            this.btn_resultado.Text = "Mostrar Resultado";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Votos em Branco:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txt_res_branco
            // 
            this.txt_res_branco.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_res_branco.Location = new System.Drawing.Point(12, 218);
            this.txt_res_branco.Name = "txt_res_branco";
            this.txt_res_branco.ReadOnly = true;
            this.txt_res_branco.Size = new System.Drawing.Size(91, 20);
            this.txt_res_branco.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Votos Nulos:";
            // 
            // txt_res_nulos
            // 
            this.txt_res_nulos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_res_nulos.Location = new System.Drawing.Point(126, 218);
            this.txt_res_nulos.Name = "txt_res_nulos";
            this.txt_res_nulos.ReadOnly = true;
            this.txt_res_nulos.Size = new System.Drawing.Size(91, 20);
            this.txt_res_nulos.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(231, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Votos em Válidos:";
            // 
            // txt_res_validos
            // 
            this.txt_res_validos.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txt_res_validos.Location = new System.Drawing.Point(231, 218);
            this.txt_res_validos.Name = "txt_res_validos";
            this.txt_res_validos.ReadOnly = true;
            this.txt_res_validos.Size = new System.Drawing.Size(91, 20);
            this.txt_res_validos.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_res_validos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_res_nulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_res_branco);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.txt_validos);
            this.Controls.Add(this.txt_nulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_validosIn);
            this.Controls.Add(this.txt_nulosIn);
            this.Controls.Add(this.txt_branco);
            this.Controls.Add(this.txt_eleitores);
            this.Name = "Form1";
            this.Text = "Total de Eleitores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_eleitores;
        private System.Windows.Forms.TextBox txt_branco;
        private System.Windows.Forms.TextBox txt_nulosIn;
        private System.Windows.Forms.TextBox txt_validosIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_nulos;
        private System.Windows.Forms.Label txt_validos;
        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_res_branco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_res_nulos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_res_validos;
    }
}

