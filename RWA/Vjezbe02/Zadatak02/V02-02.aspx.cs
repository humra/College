using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02_V02_02 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            NapuniDrzave();
            NapuniGradove();
        }
    }

    private void NapuniGradove()
    {
        ddlListGradovi.Items.Clear();

        foreach (Grad g in Repozitorij.ListaGradova())
        {
            if (g.idDrzava == int.Parse(ddlListDrzave.SelectedValue))
            {
                ddlListGradovi.Items.Add(g.naziv);
            }
        }
    }

    private void NapuniDrzave()
    {
        foreach (Drzava d in Repozitorij.ListaDrzava())
        {
            ddlListDrzave.Items.Add(new ListItem(d.naziv, d.id.ToString()));
        }
    }


    protected void ddlListDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        NapuniGradove();
    }
}