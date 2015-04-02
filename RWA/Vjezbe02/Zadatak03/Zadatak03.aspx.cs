using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak03_Zadatak03 : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Osoba o = new Osoba { ime = txtIme.Text, prezime = txtPrezime.Text };
        ViewState["osoba"] = o;
    }

    protected override void OnPreRender(EventArgs e)
    {
        if (IsPostBack)
        {
            Osoba o = (Osoba)ViewState["osoba"];
            lblIme.Text = String.Format("{0} {1}", o.ime, o.prezime);
        }
        base.OnPreRender(e);
    }
}