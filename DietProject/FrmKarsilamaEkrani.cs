using DietProject.Model.Entities;
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
        User GelenUser;
        string gelenKullanici;
        public FrmKarsilamaEkrani(User user,string kullaniciAdi)
        {
            InitializeComponent();
            gelenKullanici= kullaniciAdi;
            GelenUser= user;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInterface arayuz = new FrmInterface(GelenUser);
            this.Hide();
            arayuz.ShowDialog();
        }

        private void FrmKarsilamaEkrani_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = gelenKullanici;
        }

       
    }
}
