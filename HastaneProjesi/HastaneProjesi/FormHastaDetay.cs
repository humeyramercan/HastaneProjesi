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

namespace HastaneProjesi
{
    public partial class FormHastaDetay : Form
    {
        public FormHastaDetay()
        {
            InitializeComponent();
        }
        private string randevuID;
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void kutuTemizle()
        {
            bransComboBox.Text = "";
            doktorComboBox.Text = "";
            saatMaskedTextBox.Text = "";
            tarihMaskedTextBox.Text = "";
            sikayetRichTextBox.Text = "";
        
        }
        public void RandevuGecmisi()
        {
            SqlCommand komut2 = new SqlCommand("Select * from Tablo_Randevular where HastaTc =@p1 and RandevuDurum=1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", tcLabel.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            randevuGecmisiDataGrid.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FormHastaDetay_Load(object sender, EventArgs e)
        {
            //Ad soyad çekme
            tcLabel.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAdi,HastaSoyad from Tablo_Hastalar where HastaTc=@p1", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", tcLabel.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adSoyadLabel.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişi çekme

            RandevuGecmisi();

            //Branşların çekilmesi

            SqlCommand komut3 = new SqlCommand("Select BransAd from Tablo_Branslar", bgl.baglanti());

            SqlDataReader dr1 = komut3.ExecuteReader();
            while (dr1.Read())
            {
                bransComboBox.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();

        }

        private void bransComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorComboBox.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransComboBox.Text);

            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                doktorComboBox.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void doktorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesajLabel.Visible = true;
            SqlCommand komut = new SqlCommand("Select * from Tablo_Randevular where RandevuBrans=@p1 and RandevuDoktor=@p2 and RandevuDurum=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p2", doktorComboBox.Text);
            komut.Parameters.AddWithValue("@p3", false);

            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            alinabilecekRandevularDataGrid.DataSource = dt;
            //saatTarihGetir();
            bgl.baglanti().Close();
        }

        private void bilgiDüzenleLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaBilgiDuzenle frm = new FrmHastaBilgiDuzenle();
            frm.TCno = tcLabel.Text;
            frm.Show();
        }

        private void randevuAlButton_Click(object sender, EventArgs e)
        {
            mesajLabel.Visible = false;
            SqlCommand komut = new SqlCommand("Update Tablo_Randevular set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where RandevuID=@p3 and RandevuDurum=0", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcLabel.Text);
            komut.Parameters.AddWithValue("@p2", sikayetRichTextBox.Text);
            komut.Parameters.AddWithValue("@p3", randevuID);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Randevunuz başarıyla alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kutuTemizle();
            RandevuGecmisi();
            alinabilecekRandevularDataGrid.DataSource = null;


        }

        private void alinabilecekRandevularDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            randevuID = alinabilecekRandevularDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            tarihMaskedTextBox.Text = alinabilecekRandevularDataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            saatMaskedTextBox.Text = alinabilecekRandevularDataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();

        }
    }
}
