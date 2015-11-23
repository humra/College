using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Osoba
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Email { get; set; }
    public string Telefon { get; set; }

	public Osoba(){ }

    public override string ToString()
    {
        return string.Format("{0} {1}, {2}, {3}", Ime, Prezime, Email, Telefon);
    }
}