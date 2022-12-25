using DietProject.BLL.Services;
using DietProject.DAL;
using DietProject.Model.Entities;
using DietProject.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
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
            if (txtKullaniciAdi.Text == "admin.admin@gmail.com")
            {
                sifre = txtSifre.Text;
            }
            else
            {
                sifre = Encode(txtSifre.Text);
            }

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
                            FrmKarsilamaEkrani frmKarsilama = new FrmKarsilamaEkrani(user,kullaniciAdi);
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
        public string Encode(string password)
        {
            try
            {
                string ourText = password;
                string Return = null;
                string _key = "abcdefgh";
                string privatekey = "hgfedcba";
                byte[] privatekeyByte = { };
                privatekeyByte = Encoding.UTF8.GetBytes(privatekey);
                byte[] _keybyte = { };
                _keybyte = Encoding.UTF8.GetBytes(_key);
                byte[] inputtextbyteArray = System.Text.Encoding.UTF8.GetBytes(ourText);
                using (DESCryptoServiceProvider dsp = new DESCryptoServiceProvider())
                {
                    var memstr = new MemoryStream();
                    var crystr = new CryptoStream(memstr, dsp.CreateEncryptor(_keybyte, privatekeyByte), CryptoStreamMode.Write);
                    crystr.Write(inputtextbyteArray, 0, inputtextbyteArray.Length);
                    crystr.FlushFinalBlock();
                    return Convert.ToBase64String(memstr.ToArray());
                }
                return Return;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
