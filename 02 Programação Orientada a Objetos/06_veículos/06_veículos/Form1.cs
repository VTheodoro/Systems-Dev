using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_veículos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        Veiculo obj = null;
        Veiculo z = new Veiculo();
        private void btn_mostrar_Click(object sender, EventArgs e)
        {

            if (txt_cor.Text == "" | txt_modelo.Text == "" | txt_ano.Text == "")
            {
                MessageBox.Show("Preencha todas as caixas");
            }

            lbl_cor.Text = z.getCor();
            lbl_modelo.Text = z.getModelo();
            lbl_ano.Text = z.getAno();

            if (rdb_carro.Checked)
            {
                lbl_portas.Text = ((Carro)obj).getPortas();
                lbl_carga.Text = "Não Aplicavel";
            }
            else if(rdb_caminhao.Checked){
                lbl_carga.Text = ((Caminhao)obj).getCarga();
                lbl_portas.Text = "2";
            }
        }



        private void btn_armazenar_Click(object sender, EventArgs e)
        {
            if (rdb_carro.Checked)
            {
                obj = new Carro();
                ((Carro)obj).setPortas(txt_x.Text);
                lbl_x.Text = "Quantidade de Portas:";
            }
            else if (rdb_caminhao.Checked)
            {
                obj = new Caminhao();
                lbl_x.Text = "Capacidade de Carga:";
                ((Caminhao)obj).setCarga(txt_x.Text);
            }
            else
            {
                MessageBox.Show("Selecione um Tipo!");
            }

            z.setCor(txt_cor.Text);
            z.setModelo(txt_modelo.Text);
            z.setAno(txt_ano.Text);
        }

    }
    
}
