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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }

        private string BransID;
        SqlBaglantisi bgl = new SqlBaglantisi();
        public void Listele()
        {
            SqlCommand komut = new SqlCommand("Select * from Tablo_Branslar", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }
        public void islemSonrasiYapilacaklar()
        {
            
            bransAdTextBox.Text = "";
            Listele();
        }

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            BransID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bransAdTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void ekleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert Into Tablo_Branslar (BransAd) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransAdTextBox.Text);
            bgl.baglanti().Close();
            MessageBox.Show("Branş başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from Tablo_Branslar where BransId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", BransID);
            komut.ExecuteNonQuery();
            MessageBox.Show("Branş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tablo_Branslar set BransAd=@p1 where BransId=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", bransAdTextBox.Text);
            komut.Parameters.AddWithValue("@p2", BransID);
            komut.ExecuteNonQuery();
            MessageBox.Show("Branş başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            islemSonrasiYapilacaklar();
        }
    }
}
