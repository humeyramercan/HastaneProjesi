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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string DoktorTc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TCmasked.Text = DoktorTc;
            SqlCommand komut = new SqlCommand("Select * from Tablo_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", DoktorTc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adTextBox.Text = dr[1].ToString();
                soyadTextBox.Text = dr[2].ToString();
                bransComboBox.Text = dr[3].ToString();
                TCmasked.Text = dr[4].ToString();
                sifreTextBox.Text = dr[5].ToString();
            }

            bgl.baglanti().Close();

            SqlCommand komut3 = new SqlCommand("Select BransAd from Tablo_Branslar", bgl.baglanti());

            SqlDataReader dr1 = komut3.ExecuteReader();
            while (dr1.Read())
            {
                bransComboBox.Items.Add(dr1[0]);
            }
            bgl.baglanti().Close();

        }

        private void bilgileriGuncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Doktorlar Set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTextBox.Text);
            komut.Parameters.AddWithValue("@p2", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@p3", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p4", sifreTextBox.Text);
            komut.Parameters.AddWithValue("@p5", TCmasked.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
        }
    }
}
