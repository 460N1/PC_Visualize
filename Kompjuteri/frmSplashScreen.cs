using System;
using System.Windows.Forms;

namespace PC_Visualize
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                new frmLogOn().Show();
                this.Hide();
            }
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblStarting_Click(object sender, EventArgs e)
        {

        }

        private void lblFIEK_Click(object sender, EventArgs e)
        {

        }
    }
}
