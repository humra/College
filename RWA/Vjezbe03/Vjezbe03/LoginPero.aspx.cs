using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class LoginPero : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        protected void btnUlaz_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.ToLower() == "pero" && txtPassword.Text.ToLower() == "123")
            {
                Response.Redirect("Artikli.aspx");
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Pristup dozvoljen samo korisniku Pero!";
            }
        }
    }
}