using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02 : System.Web.UI.Page
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
        foreach (Drzava d in Repozitorij.ListaDrzava())
        {
            ddlDrzava.Items.Add(new ListItem(d.naziv, d.id.ToString()));
        }
    }

    private void PrikaziGradove()
    {
        ddlGrad.Items.Clear();
        int id = int.Parse(ddlDrzava.SelectedValue);

        foreach (Grad g in Repozitorij.ListaGradova())
        {
            if (g.drzavaId == id)
            {
                ddlGrad.Items.Add(new ListItem(g.naziv, g.drzavaId.ToString()));
            }
        }
    }


    protected void ddlDrzava_SelectedIndexChanged(object sender, EventArgs e)
    {
        PrikaziGradove();
    }
}