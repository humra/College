using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Response.Cookies["podaci1"] != null)
        {
            Response.Redirect("Narudzba.aspx");
        }
    }

    protected void btnUlaz_Click(object sender, EventArgs e)
    {
        HttpCookie kuki = new HttpCookie("podaci1");

        kuki["imePrezime"] = Server.UrlEncode(txtImePrezime.Text);
        kuki["adresa"] = Server.UrlEncode(txtAdresa.Text);
        kuki["mail"] = txtMail.Text;

        kuki.Expires = DateTime.Now.AddSeconds(130);

        Response.Cookies.Add(kuki);
        Response.Redirect("Narudzba.aspx");
    }
}