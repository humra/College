using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe04
{
    public partial class kontrola : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["korisnik"] != null)
            {
                HttpCookie kuki = Request.Cookies["korisnik"];
                if(korisnikPero(kuki))
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }

        private bool korisnikPero(HttpCookie kuki)
        {
            string ime = kuki["username"];
            string pass = kuki["password"];

            if(ime.ToLower().Equals("pero") && pass.ToLower().Equals("123"))
            {
                return true;
            }
            return false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtLozinka.Text;

            if(username.ToLower().Equals("pero") && password.ToLower().Equals("123"))
            {
                HttpCookie kuki = new HttpCookie("korisnik");
                kuki["username"] = username.ToLower();
                kuki["password"] = password.ToLower();
                kuki.Expires = DateTime.Now.AddSeconds(100);
                Response.Cookies.Add(kuki);

                Response.Redirect("Default.aspx");
            }
            else
            {
                lblInfo.Visible = true;
                lblInfo.Text = "Pristup je dozvoljen samo korisniku Pero!";
            }
        }
    }
}