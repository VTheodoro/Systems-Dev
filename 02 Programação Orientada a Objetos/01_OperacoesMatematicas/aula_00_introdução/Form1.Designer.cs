namespace aula_00_introdução
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
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btn_somar = new System.Windows.Forms.Button();
            this.btn_subitrair = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(12, 35);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_numero1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2:";
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(12, 84);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_numero2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(208, 65);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(13, 16);
            this.lbl_resultado.TabIndex = 6;
            this.lbl_resultado.Text = "-";
            // 
            // btn_somar
            // 
            this.btn_somar.Location = new System.Drawing.Point(56, 123);
            this.btn_somar.Name = "btn_somar";
            this.btn_somar.Size = new System.Drawing.Size(75, 23);
            this.btn_somar.TabIndex = 7;
            this.btn_somar.Text = "Somar";
            this.btn_somar.UseVisualStyleBackColor = true;
            this.btn_somar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_subitrair
            // 
            this.btn_subitrair.Location = new System.Drawing.Point(137, 123);
            this.btn_subitrair.Name = "btn_subitrair";
            this.btn_subitrair.Size = new System.Drawing.Size(75, 23);
            this.btn_subitrair.TabIndex = 8;
            this.btn_subitrair.Text = "Subtrair";
            this.btn_subitrair.UseVisualStyleBackColor = true;
            this.btn_subitrair.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(137, 152);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(75, 23);
            this.btn_multi.TabIndex = 9;
            this.btn_multi.Text = "Multiplicar";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Location = new System.Drawing.Point(56, 152);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(75, 23);
            this.btn_dividir.TabIndex = 10;
            this.btn_dividir.Text = "Dividir";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 225);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_subitrair);
            this.Controls.Add(this.btn_somar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numero1);
            this.Name = "Form1";
            this.Text = "Introdução a POO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btn_somar;
        private System.Windows.Forms.Button btn_subitrair;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_dividir;
    }
}

