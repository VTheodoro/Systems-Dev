using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_00_introdução
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        operacoes_matematicas op = new operacoes_matematicas();
        // Instanciando um objeto

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt_numero1.Text);
            int numero2 = int.Parse(txt_numero2.Text);

            lbl_resultado.Text = "" + op.soma(numero1,numero2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt_numero1.Text);
            int numero2 = int.Parse(txt_numero2.Text);

            lbl_resultado.Text = "" + op.subitrair(numero1, numero2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt_numero1.Text);
            int numero2 = int.Parse(txt_numero2.Text);

            lbl_resultado.Text = "" + op.dividir(numero1, numero2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txt_numero1.Text);
            int numero2 = int.Parse(txt_numero2.Text);

            lbl_resultado.Text = "" + op.multiplicar(numero1, numero2);
        }
    }
}
