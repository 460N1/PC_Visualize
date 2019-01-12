using System;
using System.Windows.Forms;

namespace PC_Visualize
{
    public partial class frmLogOn : Form
    {
        public frmLogOn()
        {
            InitializeComponent();
        }

        private void btnLogOn_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "123456")
            {
                new frmKryesore().Show();
                this.Hide();
            }
            else if(txtPassword.Text=="")
                MessageBox.Show("Ju lutem shkruajeni fjalekalimin!", "Gabim!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            else MessageBox.Show("Keni shtypur passwordin e gabuar!", "Gabim!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogOn.PerformClick();
        }

        private void btnKontrollo_Click(object sender, EventArgs e)
        {
            PC_Visualize pc = new PC_Visualize(false);
            pc.Kontrollo_Statusin_e_Kompjuterit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void shutDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void sleepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnPyetje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Perdore passwordin 123456");
        }

        private void frmLogOn_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void lblFIEK_Click(object sender, EventArgs e)
        {

        }
    }
}
