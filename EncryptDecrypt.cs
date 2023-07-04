using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptDecryptProgram
{
    public partial class EncryptDecrypt : Form
    {
        public EncryptDecrypt()
        {
            InitializeComponent();
            this.Text = "Encrypt Decrypt Program";
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Get the input string and key
            string input = txtBoxMainText.Text;
            string key = txtBoxKey.Text;

            // Encrypt the input string
            string encrypted = Encrypt(input, key);

            // Display the encrypted string in the output text box
            txtBoxEncrypt.Text = encrypted;
        }

        private static string Encrypt(string input, string key)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] keyBytes = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyBytes, Math.Min(32, key.Length));
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = keyBytes;
                aes.GenerateIV();
                using (ICryptoTransform encryptor = aes.CreateEncryptor())
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.Write(aes.IV, 0, aes.IV.Length);
                        using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        {
                            cs.Write(inputBytes, 0, inputBytes.Length);
                            cs.FlushFinalBlock();
                            byte[] encryptedBytes = ms.ToArray();
                            return Convert.ToBase64String(encryptedBytes);
                        }
                    }
                }
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Get the input string and key
            string input = txtBoxEncrypt.Text;
            string key = txtBoxKey.Text;

            // Decrypt the input string
            string decrypted = Decrypt(input, key);

            // Display the decrypted string in the output text box
            txtBoxDecrypt.Text = decrypted;
        }

        private static string Decrypt(string input, string key)
        {
            byte[] inputBytes = Convert.FromBase64String(input);
            byte[] keyBytes = new byte[32];
            Array.Copy(Encoding.UTF8.GetBytes(key), keyBytes, Math.Min(32, key.Length));
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = 256;
                aes.Key = keyBytes;
                using (MemoryStream ms = new MemoryStream(inputBytes))
                {
                    byte[] iv = new byte[aes.IV.Length];
                    ms.Read(iv, 0, iv.Length);
                    aes.IV = iv;
                    using (ICryptoTransform decryptor = aes.CreateDecryptor())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            byte[] decryptedBytes = new byte[inputBytes.Length];
                            int byteCount = cs.Read(decryptedBytes, 0, decryptedBytes.Length);
                            return Encoding.UTF8.GetString(decryptedBytes, 0, byteCount);
                        }
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxDecrypt.Clear();
            txtBoxEncrypt.Clear();
            txtBoxKey.Clear();
            txtBoxMainText.Clear();
        }
    }
}
