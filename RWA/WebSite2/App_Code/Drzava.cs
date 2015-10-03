using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Drzava
{
    public string naziv;
    public int id;

	public Drzava(int id, string naziv)
	{
        this.id = id;
        this.naziv = naziv;
	}

    public Drzava()
    {
        // TODO: Complete member initialization
    }
}