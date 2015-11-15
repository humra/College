using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezbe07
{
    class Vozac
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public Vozac() { }

        public Vozac(int ID, string Ime, string Prezime)
        {
            this.ID = ID;
            this.Ime = Ime;
            this.Prezime = Prezime;
        }
    }
}
