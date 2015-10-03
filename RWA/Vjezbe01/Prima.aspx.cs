using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Klase;
using System.Text;

public partial class Prima : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Osoba o = new Osoba();

        if (Request.QueryString.Count > 0)
        {
            o.ime = Request.QueryString["imeGet"];
            o.prezime = Request.QueryString["prezimeGet"];
            o.grad = Request.QueryString["gradGet"];

            PrikaziPodatke(o, "Podaci su poslani GET metodom!");
        }
        else if (Request.Form.Count > 0)
        {
            o.ime = Request.Form["imePost"];
            o.prezime = Request.Form["prezimePost"];
            o.grad = Request.Form["gradPost"];

            PrikaziPodatke(o, "Podaci su poslani POST metodom!");
        }
    }

    private void PrikaziPodatke(Osoba o, string p)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(p);
        sb.Append("<br/>Ime: " + o.ime);
        sb.Append("<br/>Prezime: " + o.prezime);
        sb.Append("<br/>Grad: " + o.grad);

        Response.Write(sb.ToString());
    }
}