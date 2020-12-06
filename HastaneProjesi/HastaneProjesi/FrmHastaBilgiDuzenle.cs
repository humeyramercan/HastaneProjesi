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
    public partial class FrmHastaBilgiDuzenle : Form
    {
        public FrmHastaBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void FrmHastaBilgiDuzenle_Load(object sender, EventArgs e)
        {
            TCmasked.Text = TCno;
            SqlCommand komut = new SqlCommand("Select * from Tablo_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCno);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adTextBox.Text = dr[1].ToString();
                soyadTextBox.Text = dr[2].ToString();
                telefonMasked.Text = dr[4].ToString();
                sifreTextBox.Text = dr[5].ToString();
                cinsiyetComboBox.Text = dr[6].ToString();
            }

            bgl.baglanti().Close();

        }

        private void bilgileriGuncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Hastalar Set HastaAdi=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", adTextBox.Text);
            komut.Parameters.AddWithValue("@p2", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@p3", telefonMasked.Text);
            komut.Parameters.AddWithValue("@p4", sifreTextBox.Text);
            komut.Parameters.AddWithValue("@p5", cinsiyetComboBox.Text);
            komut.Parameters.AddWithValue("@p6", TCmasked.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
