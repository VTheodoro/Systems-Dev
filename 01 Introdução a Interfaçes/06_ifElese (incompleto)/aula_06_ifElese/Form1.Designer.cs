namespace aula_06_ifElese
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
            this.rdb_manha = new System.Windows.Forms.RadioButton();
            this.rdb_tarde = new System.Windows.Forms.RadioButton();
            this.rdb_noite = new System.Windows.Forms.RadioButton();
            this.btn_escolher = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_escolher);
            this.groupBox1.Controls.Add(this.rdb_noite);
            this.groupBox1.Controls.Add(this.rdb_tarde);
            this.groupBox1.Controls.Add(this.rdb_manha);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Período";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdb_manha
            // 
            this.rdb_manha.AutoSize = true;
            this.rdb_manha.Location = new System.Drawing.Point(6, 33);
            this.rdb_manha.Name = "rdb_manha";
            this.rdb_manha.Size = new System.Drawing.Size(58, 17);
            this.rdb_manha.TabIndex = 0;
            this.rdb_manha.Text = "Manha";
            this.rdb_manha.UseVisualStyleBackColor = true;
            // 
            // rdb_tarde
            // 
            this.rdb_tarde.AutoSize = true;
            this.rdb_tarde.Location = new System.Drawing.Point(6, 56);
            this.rdb_tarde.Name = "rdb_tarde";
            this.rdb_tarde.Size = new System.Drawing.Size(53, 17);
            this.rdb_tarde.TabIndex = 1;
            this.rdb_tarde.Text = "Tarde";
            this.rdb_tarde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdb_tarde.UseVisualStyleBackColor = true;
            // 
            // rdb_noite
            // 
            this.rdb_noite.AutoSize = true;
            this.rdb_noite.Location = new System.Drawing.Point(6, 79);
            this.rdb_noite.Name = "rdb_noite";
            this.rdb_noite.Size = new System.Drawing.Size(50, 17);
            this.rdb_noite.TabIndex = 2;
            this.rdb_noite.Text = "Noite";
            this.rdb_noite.UseVisualStyleBackColor = true;
            // 
            // btn_escolher
            // 
            this.btn_escolher.Location = new System.Drawing.Point(87, 56);
            this.btn_escolher.Name = "btn_escolher";
            this.btn_escolher.Size = new System.Drawing.Size(75, 23);
            this.btn_escolher.TabIndex = 3;
            this.btn_escolher.Text = "Escolher";
            this.btn_escolher.UseVisualStyleBackColor = true;
            this.btn_escolher.Click += new System.EventHandler(this.btn_escolher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 564);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Teste de Condições";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_escolher;
        private System.Windows.Forms.RadioButton rdb_noite;
        private System.Windows.Forms.RadioButton rdb_tarde;
        private System.Windows.Forms.RadioButton rdb_manha;
    }
}

