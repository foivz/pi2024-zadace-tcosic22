using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadaca3.Models;

namespace Zadaca3.Repositories
{
    public class RepozitorijZaposlenik
    {
        public static Zaposlenik DohvatiZaposlenika(string KorisnickoIme)
        {
            Zaposlenik zaposlenik = null;

            string sql = $"SELECT * FROM Zaposlenik WHERE Korisnickoime = '{KorisnickoIme}'";
            DB.UspostaviVezu();
            var citac = DB.DohvatiCitac(sql);
            if (citac.HasRows)
            {
                citac.Read();
                zaposlenik = StvoriObjekt(citac);
                citac.Close();
            }

            DB.ZatvoriVezu();

            return zaposlenik;
        }

        private static Zaposlenik StvoriObjekt(SqlDataReader citac)
        {
            int idZaposlenik = int.Parse(citac["IDzaposlenika"].ToString());
            string korisnickoIme = citac["Korisnickoime"].ToString();
            string lozinka = citac["Lozinka"].ToString();
            string email = citac["Email"].ToString();

            var zaposlenik = new Zaposlenik
            {
                Id = idZaposlenik,
                KorisnickoIme = korisnickoIme,
                Lozinka = lozinka,
                Email = email
            };

            return zaposlenik;
        }
    }
}
