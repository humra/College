using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public string Naziv { get; set; }
    public int IDGrad { get; set; }
    public int IDDrzava { get; set; }

    public Grad() { }

    public Grad(string Naziv, int IDGrad, int IDDrzava)
    {
        this.Naziv = Naziv;
        this.IDGrad = IDGrad;
        this.IDDrzava = IDDrzava;
    }
}