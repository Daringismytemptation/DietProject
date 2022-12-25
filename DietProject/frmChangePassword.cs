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
    public partial class frmChangePassword : Form
    {
        User user;
        PasswordService passwordService;
        public frmChangePassword(User _gelenUser)
        {
            InitializeComponent();
            user = _gelenUser;
            passwordService = new PasswordService();

        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                Password activePassword = passwordService.GetActivePassword(user.ID);
                if (txtEskiSifre.Text != activePassword.UserPassword)
                {
                    MessageBox.Show("Mevcut şifrenizi hatalı girdiniz");
                    return;
                }

                if (txtyeniSifre.Text != txtYeniSifreTekrar.Text)
                {
                    MessageBox.Show("Şifre tekrarı hatalı");
                    return;
                }

                bool check = passwordService.Insert(new Password()
                {
                    UserPassword = txtyeniSifre.Text,
                    UserID = user.ID
                });
                MessageBox.Show(check ? "Şifre değiştirildi" : "Şifre değiştirileMEdi");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
