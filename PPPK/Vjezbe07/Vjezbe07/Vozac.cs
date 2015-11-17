using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe07
{
    public class Vozac
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string PunoIme { get { return Ime + " " + Prezime; } }

        public Vozac() { }
    }
}
