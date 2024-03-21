using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Media4Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        operacoes op = new operacoes();
        private void btn_res_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txt_n1.Text);
            int num2 = int.Parse(txt_n2.Text);
            int num3 = int.Parse(txt_n3.Text);
            int num4 = int.Parse(txt_n4.Text);

            int resultado = op.calcular(num1, num2, num3, num4);

            lbl_res.Text = "" + resultado;

            if(resultado < 5)
            {
                lbl_res.ForeColor = Color.Red;
            }
            else if (resultado >= 5 && resultado <= 7)
            {
                lbl_res.ForeColor = Color.Yellow;
            }
            else if (resultado > 7)
            {
                lbl_res.ForeColor = Color.Green;
            }

        }
    }
}
