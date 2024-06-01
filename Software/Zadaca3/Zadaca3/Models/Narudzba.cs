using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3.Models
{
    public class Narudzba
    {
        public int IdStudenta { get; set; }
        public int OdabraniMeni { get; set; }
        public string VrijemePripreme { get; set; }
        public double Cijena { get; set; }
        public string Status { get; set; }
        public string Datum { get; set; }
        public string IskoristenKupon { get; set; }
        public int IdZaposlenik { get; set; }

    }
}
