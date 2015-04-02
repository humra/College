using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public int idDrzava { get; set; }
    public string naziv { get; set; }

	public Grad(int idDrzava, string naziv)
	{
        this.idDrzava = idDrzava;
        this.naziv = naziv;
	}
}