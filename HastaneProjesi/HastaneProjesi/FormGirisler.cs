using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FormGirisler : Form
    {
        

        public FormGirisler()
        {
            InitializeComponent();
        }

        private void hastaGirisiButton_Click(object sender, EventArgs e)
        {
            FormHastaGiris frm = new FormHastaGiris();
            frm.Show();
            this.Hide();
        }

        private void doktorGirisiButton_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frm = new FrmDoktorGiris();
            frm.Show();
            this.Hide();
        }

        private void sekreterGirisiButton_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frm = new FrmSekreterGiris();
            frm.Show();
            Hide();
        }
    }
}
