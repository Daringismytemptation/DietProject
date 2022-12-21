using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    public partial class CeliacFit : Form
    {
        public CeliacFit()
        {
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl kayitOl = new FrmKayitOl();
            this.Hide();
            kayitOl.ShowDialog();
            this.Show();
            
        }

        private void btnHakkinda_Click(object sender, EventArgs e)
        {
            FrmHakkinda form = new FrmHakkinda();
            this.Hide();
            form.ShowDialog();
            this.Show();
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            FrmGirisYap girisYap = new FrmGirisYap();
            this.Hide();
            girisYap.ShowDialog();
            this.Show();
        }
    }
}
