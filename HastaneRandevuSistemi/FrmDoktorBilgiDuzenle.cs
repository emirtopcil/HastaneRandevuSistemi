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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TC;
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskTc.Text = TC;
            SqlCommand komut = new SqlCommand("Select * from Tbl_Doktor where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            bgl.baglanti().Close();

        }
    }
}
