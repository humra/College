using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe04
{
    public partial class CtrlDefineButton : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                popuniLabele();
            }
        }

        private void popuniLabele()
        {
            lblTekst.Text = "Gumb " + Session["frames"] + " tekst: ";
            lblURL.Text = "Gumb " + Session["frames"] + " URL: ";
        }

        protected void btnSpremi_Click(object sender, EventArgs e)
        {
            frame.Visible = true;
            frame.Attributes.Add("src", txtURL.Text);
        }
    }
}