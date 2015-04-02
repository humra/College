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
        List<Drzava> temp = new List<Drzava>();

        temp.Add(new Drzava(1, "Hrvatska"));
        temp.Add(new Drzava(2, "Spanjolska"));

        return temp;
    }

    public static List<Grad> ListaGradova()
    {
        List<Grad> temp = new List<Grad>();

        temp.Add(new Grad(1, "Zagreb"));
        temp.Add(new Grad(1, "Rijeka"));
        temp.Add(new Grad(1, "Osijek"));
        temp.Add(new Grad(2, "Barcelona"));
        temp.Add(new Grad(2, "Madrid"));

        return temp;
    }

}