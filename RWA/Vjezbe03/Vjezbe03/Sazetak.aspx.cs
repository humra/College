using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Sazetak : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            prikaziPozdrav();
            prikaziPodatke();
            napuniListu();
        }

        private void napuniListu()
        {
            List<string> kosarica = (List<string>)Session["kosarica"];

            foreach(string s in kosarica)
            {
                blProizvodi.Items.Add(s);
            }
        }

        private void prikaziPodatke()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Stvari ce vam biti dostavljene na adresu ");
            sb.Append(Request.Cookies["podaci"]["adresa"]);
            sb.Append("<br/>");
            sb.Append("U slucaju poteskoca kontaktirat cemov as na ");
            sb.Append(Request.Cookies["podaci"]["email"]);

            lblInfo.Text = sb.ToString();
        }

        private void prikaziPozdrav()
        {
            lblImePrezime.Text = Request.Cookies["podaci"]["imePrezime"] + " narucili ste: ";
        }
    }
}