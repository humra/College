using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public int IDdrzava { get; set; }
    public string Naziv { get; set; }

    public Grad()
    {
    }

    public Grad(int drzavaID, string nazivGrada)
    {
        IDdrzava = drzavaID;
        Naziv = nazivGrada;
    }
}