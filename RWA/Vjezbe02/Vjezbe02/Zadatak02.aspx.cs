using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe02
{
    public partial class Zadatak02 : System.Web.UI.Page
    {
        Repozitorij r = new Repozitorij();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                NapuniDrzave();
            }
        }

        private void NapuniDrzave()
        {
            ddlDrzava.Items.Clear();
            List<Drzava> drzave = r.vratiDrzave();

            foreach(Drzava d in drzave)
            {
                ddlDrzava.Items.Add(new ListItem(d.naziv, d.id.ToString()));
            }

            ddlDrzava.SelectedIndex = 0;

            NapuniGradove();
        }

        private void NapuniGradove()
        {
            ddlGradovi.Items.Clear();
            List<Grad> gradovi = r.vratiGradove();

            foreach(Grad g in gradovi)
            {
                if(g.idDrzava.ToString().Equals(ddlDrzava.SelectedValue))
                {
                    ddlGradovi.Items.Add(new ListItem(g.naziv, g.id.ToString()));
                }
            }
        }

        protected void ddlDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            NapuniGradove();
        }
    }
}