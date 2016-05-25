using System;

namespace Vjezbe02
{   
    [Serializable]
    internal class Osoba
    {
        public string ime;
        public string prezime;

        public Osoba(string ime, string prezime)
        {
            this.ime = ime;
            this.prezime = prezime;
        }

        public override string ToString()
        {
            return string.Format(ime + " " + prezime);
        }
    }
}