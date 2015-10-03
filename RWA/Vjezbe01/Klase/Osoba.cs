using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase
{
    public class Osoba
    {
        public string ime;
        public string prezime;
        public string grad;

        public Osoba() { }

        public Osoba(string ime, string prezime, string grad)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.grad = grad;
        }
    }
}
