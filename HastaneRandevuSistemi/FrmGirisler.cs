using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuSistemi
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiris hst = new FrmHastaGiris();
            hst.Show();
            this.Hide();
        }

        private void BtnSekreterGiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris skr = new FrmSekreterGiris();
            skr.Show();
            this.Hide();
        }

        private void BtnDoktorGiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris dkr = new FrmDoktorGiris();
            dkr.Show();
            this.Hide();
        }
    }
}
