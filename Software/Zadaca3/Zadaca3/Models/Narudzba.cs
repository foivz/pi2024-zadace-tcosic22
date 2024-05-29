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
        public string OdabraniMeni { get; set; }
        public int VrijemePripreme { get; set; }
        public double Cijena { get; set; }
        public string Status { get; set; }
        public bool IskoristenKupon { get; set; }
        public string Datum { get; set; }

    }
}
