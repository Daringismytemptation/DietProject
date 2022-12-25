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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietProject
{
    public partial class FrmKayitOl : Form
    {
        UserService userService;
        CaloriesDBContext db;
        public FrmKayitOl()
        {
            db = new CaloriesDBContext();
            userService= new UserService();
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            string eMail = txtID.Text;

           var a = userService.CheckEmailIfExists(eMail);
            if (a.Count>0)
            {

            }
            else
            {
                MessageBox.Show("Bu e-Mail daha önce kullanılmış");
                return;
            }

            if (txtPassword.Text != txtPasswordRepeat.Text)
            {
                MessageBox.Show("Şifreler birbirini tutmuyor");
                return;
            }
            try
            {
                User user = new User()
                {
                    FirstName = txtUserAd.Text,
                    LastName = txtUserSoyad.Text,
                    Email = txtID.Text,
                    Gender = rbMale.Checked ? EnumGender.Male : EnumGender.Female,
                    UserType = EnumUser.Standart,
                    Age=(int)nudYas.Value,
                    Weight= (int)nudKilo.Value,
                    Height= (int)nudHeight.Value,

                };
                user.Passwords.Add(new Password()
                {
                    UserPassword = txtPassword.Text
                });
                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenemedi");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           
        }
     
    }
}
