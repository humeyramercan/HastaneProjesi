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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void girisButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tablo_Sekreter where SekreterTc=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCmasked.Text);
            komut.Parameters.AddWithValue("@p2", sifreTextBox.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmSekreterDetay frm = new FrmSekreterDetay();
                frm.SekreterTc = TCmasked.Text;
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya şifre", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();
        }
        private void geriButton_Click(object sender, EventArgs e)
        {

            FormGirisler fr = new FormGirisler();
            fr.Show();
            Hide();
        }
    }
}
