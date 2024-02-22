using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_01_soma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_somar_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            res = n1 + n2;

            txt_resultado.Text = res.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            res = n1 - n2;

            txt_resultado.Text = res.ToString();
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            res = n1 / n2;

            txt_resultado.Text = res.ToString();
        }

        private void btn_multiplicacao_Click(object sender, EventArgs e)
        {
            double n1, n2, res;
            n1 = double.Parse(txt_numero1.Text);
            n2 = double.Parse(txt_numero2.Text);
            res = n1*n2;

            txt_resultado.Text = res.ToString();
        }
    }
}
