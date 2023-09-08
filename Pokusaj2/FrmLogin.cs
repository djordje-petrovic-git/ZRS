using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
namespace Pokusaj2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Korisnik k = new Korisnik();
            k.Email = txtEmail.Text;
            k.Password = txtPassword.Text;
            try
            {
                k = Broker.dajSesiju().login(k);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (k == null)
            {
                MessageBox.Show("Korisnik ne postoji u bazi");
                return;
            }
            else
            {
                this.Hide();
                new FrmSifrovanje(k).ShowDialog();
                this.Show();
            }

        }
    }
}
