using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_07_notasCPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, nota4;

            nota1 = double.Parse(txt_nota1.Text);
            nota2 = double.Parse(txt_nota2.Text);
            nota3 = double.Parse(txt_nota3.Text);
            nota4 = double.Parse(txt_nota4.Text);

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media < 5)
            {
                txt_res.Text = "I";
                txt_res.ForeColor = Color.Red;
            }
            else if (media >= 5 && media <= 7)
            {
                txt_res.Text = "R";
                txt_res.ForeColor = Color.Orange;
            }
            else if(media > 7 && media < 9)
            {
                txt_res.Text = "B";
                txt_res.ForeColor = Color.Blue;
            }
            else if (media >= 9)
            {
                txt_res.Text = "MB";
                txt_res.ForeColor = Color.Blue;
            }


        }
    }
}
