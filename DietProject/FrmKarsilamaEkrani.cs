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
    public partial class FrmKarsilamaEkrani : Form
    {
        public FrmKarsilamaEkrani()
        {
            InitializeComponent();
        }
        string gelenKullanici;
        public FrmKarsilamaEkrani(string kullaniciAdi)
        {
            InitializeComponent();
            gelenKullanici= kullaniciAdi;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInterface arayuz = new FrmInterface();
            this.Hide();
            arayuz.ShowDialog();
        }

        private void FrmKarsilamaEkrani_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = gelenKullanici;
        }
    }
}
