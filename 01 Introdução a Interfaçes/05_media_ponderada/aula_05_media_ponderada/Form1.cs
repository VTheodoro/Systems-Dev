using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_05_media_ponderada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3;

            nota1 = double.Parse(txt_nota1.Text);
            nota2 = double.Parse(txt_nota2.Text);
            nota3 = double.Parse(txt_nota3.Text);

            double mediaFinal = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

            txt_res.Text = mediaFinal.ToString();
        }
    }
}
