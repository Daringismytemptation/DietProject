using DietProject.BLL.Services;
using DietProject.DAL;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    public partial class FrmInterface : Form
    {
        UserService userService;
        CaloriesDBContext db;
        User gelenUser;
        public FrmInterface()
        {
            InitializeComponent();
        }
        public FrmInterface(User gelenUser)
        {
            userService = new UserService();
            db = new CaloriesDBContext();
            InitializeComponent();
            this.gelenUser = gelenUser;
        }

 
        private void btnGoruntule_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.RelevantDate = dtpTarih.Value;
           var a = db.Users.Where(x => x.ID == gelenUser.ID).FirstOrDefault();
            a.Dates.Add(date);
            db.SaveChanges();
            MessageBox.Show("işlem gerçekleştirildi");
            // İlk önce gidecek databaseden ege kullanıcısı ile ilgili tarihin(relevant) kesişim noktası olan kümeyi dataSource kısmına aktarıcak. devamında 

            var b = db.Users.Where(x => x.ID == gelenUser.ID).ToList();
            var c = b.Where(x => x.Dates.Equals(date.RelevantDate)).ToList();
            dgvKullanici.DataSource = c;
           
            

           // user = userService.CheckLogin(kullaniciAdi, sifre);



        }
    }
}
