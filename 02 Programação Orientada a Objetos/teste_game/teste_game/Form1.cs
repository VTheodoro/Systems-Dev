using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teste_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Inimigo inimigo = new Inimigo();
        private Jogador jogador = new Jogador();

        private void btn_atacar_Click(object sender, EventArgs e)
        {
            jogador.AtacarInimigo(inimigo);
            lbl_vida.Text = inimigo.Life.ToString();
        }


    }
}
