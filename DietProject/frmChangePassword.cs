using DietProject.BLL.Services;
using DietProject.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                if (Encode(txtEskiSifre.Text) != activePassword.UserPassword)
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
                    UserPassword = Encode(txtyeniSifre.Text),
                    UserID = user.ID
                });
                MessageBox.Show(check ? "Şifre değiştirildi" : "Şifre değiştirileMEdi");
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
