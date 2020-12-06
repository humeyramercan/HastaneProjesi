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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        public void DoktorListele()
        {
            SqlCommand komut3 = new SqlCommand("Select * from Tablo_Doktorlar", bgl.baglanti());
            SqlDataAdapter da2 = new SqlDataAdapter(komut3);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            bgl.baglanti().Close();
        }
        public void islemSonrasiYapilacaklar()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    tbox.Clear();
                }

            }

            bransComboBox.Text = "";
            tcMaskedTextBox.Text = "";
            DoktorListele();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DoktorListele();

            SqlCommand komut = new SqlCommand("Select BransAd from Tablo_Branslar",bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                bransComboBox.Items.Add(dr[0].ToString());
            }

            bgl.baglanti().Close();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tablo_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) values (@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTextBox.Text);
            komut.Parameters.AddWithValue("@p2", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@p3", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p4", tcMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p5", sifreTextBox.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Doktor başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }

            adTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            soyadTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bransComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            tcMaskedTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            sifreTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
           

        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where ,DoktorTc=@p4 ", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTextBox.Text);
            komut.Parameters.AddWithValue("@p2", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@p3", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p4", tcMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p5", sifreTextBox.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor bilgileri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();
            
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tablo_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tcMaskedTextBox.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();
        }
    }
}
