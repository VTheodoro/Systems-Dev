﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00_projeto_modelo_theodoro
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1); //faz a barra de progresso carregar como uma demonstração
            if (progressBar1.Value == 100)
            {
                timer1.Stop();

                frm_login f = new frm_login();
                f.Show();
                this.Hide();
            }

        }
    }
}
