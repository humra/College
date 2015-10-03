using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public string naziv;
    public int drzavaId;

	public Grad(int idDrzave, string naziv)
	{
        this.naziv = naziv;
        this.drzavaId = idDrzave;
	}
}