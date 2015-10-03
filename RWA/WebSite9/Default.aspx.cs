using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["podaci"] != null)
        {
            PrikaziPodatke();
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }

    private void PrikaziPodatke()
    {
        HttpCookie kuki = Request.Cookies["podaci"];

        string user = kuki["username"].ToString();
        string pass = kuki["password"].ToString();

        if (user.Equals("Pero") && pass.Equals("123"))
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<h2><b>Korisnicko ime: ");
            sb.Append(user);
            sb.Append("</br>Lozinka: ");
            sb.Append(pass);
            sb.Append("</b></h2>");

            phInfo.Controls.Add(new LiteralControl(sb.ToString()));
        }
        else
        {
            Response.Redirect("Login.aspx");
        }
    }
}