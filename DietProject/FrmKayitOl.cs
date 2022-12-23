using DietProject.BLL.Services;
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
            try
            {
                User user = new User();
                user.Email = txtID.Text;
                //        user.Passwords = 
                user.FirstName = txtUserAd.Text;
                user.LastName = txtUserSoyad.Text;
                user.Weight = int.Parse(txtKilo.Text);
                user.Age = int.Parse(txtYas.Text);

                //  user.Passwords.Add(new Password()
                //  {
                                        // pw kısmını yarın hallederiz
                //  }

                bool check = userService.Insert(user);
                MessageBox.Show(check ? "Kullanıcı eklendi" : "Kullanıcı eklenmedi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }
    }
}
