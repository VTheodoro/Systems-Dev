namespace teste_game
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
            this.btn_atacar = new System.Windows.Forms.Button();
            this.lbl_vida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_atacar
            // 
            this.btn_atacar.Location = new System.Drawing.Point(115, 137);
            this.btn_atacar.Name = "btn_atacar";
            this.btn_atacar.Size = new System.Drawing.Size(75, 23);
            this.btn_atacar.TabIndex = 0;
            this.btn_atacar.Text = "atacar";
            this.btn_atacar.UseVisualStyleBackColor = true;
            this.btn_atacar.Click += new System.EventHandler(this.btn_atacar_Click);
            // 
            // lbl_vida
            // 
            this.lbl_vida.AutoSize = true;
            this.lbl_vida.Location = new System.Drawing.Point(138, 101);
            this.lbl_vida.Name = "lbl_vida";
            this.lbl_vida.Size = new System.Drawing.Size(25, 13);
            this.lbl_vida.TabIndex = 1;
            this.lbl_vida.Text = "100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 291);
            this.Controls.Add(this.lbl_vida);
            this.Controls.Add(this.btn_atacar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_atacar;
        private System.Windows.Forms.Label lbl_vida;
    }
}

