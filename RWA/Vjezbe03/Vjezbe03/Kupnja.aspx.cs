using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Kupnja : System.Web.UI.Page
    {
        public List<string> kosarica
        {
            get
            {
                if(Session["kosarica"] == null)
                {
                    Session["kosarica"] = new List<string>();
                }
                return (List<string>)Session["kosarica"];
            }

            set
            {
                Session["kosarica"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.Cookies["podaci"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                prikaziPozdrav();
            }
        }

        private void prikaziPozdrav()
        {
            string imePrezime = Request.Cookies["podaci"]["imePrezime"];
            lblPozdrav.Text = imePrezime + ", dobrodosli u online kupnju!";
        }

        protected void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            string artikl = txtArtikl.Text;

            if(artikl != "")
            {
                lbKosarica.Items.Add(artikl);
                txtArtikl.Text = string.Empty;
                kosarica.Add(artikl);
            }
        }

        protected void btnZavrsiKupnju_Click(object sender, EventArgs e)
        {
            if(kosarica.Count <= 0)
            {
                lblInfo.Text = "Morate unjeti bar jedan artikl!";
            }
            else
            {
                Response.Redirect("Sazetak.aspx");
            }
        }
    }
}