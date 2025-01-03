using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerTrackingAdoNet
{
    public partial class FrmMap : Form
    {
        public FrmMap()
        {
            InitializeComponent();
        }


        private void btnSehirİslemleri_Click(object sender, EventArgs e)
        {
            Form1 frmSehir = new Form1();
            frmSehir.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult çıkış = new DialogResult();
            çıkış = MessageBox.Show("Çıkış yapıyorsunuz emin misiniz?", "Çıkış Yapmak istediginize emin misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (çıkış == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
