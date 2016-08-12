using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CodeFirst
{
    public partial class CodeFirst : System.Web.UI.Page
    {
        CodeFirstModel db = new CodeFirstModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                napuniDrzave();
            }
        }

        private void napuniDrzave()
        {
            var drzave = (from d in db.Drzavas select d).ToList();

            foreach(Drzava d in drzave)
            {
                ddlDrzava.Items.Add(new ListItem(d.Naziv, d.IDDrzava.ToString()));
            }

            ddlDrzava.SelectedIndex = 0;
            napuniGradove();
        }

        private void napuniGradove()
        {
            var gradovi = (from g in db.Grads where g.DrzavaID.ToString().Equals(ddlDrzava.SelectedValue) select g).ToList();
            lbGrad.Items.Clear();

            foreach(Grad g in gradovi)
            {
                lbGrad.Items.Add(new ListItem(g.Naziv));
            }
        }

        protected void ddlDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            napuniGradove();
        }
    }
}