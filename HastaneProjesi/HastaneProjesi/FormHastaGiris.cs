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
    public partial class FormHastaGiris : Form
    {
        public FormHastaGiris()
        {
            InitializeComponent();
        }

        private void uyeOlLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormHastaUyeOl fr = new FormHastaUyeOl();
            fr.Show();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        private void girisButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Tablo_Hastalar where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCmasked.Text);
            komut.Parameters.AddWithValue("@p2", sifreTextBox.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if(dr.Read())
            {
                FormHastaDetay fr = new FormHastaDetay();
                fr.tc = TCmasked.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();
            
        }

        private void FormHastaGiris_Load(object sender, EventArgs e)
        {

        }

        private void geriButton_Click(object sender, EventArgs e)
        {

            FormGirisler fr = new FormGirisler();
            fr.Show();
            Hide();
        }
    }
}
