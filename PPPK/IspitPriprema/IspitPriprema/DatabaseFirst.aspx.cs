using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IspitPriprema
{
    public partial class DatabaseFirst : System.Web.UI.Page
    {
        private DatabaseFirstEntities db = new DatabaseFirstEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                napuniDDLGradovi();
            }
        }

        private void napuniDDLGradovi()
        {
            var grads = (from g in db.Grads select g).ToList();

            dropdownGradovi.DataSource = grads;
            dropdownGradovi.DataValueField = "IDGrad";
            dropdownGradovi.DataTextField = "Naziv";
            dropdownGradovi.DataBind();

            dropdownGradovi.SelectedIndex = 0;
            updateKupci();
        }

        private void updateKupci()
        {
            lbKupci.Items.Clear();

            var kupci = (from k in db.Kupacs where k.GradID.ToString().Equals(dropdownGradovi.SelectedValue) select k).ToList();

            foreach (Kupac k in kupci)
            {
                lbKupci.Items.Add(new ListItem(k.Ime + " " + k.Prezime, k.IDKupac.ToString()));
            }
        }

        protected void updateKupci(object sender, EventArgs e)
        {
            updateKupci();
        }
    }
}