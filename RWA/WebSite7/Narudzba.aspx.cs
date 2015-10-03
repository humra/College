using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Narudzba : System.Web.UI.Page
{
    public List<string> listaKosarica
    {
        get
        {
            if (Session["kosarica"] == null)
            {
                Session["kosarica"] = new List<string>();
            }
            return (List<string>)Session["kosarica"];
        }

        set
        {
            Session["kosarica"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["podaci1"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        HttpCookie podaci = Request.Cookies["podaci1"];
        lblPodaci.Text = String.Format("{0}, dobro dosli u online kupnju!", podaci["imePrezime"]);
    }
    protected void btnDodaj_Click(object sender, EventArgs e)
    {
        string artikl = txtArtikl.Text;
        if (artikl != "")
        {
            lbKosarica.Items.Add(artikl);
            listaKosarica.Add(artikl);
            txtArtikl.Text = String.Empty;
        }
    }
    protected void btnZavrsi_Click(object sender, EventArgs e)
    {
        if (listaKosarica.Count > 0)
        {
            Response.Redirect("Sazetak.aspx");
        }
        else
        {
            lblInfo.Text = "Niste unjeli niti jedan artikl!";
        }
    }
}