using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;
using Domen;

namespace Pokusaj2
{
    public partial class FrmSifrovanje : Form
    {
        private const int MaxSifraDuzina = 12; 
        private string putanjaDoDokumenta = string.Empty; // Čuva putanju do izabranog dokumenta
        private Korisnik k;

        public FrmSifrovanje()
        {
           
        }

        public FrmSifrovanje(Korisnik k)
        {
            InitializeComponent();
            this.k = k;
            this.Text = "Dobro dosli: " + k.Email;
        }

        //Otvaranje prozora za izbor textualnog dokumenta
        private void UnosDokumentaTextBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                putanjaDoDokumenta = openFileDialog.FileName;
                UnosDokumentaTextBox.Text = putanjaDoDokumenta;
            }
        }

        private void SifrujButton_Click(object sender, EventArgs e)
        {
            string sifra = SifraTextBox.Text;

            if (sifra.Length > MaxSifraDuzina)
            {
                MessageBox.Show("Šifra ne sme biti duža od 12 karaktera.");
                return;
            }

            if (!File.Exists(putanjaDoDokumenta))
            {
                MessageBox.Show("Dokument na datoj putanji ne postoji.");
                return;
            }

            string tekst = File.ReadAllText(putanjaDoDokumenta);
            string sifrovaniTekst = SifrujAES(tekst, sifra);
            File.WriteAllText(putanjaDoDokumenta, sifrovaniTekst); // Šifrovan tekst se upisuje preko originalnog teksta
            RezultatTextBox.Text = "Tekst u dokumentu je uspešno šifrovan.";
            

            // Slanje šifrovanog teksta putem e-maila
            PosaljiEmail("djordje5rovic@gmail.com", "Uspesno sifrovanje!", sifra);
            SifraTextBox.Clear();
        }

        private void PosaljiEmail(string primalac, string naslovMejla, string sifra)
        {
            
            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress(k.Email);
            mailMessage.To.Add(primalac); 
            mailMessage.Subject = naslovMejla;
            mailMessage.Body = "Šifra za dešifrovanje dokumenta je: " + sifra;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.office365.com";
            smtpClient.Port = 587;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(k.Email, k.Password);
            smtpClient.EnableSsl = true;

            try
            {
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email Sent Successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void DesifrujButton_Click(object sender, EventArgs e)
        {
            string sifra = DesifraTextBox.Text;

            if (sifra.Length > MaxSifraDuzina)
            {
                MessageBox.Show("Šifra ne sme biti duža od 12 karaktera.");
                return;
            }

            if (!File.Exists(putanjaDoDokumenta))
            {
                MessageBox.Show("Dokument na datoj putanji ne postoji.");
                return;
            }

            string sifrovaniTekst = File.ReadAllText(putanjaDoDokumenta);
            string deSifrovaniTekst = DesifrujAES(sifrovaniTekst, sifra);
            File.WriteAllText(putanjaDoDokumenta, deSifrovaniTekst); // Dešifrovan tekst se upisuje preko šifrovanog teksta
            RezultatTextBox.Text = "Tekst u dokumentu je uspešno dešifrovan.";
        }

        private string SifrujAES(string tekst, string sifra)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(sifra.PadRight(32).Substring(0, 32)); // Koristi prvih 32 karaktera šifre
                aesAlg.IV = new byte[16]; // Inicijalizacioni vektor

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
                aesAlg.Key = Encoding.UTF8.GetBytes(sifra.PadRight(32).Substring(0, 32)); // Koristi prvih 32 karaktera šifre
                aesAlg.IV = new byte[16]; // Inicijalizacioni vektor

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
