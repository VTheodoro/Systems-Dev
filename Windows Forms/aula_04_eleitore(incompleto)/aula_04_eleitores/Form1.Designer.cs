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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nulos = new System.Windows.Forms.Label();
            this.txt_validos = new System.Windows.Forms.Label();
            this.btn_resultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_eleitores
            // 
            this.txt_eleitores.Location = new System.Drawing.Point(16, 62);
            this.txt_eleitores.Name = "txt_eleitores";
            this.txt_eleitores.Size = new System.Drawing.Size(123, 20);
            this.txt_eleitores.TabIndex = 0;
            // 
            // txt_branco
            // 
            this.txt_branco.Location = new System.Drawing.Point(16, 105);
            this.txt_branco.Name = "txt_branco";
            this.txt_branco.Size = new System.Drawing.Size(123, 20);
            this.txt_branco.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(195, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(195, 105);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite o total de eleitores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Número de votos em branco:";
            // 
            // txt_nulos
            // 
            this.txt_nulos.AutoSize = true;
            this.txt_nulos.Location = new System.Drawing.Point(192, 46);
            this.txt_nulos.Name = "txt_nulos";
            this.txt_nulos.Size = new System.Drawing.Size(119, 13);
            this.txt_nulos.TabIndex = 6;
            this.txt_nulos.Text = "Número de votos nulos:";
            this.txt_nulos.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_validos
            // 
            this.txt_validos.AutoSize = true;
            this.txt_validos.Location = new System.Drawing.Point(192, 89);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 261);
            this.Controls.Add(this.btn_resultado);
            this.Controls.Add(this.txt_validos);
            this.Controls.Add(this.txt_nulos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_nulos;
        private System.Windows.Forms.Label txt_validos;
        private System.Windows.Forms.Button btn_resultado;
    }
}

