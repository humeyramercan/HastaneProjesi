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
    public partial class FormHastaUyeOl : Form
    {
        public FormHastaUyeOl()
        {
            InitializeComponent();
        }

        SqlBaglantisi baglanti = new SqlBaglantisi();
        
  
        private void uyeOlButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tablo_Hastalar (HastaAdi,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) Values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti.baglanti());

            komut.Parameters.AddWithValue("@p1", adTextBox.Text);
            komut.Parameters.AddWithValue("@p2", soyadTextBox.Text);
            komut.Parameters.AddWithValue("@p3", TCmasked.Text);
            komut.Parameters.AddWithValue("@p4", telefonMasked.Text);
            komut.Parameters.AddWithValue("@p5", sifreTextBox.Text);
            komut.Parameters.AddWithValue("@p6", cinsiyetComboBox.Text);
            komut.ExecuteNonQuery();

            baglanti.baglanti().Close();
            MessageBox.Show("Kaydınız başarıyla gerçekleştirilmiştir.", "Kayıt Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

        }
    }
}
