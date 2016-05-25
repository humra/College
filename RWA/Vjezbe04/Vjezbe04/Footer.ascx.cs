using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe04
{
    public partial class Footer : System.Web.UI.UserControl
    {
        public bool kratko
        {
            get
            {
                if(Session["kratko"] == null)
                {
                    Session["kratko"] = true;
                }

                return (bool)Session["kratko"];
            }
            set
            {
                Session["kratko"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                kratko = !kratko;
            }
            prikaziVrijeme();
        }

        private void prikaziVrijeme()
        {
            if(kratko)
            {
                lbDatumVrijeme.Text = DateTime.Now.ToShortDateString();
            }
            else
            {
                lbDatumVrijeme.Text = DateTime.Now.ToLongDateString();
            }
        }

        protected void lbDatumVrijeme_Click(object sender, EventArgs e)
        {
            kratko = !kratko;
        }
    }
}