using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using Zadaca3.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            int idStudent = int.Parse(citac["IDstudenta"].ToString());
            int idMeni = int.Parse(citac["IDmenija"].ToString());
            string vrijeme = citac["VrijemePripreme"].ToString();
            double cijena = double.Parse(citac["Cijena"].ToString());
            string status = citac["Status"].ToString();
            string datum = citac["Datum"].ToString();
            string kupon = citac["IskoristenKupon"].ToString();
            int idZaposlen = int.Parse(citac["IDzaposlenika"].ToString());

            var narudzba = new Narudzba
            {
                IdStudenta = idStudent,
                OdabraniMeni = idMeni,
                VrijemePripreme = vrijeme,
                Cijena = cijena,
                Status = status,
                Datum = datum,
                IskoristenKupon = kupon,
                IdZaposlenik = idZaposlen
            };

            return narudzba;
        }

        public static void DodajNarudzbu(Narudzba narudzba)
        {
           string sql = "INSERT INTO Narudzba VALUES (@IDstudenta, @IDmenija, @Vrijemepripreme, @Cijena, @Status, @Datum, @Iskoristenkupon, @IDzaposlenika)";
           
            DB.UspostaviVezu();

            using (SqlCommand command = new SqlCommand(sql, DB.VratiVezu()))
            {
                command.Parameters.AddWithValue("@IDstudenta", narudzba.IdStudenta);
                command.Parameters.AddWithValue("@IDmenija", narudzba.OdabraniMeni);
                command.Parameters.AddWithValue("@Vrijemepripreme", narudzba.VrijemePripreme);
                command.Parameters.AddWithValue("@Cijena", narudzba.Cijena);
                command.Parameters.AddWithValue("@Status", narudzba.Status);
                command.Parameters.AddWithValue("@Iskoristenkupon", narudzba.IskoristenKupon);
                command.Parameters.AddWithValue("@Datum", narudzba.Datum);
                command.Parameters.AddWithValue("@IDzaposlenika", narudzba.IdZaposlenik);

                command.ExecuteNonQuery();
            }
            DB.ZatvoriVezu();
        }

        public static void PromijeniStatus(int idStudent, int idMeni, string vrijeme, string status)
        {
            string sql = "UPDATE Narudzba" +
                " SET Vrijemepripreme = @Vrijemepripreme, Status = @Status WHERE IDstudenta = @IDstudenta AND IDmenija = @IDmenija";

            DB.UspostaviVezu();

            using (SqlCommand command = new SqlCommand(sql, DB.VratiVezu()))
            {
                command.Parameters.AddWithValue("@IDstudenta", idStudent);
                command.Parameters.AddWithValue("@IDmenija", idMeni);
                command.Parameters.AddWithValue("@Vrijemepripreme", vrijeme);
                command.Parameters.AddWithValue("@Status", status);

                command.ExecuteNonQuery();
            }
            DB.ZatvoriVezu();
        }
    }
}
