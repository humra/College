using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtImePrezime.Focus();
        }

        protected void btnUlaz_Click(object sender, EventArgs e)
        {
            HttpCookie kukiPodaci = new HttpCookie("podaci");
            kukiPodaci["imePrezime"] = txtImePrezime.Text;
            kukiPodaci["adresa"] = txtAdresa.Text;
            kukiPodaci["email"] = txtEmail.Text;
            kukiPodaci.Expires = DateTime.Now.AddSeconds(130);

            Response.Cookies.Add(kukiPodaci);
            Response.Redirect("Kupnja.aspx");
        }
    }
}