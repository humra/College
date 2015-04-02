using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnIspis_Click(object sender, EventArgs e)
    {
        Osoba o = new Osoba { Ime = txtIme.Text, Prezime = txtPrezime.Text };
        ViewState["osoba"] = o;
    }

    protected override void OnPreRender(EventArgs e)
    {
        if (IsPostBack)
        {
            Osoba o = (Osoba)ViewState["osoba"];
            lblInfo.Text = String.Format("{0} {1}", o.Ime, o.Prezime);
        }
        base.OnPreRender(e);
    }
}