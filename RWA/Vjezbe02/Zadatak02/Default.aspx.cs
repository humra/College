using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PrikaziDrzave();
            PrikaziGradove();
        }
    }

    private void PrikaziDrzave()
    {
        foreach (Drzava drzava in Repozitorij.ListaDrzava())
        {
            ddlDrzave.Items.Add(new ListItem(drzava.Naziv, drzava.ID.ToString()));
        }
    }

    private void PrikaziGradove()
    {
        ddlGradovi.Items.Clear();

        int drzavaID = int.Parse(ddlDrzave.SelectedValue);
        foreach (Grad grad in Repozitorij.ListaGradova())
        {
            if (grad.IDdrzava == drzavaID)
                ddlGradovi.Items.Add(grad.Naziv);
        }
    }
    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        PrikaziGradove();
    }
}