using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Obrazac : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string pass = txtPassword.Text;

        if (username.Equals("Pero") && pass.Equals("123"))
        {
            HttpCookie kuki = new HttpCookie("podaci");
            kuki["username"] = username;
            kuki["password"] = pass;
            kuki.Expires = DateTime.MaxValue;

            Response.Cookies.Add(kuki);
            Response.Redirect("Default.aspx");
        }
        else
        {
            phObavijest.Controls.Add(new LiteralControl("<h3>Pristup je dozvoljen samo korisniku Pero</h3>"));
        }
    }
}