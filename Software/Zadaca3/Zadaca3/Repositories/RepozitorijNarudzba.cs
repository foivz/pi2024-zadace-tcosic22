using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Zadaca3.Models;

namespace Zadaca3.Repositories
{
    public class RepozitorijNarudzba
    {
        public static Narudzba DohvatiNarudzbu(int idStudent, int idMeni)
        {
            Narudzba narudzba = null;

            string sql = $"SELECT * FROM Narudzba WHERE IDstudenta = {idStudent} AND IDmenija = {idMeni}";
            DB.UspostaviVezu();
            var citac = DB.DohvatiCitac(sql);
            if (citac.HasRows)
            {
                citac.Read();
                narudzba = StvoriObjekt(citac);
                citac.Close();
            }

            DB.ZatvoriVezu();

            return narudzba;
        }

        public static List<Narudzba> DohvatiNarudzbe()
        {
            List<Narudzba> narudzbe = new List<Narudzba>();

            string sql = "SELECT * FROM Narudzba";
            DB.UspostaviVezu();
            var citac = DB.DohvatiCitac(sql);

            while(citac.Read())
            {
                Narudzba narudzba = StvoriObjekt(citac);
                narudzbe.Add(narudzba);
            }

            citac.Close();
            DB.ZatvoriVezu();

            return narudzbe;

        }

        private static Narudzba StvoriObjekt(SqlDataReader citac)
        {
            int idStudent = int.Parse(citac["IdStudenta"].ToString());
            int idMeni = int.Parse(citac["OdabraniMeni"].ToString());
            string vrijeme = citac["VrijemePripreme"].ToString();
            double cijena = double.Parse(citac["Cijena"].ToString());
            string status = citac["Status"].ToString();
            string kupon = citac["IskoristenKupon"].ToString();
            string datum = citac["Datum"].ToString();
            int idZaposlen = int.Parse(citac["IdZaposlenika"].ToString());

            var narudzba = new Narudzba
            {
                IdStudenta = idStudent,
                OdabraniMeni = idMeni,
                VrijemePripreme = vrijeme,
                Cijena = cijena,
                Status = status,
                IskoristenKupon = kupon,
                Datum = datum,
                IdZaposlenik = idZaposlen
            };

            return narudzba;
        }
    }
}
