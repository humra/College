﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Drzava
{
    public int IDDrzava { get; set; }
    public string Naziv { get; set; }

    public Drzava() { }

    public Drzava(string Naziv, int IDDrzava)
    {
        this.Naziv = Naziv;
        this.IDDrzava = IDDrzava;
    }
}