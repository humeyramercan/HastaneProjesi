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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        
        private void girisButton_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * from Tablo_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TCmasked.Text);
            komut.Parameters.AddWithValue("@p2", sifreTextBox.Text);
            SqlDataReader dr = komut.ExecuteReader();
           
            if (dr.Read())
            {
               
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.Tc = TCmasked.Text;
                frm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc veya şifre!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
