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

    }
    protected void btnUlaz_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username.Equals("Pero") || password.Equals("123"))
        {
            Session["username"] = username;
            Session["password"] = password;
            Response.Redirect("Kupovina.aspx");
        }
        else
        {
            lblInfo.Text = "Pristup je dozvoljen samo korisniku Pero!";
        }
    }
}