using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Dashboard obj1 = new Dashboard();
             obj1.ShowDialog();
            this.Close();

            //if (textBox1.Text == "admin" || textBox2.Text == "pass")

        }
        public string EncrytPassword(string inputPwdString)
        {
            var encryptPwdString = "";
            string EncryptionKey = ConfigurationManager.AppSettings["EncrytKey"].ToString();
            byte[] bytesArray = Encoding.Unicode.GetBytes(inputPwdString);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes rfcderivedBytes = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                    0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = rfcderivedBytes.GetBytes(32);
                encryptor.IV = rfcderivedBytes.GetBytes(16);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(memoryStream, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesArray, 0, bytesArray.Length);
                        cs.Close();
                    }
                    encryptPwdString = Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            return encryptPwdString;
        }

        public string Decrypt(string encryptPwdString)
        {
            string EncryptKey = ConfigurationManager.AppSettings["EncrytKey"].ToString();
            var cipherText = encryptPwdString.Replace(" ", "+");
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes rfcderivedBytes = new Rfc2898DeriveBytes(EncryptKey, new byte[] {
                  0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = rfcderivedBytes.GetBytes(32);
                encryptor.IV = rfcderivedBytes.GetBytes(16);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);
                        cryptoStream.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(memoryStream.ToArray());
                }
            }
            return cipherText;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
