using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_04_eleitores
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

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            double eleitores, votosBrancos, votosNulos, votosValidos;
            double brancosRes, nulosRes, validosRes;

            eleitores = double.Parse(txt_eleitores.Text);
            votosBrancos = double.Parse(txt_branco.Text);
            votosNulos = double.Parse(txt_nulos.Text);
            votosValidos = double.Parse(txt_validos.Text);


            txt_resultado.Text = resultado.ToString();
        }
    }
}
