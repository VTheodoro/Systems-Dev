namespace aula_00_primeiro_exemplo_forms
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
            this.btn_botao1 = new System.Windows.Forms.Button();
            this.btn_outrobotao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_botao1
            // 
            this.btn_botao1.Location = new System.Drawing.Point(99, 158);
            this.btn_botao1.Name = "btn_botao1";
            this.btn_botao1.Size = new System.Drawing.Size(75, 23);
            this.btn_botao1.TabIndex = 0;
            this.btn_botao1.Text = "Clique Aqui";
            this.btn_botao1.UseVisualStyleBackColor = true;
            this.btn_botao1.Click += new System.EventHandler(this.btn_botao1_Click);
            // 
            // btn_outrobotao
            // 
            this.btn_outrobotao.Location = new System.Drawing.Point(99, 187);
            this.btn_outrobotao.Name = "btn_outrobotao";
            this.btn_outrobotao.Size = new System.Drawing.Size(75, 23);
            this.btn_outrobotao.TabIndex = 1;
            this.btn_outrobotao.Text = "Outro Botão";
            this.btn_outrobotao.UseVisualStyleBackColor = true;
            this.btn_outrobotao.Click += new System.EventHandler(this.btn_outrobotao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_outrobotao);
            this.Controls.Add(this.btn_botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_botao1;
        private System.Windows.Forms.Button btn_outrobotao;
    }
}

