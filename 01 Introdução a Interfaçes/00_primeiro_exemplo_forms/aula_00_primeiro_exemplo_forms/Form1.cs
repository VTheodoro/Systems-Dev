using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_00_primeiro_exemplo_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_botao1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Botão 1 Funcionando");

        }

        private void btn_outrobotao_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Botão 2 Funcionando");

        }
    }
}
