using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[Serializable]
public class Osoba
{
    public string ime;
    public string prezime;

	public Osoba()
	{	
	}

    public Osoba(string ime, string prezime)
    {
        this.ime = ime;
        this.prezime = prezime;
    }

    public override string ToString()
    {
        return string.Format("{0} {1}", this.ime, this.prezime);
    }
}