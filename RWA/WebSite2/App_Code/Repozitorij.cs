using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Repozitorij
{
	public Repozitorij()
	{
	}

    public static List<Drzava> ListaDrzava()
    {
        List<Drzava> kolekcijaDrzava = new List<Drzava>();
        kolekcijaDrzava.Add(new Drzava { id = 1, naziv = "Hrvatska" });
        kolekcijaDrzava.Add(new Drzava { id = 2, naziv = "Španjolska" });
        return kolekcijaDrzava;
    }

    public static List<Grad> ListaGradova()
    {
        List<Grad> kolekcijaGradova = new List<Grad>();
        kolekcijaGradova.Add(new Grad(1, "Zagreb"));
        kolekcijaGradova.Add(new Grad(1, "Rijeka"));
        kolekcijaGradova.Add(new Grad(1, "Split"));
        kolekcijaGradova.Add(new Grad(2, "Barcelona"));
        kolekcijaGradova.Add(new Grad(2, "Madrid"));

        return kolekcijaGradova;
    }
}