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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        private void duyurularButton_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        public string Tc;
       
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            TCLabel.Text = Tc;
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad from Tablo_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", Tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adSoyadLabel.Text=dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select * from Tablo_Randevular where RandevuDoktor=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", adSoyadLabel.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            bgl.baglanti().Close();

            
        }

        private void bilgiDuzenleButton_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.DoktorTc = TCLabel.Text;
            frm.Show();
            
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) { return; }
            sikayetRichTextBox.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
