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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {  
            
            InitializeComponent();
        }

        public string SekreterTc;
        
        
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void kutulariTemizle()
        {
            tarihMaskedTextBox.Text = "";
            bransComboBox.Text = "";
            saatMaskedTextBox.Text = "";
            doktorComboBox.Text = "";
            
        }
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            tcLabel.Text = SekreterTc;
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad from Tablo_Sekreter where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", SekreterTc);
       
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adSoyadLabel.Text=dr[0].ToString();
                
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select BransAd from Tablo_Branslar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            bransDataGrid.DataSource = dt;

            bgl.baglanti().Close();


            SqlCommand komut3 = new SqlCommand("Select DoktorAd+' '+DoktorSoyad as 'Doktor Ad Soyad',DoktorBrans,DoktorTc from Tablo_Doktorlar", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            doktorDataGrid.DataSource = dt2;

            bgl.baglanti().Close();

            SqlCommand komut4 = new SqlCommand("Select BransAd from Tablo_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut4.ExecuteReader();
            while (dr2.Read())
            {
                bransComboBox.Items.Add(dr2[0].ToString());
            }
            bgl.baglanti().Close();

    
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tablo_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tarihMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p2", saatMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p3", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p4", doktorComboBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu başarıyla kaydedilmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kutulariTemizle();
        }

        private void bransComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktorComboBox.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransComboBox.Text);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                doktorComboBox.Items.Add(dr[0]+" "+dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void duyuruOlusturButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tablo_Duyurular (Duyuru) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", duyuruRichTextBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            duyuruRichTextBox.Text = "";
        }

        private void doktorPaneliButton_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void bransButton_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frm = new FrmBransPaneli();
            frm.Show();
        }

        private void randevuListeButton_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

 

        public void dataGriddenTextBoxlara(string tarih,string saat,string brans,string doktor)
        {
            tarihMaskedTextBox.Text = tarih;
            saatMaskedTextBox.Text = saat;
            bransComboBox.Text = brans;
            doktorComboBox.Text = doktor;
            
        }

        
    }
}
