using System.Windows.Forms;

namespace PC_Visualize
{
    class PC_Visualize
    {
        private string[] Lista_e_Programeve =
        {
            "Calculator",
            "Google Chrome",
            "Microsoft Excel",
            "Microsoft PowerPoint",
            "Microsoft Word",
            "Microsoft Visual Studio",
            "Notepad++",
            "Windows Live Messenger"
        };
        private string Programi_Aktual;
        private bool Kompjuteri_i_Ndezur;

        public void Kontrollo_Statusin_e_Kompjuterit()
        {
            if (Kompjuteri_i_Ndezur == true)
                MessageBox.Show("Kompjuteri i ndezur");
            else MessageBox.Show("Kompjuteri jo i ndezur");
        }
        public PC_Visualize(bool statusi)
        { Kompjuteri_i_Ndezur = statusi; }

        public void Hap_Programin(string programi)
        {
            if (Kompjuteri_i_Ndezur == true)
                Programi_Aktual = programi;
            else MessageBox.Show("Kompjuteri nuk është i ndezur", "Informim",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void tregoVetite()
        {
            MessageBox.Show("Programi i hapur eshte:\n"
                + Programi_Aktual);
        }

        public void Programet(ListBox lista)
        {
            for (int i = 0; i < 8; i++)
                lista.Items.Add(Lista_e_Programeve[i]);
        }
    }
}
