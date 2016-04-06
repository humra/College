using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezbe02
{
    public class Repozitorij
    {
        private List<Drzava> drzave;
        private List<Grad> gradovi;

        public Repozitorij()
        {
            drzave = new List<Drzava>();
            gradovi = new List<Grad>();

            drzave.Add(new Drzava(1, "Hrvatska"));
            drzave.Add(new Drzava(2, "Engleska"));
            drzave.Add(new Drzava(3, "Njemacka"));

            gradovi.Add(new Grad(1, "Zagreb", 1));
            gradovi.Add(new Grad(2, "Rijeka", 1));
            gradovi.Add(new Grad(3, "Vienna", 3));
            gradovi.Add(new Grad(4, "London", 2));
            gradovi.Add(new Grad(5, "Cambridge", 2));
        }

        public List<Drzava> vratiDrzave()
        {
            return drzave;
        }

        public List<Grad> vratiGradove()
        {
            return gradovi;
        }
    }
}