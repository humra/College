using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe04
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["korisnik"] != null)
            {
                HttpCookie kuki = Request.Cookies["korisnik"];

                if(!korisnikPero(kuki))
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    pisiPodatke(kuki);
                }
            }
        }

        private void pisiPodatke(HttpCookie kuki)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Korisnicko ime: ");
            sb.Append(kuki["username"]);
            sb.Append("<br/>");
            sb.Append("Lozinka: ");
            sb.Append(kuki["password"]);
        }

        private bool korisnikPero(HttpCookie kuki)
        {
            string username = kuki["username"].ToLower();
            string password = kuki["password"].ToLower();

            if(username.Equals("pero") && password.Equals("pero"))
            {
                return true;
            }
            return false;
        }
    }
}