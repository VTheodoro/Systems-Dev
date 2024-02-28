namespace aula_01_soma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_numero1 = new System.Windows.Forms.TextBox();
            this.txt_numero2 = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.btn_multiplicacao = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primeiro Número";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Segundo Número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_numero1
            // 
            this.txt_numero1.Location = new System.Drawing.Point(30, 61);
            this.txt_numero1.Name = "txt_numero1";
            this.txt_numero1.Size = new System.Drawing.Size(100, 20);
            this.txt_numero1.TabIndex = 4;
            this.txt_numero1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_numero2
            // 
            this.txt_numero2.Location = new System.Drawing.Point(30, 102);
            this.txt_numero2.Name = "txt_numero2";
            this.txt_numero2.Size = new System.Drawing.Size(100, 20);
            this.txt_numero2.TabIndex = 5;
            this.txt_numero2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_resultado
            // 
            this.txt_resultado.Location = new System.Drawing.Point(156, 81);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(100, 20);
            this.txt_resultado.TabIndex = 6;
            // 
            // btn_multiplicacao
            // 
            this.btn_multiplicacao.Image = global::aula_01_soma.Properties.Resources.multiplicationsign_80855;
            this.btn_multiplicacao.Location = new System.Drawing.Point(211, 145);
            this.btn_multiplicacao.Name = "btn_multiplicacao";
            this.btn_multiplicacao.Size = new System.Drawing.Size(61, 60);
            this.btn_multiplicacao.TabIndex = 9;
            this.btn_multiplicacao.UseVisualStyleBackColor = true;
            this.btn_multiplicacao.Click += new System.EventHandler(this.btn_multiplicacao_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Image = global::aula_01_soma.Properties.Resources.divisionsign_81003;
            this.btn_divisao.Location = new System.Drawing.Point(144, 145);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(61, 60);
            this.btn_divisao.TabIndex = 8;
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.btn_divisao_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Image = global::aula_01_soma.Properties.Resources.ic_delete_97600;
            this.btn_sub.Location = new System.Drawing.Point(77, 145);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(61, 60);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Image = global::aula_01_soma.Properties.Resources.create_new_add_plus_icon_219839;
            this.btn_soma.Location = new System.Drawing.Point(12, 145);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(59, 60);
            this.btn_soma.TabIndex = 0;
            this.btn_soma.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_somar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_multiplicacao);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_numero2);
            this.Controls.Add(this.txt_numero1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_soma);
            this.Name = "Form1";
            this.Text = "Operações Básicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_numero1;
        private System.Windows.Forms.TextBox txt_numero2;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Button btn_multiplicacao;
    }
}

