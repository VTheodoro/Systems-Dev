namespace aula_07_notasCPS
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
            this.btn_res = new System.Windows.Forms.Button();
            this.txt_nota4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_res = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_res);
            this.groupBox1.Controls.Add(this.txt_nota4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nota3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_nota2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_nota1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insira as  notas do aluno:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_res
            // 
            this.btn_res.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_res.Location = new System.Drawing.Point(72, 126);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(75, 23);
            this.btn_res.TabIndex = 8;
            this.btn_res.Text = "Confirmar";
            this.btn_res.UseVisualStyleBackColor = false;
            this.btn_res.Click += new System.EventHandler(this.btn_res_Click);
            // 
            // txt_nota4
            // 
            this.txt_nota4.Location = new System.Drawing.Point(121, 87);
            this.txt_nota4.Name = "txt_nota4";
            this.txt_nota4.Size = new System.Drawing.Size(100, 22);
            this.txt_nota4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nota 04:";
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(5, 87);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.Size = new System.Drawing.Size(100, 22);
            this.txt_nota3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nota 03:";
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(121, 45);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.Size = new System.Drawing.Size(100, 22);
            this.txt_nota2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nota 02:";
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(5, 45);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.Size = new System.Drawing.Size(100, 22);
            this.txt_nota1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota 01:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Menção Final do Aluno:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_res
            // 
            this.txt_res.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_res.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_res.Location = new System.Drawing.Point(74, 214);
            this.txt_res.Name = "txt_res";
            this.txt_res.ReadOnly = true;
            this.txt_res.Size = new System.Drawing.Size(100, 26);
            this.txt_res.TabIndex = 2;
            this.txt_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 252);
            this.Controls.Add(this.txt_res);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Média de Notas CPS";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.TextBox txt_nota4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_res;
    }
}

