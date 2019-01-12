using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace PC_Visualize
{
    public partial class frmKryesore : Form
    {
        public frmKryesore()
        {
            InitializeComponent();
        }

        PC_Visualize pc = new PC_Visualize(true);
        bool btnClicked = false;

        private void frmKryesore_Load(object sender, EventArgs e)
        {
            lblOra.Text = DateTime.Now.ToString("HH:mm tt\ndd/MM/yyyy");
            pc.Programet(Programet);
        }

        private void btnHape_Click(object sender, EventArgs e)
        {
            btnClicked = true;
            pc.Hap_Programin(Programet.SelectedItem.ToString());
            try
            {
                Process.Start(@"..\..\Programet\"
                    + Programet.SelectedItem.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Programi nuk egziston ose nuk eshte gjetur fajli i duhur",
                    "Gabim gjate hapjes se programit?!",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnTrego_Click(object sender, EventArgs e)
        {
            if (btnClicked == true)
                pc.tregoVetite();
            else MessageBox.Show("Asnje program nuk eshte i hapur!!");
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

        private void btnKontrollo_Click(object sender, EventArgs e)
        {
            pc.Kontrollo_Statusin_e_Kompjuterit();
        }

        private void btnNdryshoBG_Click(object sender, EventArgs e)
        {
            DialogResult ndryshobg = openFileDialog1.ShowDialog();
            if (ndryshobg == DialogResult.OK)
                BackgroundImage = Image.FromFile(openFileDialog1.FileName);
        }

        private void lstProgramet_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnHape.Enabled = true;
            lblEmriProgramit.Text = "Emri i programit:\n" + Programet.SelectedItem.ToString();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.btnStart_hover;
        }
        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.btnStart;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
