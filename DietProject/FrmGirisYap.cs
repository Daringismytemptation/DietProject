using DietProject.BLL.Services;
using DietProject.DAL;
using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    public partial class FrmGirisYap : Form
    {
        UserService userService;
        public FrmGirisYap()
        {
            InitializeComponent();
            //silinecek 
            CaloriesDBContext context = new CaloriesDBContext();
            User user = new User
            {
                FirstName = "ege",
                LastName = "sumer",
                CreationDate = DateTime.Now,
                IsActive = true,
                Email = "admin",
                UserType = EnumUser.Admin
            };

            user.Passwords.Add(new Password()
            {
                CreationDate = DateTime.Now,
                UserPassword = "qwerty"
            });

            context.Users.Add(user);
            context.SaveChanges();
            //
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            try
            {
                userService = new UserService();
                User user = userService.CheckLogin(kullaniciAdi, sifre);
                if (user != null)
                {
                    if (!user.IsActive)
                    {
                        MessageBox.Show("Kullanıcı henüz Admin tarafından onaylanmamış");
                        return;
                    }
                    switch (user.UserType)
                    {
                        case EnumUser.Admin:
                            FrmAdmin adminForm = new FrmAdmin();
                            this.Hide();
                            adminForm.ShowDialog();
                            this.Show();
                            break;
                        case EnumUser.Standart:
                            FrmKarsilamaEkrani frmKarsilama = new FrmKarsilamaEkrani();
                            this.Hide();
                            frmKarsilama.ShowDialog();
                            this.Show();
                            break;

                    }

                }
                else
                {
                    MessageBox.Show("Lütfen bilgilerinizi doğru giriniz");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
