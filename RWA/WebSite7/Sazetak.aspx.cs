using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Sazetak : System.Web.UI.Page
{
    public List<string> kosarica
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
        if (Request.Cookies["podaci"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        PrikaziPodatke();
    }

    private void PrikaziPodatke()
    {
        HttpCookie kuki = Request.Cookies["podaci"];

        string imePrezime = Server.UrlEncode(kuki["imePrezime"]);
        string adresa = Server.UrlEncode(kuki["adresa"]);
        string mail = kuki["mail"];

        lblImePrezime.Text = String.Format("{0} kupili ste: ", imePrezime);

        foreach (string s in kosarica)
        {
            blArtikli.Items.Add(s);
        }

        lblAdresa.Text = String.Format("Stvari ce Vam biti dostavljene na adresu {0}", adresa);
        lblMail.Text = String.Format("U slucaju poteskoca kontaktirat cemo Vas na e-mail adresu {0}", mail);
    }
}