namespace _04_estrutura_projeto
{
    public partial class frm_splash : Form
    {
        public frm_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();

                frm_login f = new frm_login();
                f.Show();
                this.Hide();
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void frm_splash_Load(object sender, EventArgs e)
        {

        }
    }
}
