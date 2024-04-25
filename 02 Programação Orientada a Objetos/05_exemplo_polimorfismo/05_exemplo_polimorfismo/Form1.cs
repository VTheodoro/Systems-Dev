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
        empregado z = new empregado();
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (rdb_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rdb_comissionado.Checked)
            {
                objeto = new comissionado();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else if (rdb_horista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lbl_vencimento.Text = objeto.vencimento(t).ToString();
            }
            else
            {
                if (txt_nome.Text == "" | txt_sobrenome.Text == "" | txt_cpf.Text == "")
                {
                    MessageBox.Show("Preencha todas as caixas e valores necessarios!");
                }
                else
                {
                    MessageBox.Show("Selecione um Tipo!");
                }
            }

            if(txt_nome.Text=="" | txt_sobrenome.Text == "" | txt_cpf.Text == "")
            {
                MessageBox.Show("Preencha todas as caixas");
            }

            lbl_nome.Text = z.getNome();
            lbl_sobrenome.Text = z.getSobrenome();
            lbl_cpf.Text = z.getCpf();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            z.setNome(txt_nome.Text);
            z.setSobrenome(txt_sobrenome.Text);
            z.setCpf(txt_cpf.Text);
        }

        private void lbl_vencimento_Click(object sender, EventArgs e)
        {

        }
    }
}
