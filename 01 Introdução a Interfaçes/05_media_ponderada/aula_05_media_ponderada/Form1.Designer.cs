namespace aula_05_media_ponderada
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.btn_res = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(40, 92);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(60, 20);
            this.txt_nota1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite as Notas do Aluno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota 3:";
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(189, 92);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(60, 20);
            this.txt_nota3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nota 2:";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(113, 92);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(60, 20);
            this.txt_nota2.TabIndex = 5;
            // 
            // btn_res
            // 
            this.btn_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_res.Location = new System.Drawing.Point(84, 133);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(122, 46);
            this.btn_res.TabIndex = 7;
            this.btn_res.Text = "Calcular Média Final";
            this.btn_res.UseVisualStyleBackColor = true;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Média Final Ponderada:";
            // 
            // txt_res
            // 
            this.txt_res.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_res.Location = new System.Drawing.Point(84, 221);
            this.txt_res.Name = "txt_res";
            this.txt_res.ReadOnly = true;
            this.txt_res.Size = new System.Drawing.Size(112, 20);
            this.txt_res.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 289);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_nota2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nota3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nota1);
            this.Name = "Form1";
            this.Text = "Média Ponderada";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_res;
    }
}

