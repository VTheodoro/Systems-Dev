using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_06_ifElese
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

        private void btn_escolher_Click(object sender, EventArgs e)
        {
            if(rdb_manha.Checked == true)
            {
                MessageBox.Show("Manhã Selecionado!");
            }
            else if(rdb_noite.Checked == true)
            {
                MessageBox.Show("Noite Selecionado!");
            }
            else if (rdb_tarde.Checked == true)
            {
                MessageBox.Show("Tarde Selecionado!");
            }
            else
            {
                MessageBox.Show("Selecione um Periodo.");
            }

        }
    }
}
