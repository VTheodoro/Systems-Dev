using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_exemplo_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //não iremos terminar o instanciamento do objeto
        empregado objeto = null;
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rdb_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }




        }
    }
}
