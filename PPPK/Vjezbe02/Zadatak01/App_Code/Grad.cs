using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public int IDGrad { get; set; }
    public string Naziv { get; set; }
    public int DrzavaID { get; set; }

	public Grad()
	{
        
	}

    public Grad(string naziv, int drzava)
    {
        this.Naziv = naziv;
        this.DrzavaID = drzava;
    }
}