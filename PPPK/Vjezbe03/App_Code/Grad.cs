using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Grad
{
    public int IDGrad { get; set; }
    public int DrzavaID { get; set; }
    public string Naziv { get; set; }

    public Grad() { }

    public Grad(int IDGrad, int DrzavaID, string Naziv)
    {
        this.IDGrad = IDGrad;
        this.DrzavaID = DrzavaID;
        this.Naziv = Naziv;
    }
}