using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace SifrovanjeForma
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SifrujButton_Click(object sender, EventArgs e)
        {
            string tekst = UnosTeksta.Text;
            string sifra = Sifra.Text;

            string sifrovaniTekst = SifrujAES(tekst, sifra);
            Rezultat.Text = sifrovaniTekst;
        }

        private void DesifrujButton_Click(object sender, EventArgs e)
        {
            string sifrovaniTekst = Rezultat.Text;
            string sifra = Desifra.Text;

            string deSifrovaniTekst = DesifrujAES(sifrovaniTekst, sifra);
            Rezultat.Text = deSifrovaniTekst;
        }

        private string SifrujAES(string tekst, string sifra)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] kljucBytes = PBKDF2DeriveKey(sifra, aesAlg.KeySize / 8);
                aesAlg.Key = kljucBytes;
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456");

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(tekst);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        private string DesifrujAES(string sifrovaniTekst, string sifra)
        {
            using (Aes aesAlg = Aes.Create())
            {
                byte[] kljucBytes = PBKDF2DeriveKey(sifra, aesAlg.KeySize / 8);
                aesAlg.Key = kljucBytes;
                aesAlg.IV = Encoding.UTF8.GetBytes("1234567890123456");

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(sifrovaniTekst)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private byte[] PBKDF2DeriveKey(string password, int keyLength)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, Encoding.UTF8.GetBytes("salt"), 10000))
            {
                return pbkdf2.GetBytes(keyLength);
            }
        }
    }
}
