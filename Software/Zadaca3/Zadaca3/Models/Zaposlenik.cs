using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3.Models
{
    public class Zaposlenik : Osoba
    {
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }

        public string Email { get; set; }
    }
}
