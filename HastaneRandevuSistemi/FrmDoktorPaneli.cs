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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sqlbaglantisi bgl = new Sqlbaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktor",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut = new SqlCommand("Select BransAd from Tbl_Brans",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                CmbBrans.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            //AD SOYAD TC BRANŞ ŞİFRE
            SqlCommand ekle = new SqlCommand("insert into Tbl_Doktor (DoktorAd,DoktorSoyad,DoktorTc,DoktorBrans,DoktorSifre) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@p1", TxtAd.Text);
            ekle.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            ekle.Parameters.AddWithValue("@p3", MskTc.Text);
            ekle.Parameters.AddWithValue("@p4", CmbBrans.Text);
            ekle.Parameters.AddWithValue("@p5", TxtSifre.Text);
            ekle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            MskTc.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            CmbBrans.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from Tbl_Doktor where DoktorTc=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1", MskTc.Text);
            sil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand gncl = new SqlCommand("Update Tbl_Doktor set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5", bgl.baglanti());
            gncl.Parameters.AddWithValue("@p1", TxtAd.Text);
            gncl.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            gncl.Parameters.AddWithValue("@p3", CmbBrans.Text);
            gncl.Parameters.AddWithValue("@p4", TxtSifre.Text);
            gncl.Parameters.AddWithValue("@p5", MskTc.Text);
            gncl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Kayıt güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
