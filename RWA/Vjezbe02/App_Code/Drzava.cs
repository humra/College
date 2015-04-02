using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Drzava
{
    public int id { get; set; }
    public string naziv { get; set; }

    public Drzava(int id, string naziv)
    {
        this.id = id;
        this.naziv = naziv;
    }
}