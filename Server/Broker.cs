using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Domen;

namespace Server
{
    public class Broker
    {

        SqlConnection konekcija;
        SqlCommand komanda;
        SqlTransaction transakcija;

        void konektujSe()
        {
            konekcija = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ZastitaRacSistema;Integrated Security=True;");
            komanda = konekcija.CreateCommand();
        }

        Broker()
        {
            konektujSe();
        }
        static Broker instanca;

        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }

        public Korisnik login(Korisnik k)
        {
            try
            {
                konekcija.Open();
                komanda.CommandText = "Select * from TabelaKorisnici where [Email] ='" + k.Email + "' and Password = '" + k.Password + "'";
                SqlDataReader reader = komanda.ExecuteReader();

                if (reader.Read())
                {
                    k.Id = reader.GetInt32(0);
                    k.Email = reader.GetString(1);
                    k.Password = reader.GetString(2);
                    return k;
                }
                reader.Close();
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (konekcija != null) konekcija.Close();
            }
        }
    }
}
