using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak03 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnIspis_Click(object sender, EventArgs e)
    {
        Osoba o = new Osoba { ime = txtIme.Text, prezime = txtPrezime.Text };
        ViewState["osoba"] = o;
    }

    protected override void OnPreRender(EventArgs e)
    {
        if (IsPostBack)
        {
            Osoba o = (Osoba)ViewState["osoba"];
            lblPodaci.Text = o.ToString();
        }

        base.OnPreRender(e);
    }
}