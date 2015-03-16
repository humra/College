using Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Send_Recieve_Prima : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Form.Count > 0)
        {
            string ime = Request.Form["postIme"];
            string prezime = Request.Form["postPrezime"];
            string grad = Request.Form["grad"];

            Osoba o = new Osoba(ime, prezime, grad);

            ispis(o, "POST");
        }
        else if (Request.QueryString.Count > 0)
        {
            string ime = Request.QueryString["getIme"];
            string prezime = Request.QueryString["getPrezime"];
            string grad = Request.QueryString["grad"];

            Osoba o = new Osoba(ime, prezime, grad);

            ispis(o, "GET");
        }
    }

    private void ispis(Osoba o, string metoda)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<h1>Podaci su poslani ");
        sb.Append(metoda);
        sb.Append(" metodom.</h1><br/>");

        sb.Append("Ime: ");
        sb.Append(o.ime);
        sb.Append("<br/>Prezime: ");
        sb.Append(o.prezime);
        sb.Append("<br/>Grad: ");
        sb.Append(o.grad);

        Response.Write(sb.ToString());
    }
}