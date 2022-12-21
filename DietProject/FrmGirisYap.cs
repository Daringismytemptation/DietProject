using DietProject.BLL.Services;
using DietProject.Model.Entities;
using DietProject.Model.Enum;
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
    public partial class FrmGirisYap : Form
    {
        UserService userService;
        public FrmGirisYap()
        {
            InitializeComponent();
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
                        case EnumUser.Users:
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
