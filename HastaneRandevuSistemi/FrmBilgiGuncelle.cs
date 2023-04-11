using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneRandevuSistemi
{
    public partial class FrmBilgiGuncelle : Form
    {
        public FrmBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string TC;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmBilgiGuncelle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TC;
            SqlCommand komut = new SqlCommand("select * from Tbl_Hasta where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTelefon.Text = dr[4].ToString();
                Txtsifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hasta set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4", Txtsifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi","Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
