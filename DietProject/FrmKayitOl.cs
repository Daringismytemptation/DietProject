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
    public partial class FrmKayitOl : Form
    {
        UserService userService;
        public FrmKayitOl()
        {
            userService= new UserService();
            InitializeComponent();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
           
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
