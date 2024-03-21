using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_08_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_res_Click(object sender, EventArgs e)
        {
            double peso, altura;

            peso = double.Parse(txt_peso.Text);
            altura = double.Parse(txt_altura.Text);

            double imc = peso / (altura * altura);

            if (imc < 16)
            {
                lbl_res.Text = "Baixo peso grau III";
                lbl_res.ForeColor = Color.Red;
            }
            else if (imc >= 16 && imc <= 16.99){
                lbl_res.Text = "Baixo peso grau II";
                lbl_res.ForeColor = Color.Red;
            }
            else if (imc >= 17 && imc <= 18.49){
                lbl_res.Text = "Baixo peso grau I";
                lbl_res.ForeColor = Color.Yellow;
            }
            else if(imc >= 18.50 && imc <= 24.99){
                lbl_res.Text = "Peso saudável!";
                lbl_res.ForeColor = Color.Green;
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                lbl_res.Text = "Sobrepeso";
                lbl_res.ForeColor = Color.Yellow;
            }
            else if(imc >= 30 && imc <= 34.99)
            {
                lbl_res.Text = "Obesidade Grau I";
                lbl_res.ForeColor = Color.Yellow;
            }
            else if (imc >= 35 && imc <= 39.99)
            {
                lbl_res.Text = "Obesidade Grau II";
                lbl_res.ForeColor = Color.Red;
            }
            else if (imc >= 40)
            {
                lbl_res.Text = "Obesidade Grau III";
                lbl_res.ForeColor = Color.Red;
            }

        }
    }
}
