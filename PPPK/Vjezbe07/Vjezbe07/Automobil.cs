using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe07
{
    class Automobil
    {
        public int IDAutomobil { get; set; }
        public string Proizvodjac { get; set; }
        public string Tip { get; set; }
        public short GodinaProizvodnje { get; set; }
        public short Snaga { get; set; }

        public override string ToString()
        {
            return Proizvodjac + "-" + Tip;
        }
    }
}
