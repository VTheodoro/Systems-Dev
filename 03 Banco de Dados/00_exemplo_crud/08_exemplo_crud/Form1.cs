using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        colaborador c = new colaborador();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nome.Text);
                c.setSobrenome(txt_sobrenome.Text);
                c.setCPF(txt_cpf.Text);
                c.inserir();
            }
            finally
            {
                MessageBox.Show("Informações Gravadas Com Sucesso");
            }

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = c.Consultar();



        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

            c.setCodigo(txt_codigo.Text);
            c.excluir();
            dataGridView1.DataSource = c.Consultar();
        }
    }
}
