using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe02
{
    public partial class Zadatak03 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIspis_Click(object sender, EventArgs e)
        {
            Osoba o = new Osoba(txtIme.Text, txtPrezime.Text);

            ViewState.Add("osoba", o);

            ispisi();
        }

        private void ispisi()
        {
            Osoba o = (Osoba) ViewState["osoba"];

            lblIspis.Text = o.ToString();
        }
    }
}