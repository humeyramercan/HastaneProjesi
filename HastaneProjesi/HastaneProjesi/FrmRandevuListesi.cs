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
   
    public partial class FrmRandevuListesi : Form
    {
        private string RandevuID;
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void kutulariTemizle()
        {
            tarihMaskedTextBox.Text = "";
            bransComboBox.Text = "";
            saatMaskedTextBox.Text = "";
            doktorComboBox.Text = "";
                        
        }
        public void RandevuListele()
        {
            SqlCommand komut = new SqlCommand("Select RandevuID,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor from Tablo_Randevular where RandevuDurum=0", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();
        }
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            RandevuListele();
        }

        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }


            RandevuID= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tarihMaskedTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            saatMaskedTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            bransComboBox.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            doktorComboBox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
         

     
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Randevular Set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4 where RandevuID=@p6", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tarihMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p2", saatMaskedTextBox.Text);
            komut.Parameters.AddWithValue("@p3", bransComboBox.Text);
            komut.Parameters.AddWithValue("@p4", doktorComboBox.Text);
            komut.Parameters.AddWithValue("@p6", RandevuID);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu başarıyla güncellenmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RandevuListele();
            kutulariTemizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tablo_Randevular where RandevuID=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", RandevuID);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu başarıyla silinmiştir!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RandevuListele();
            kutulariTemizle();
        }
    }
}
