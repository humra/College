using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kupovina : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["username"] == null || Session["password"] == null)
        {
            Response.Redirect("Login.aspx");
        }

        if (!IsPostBack)
        {
            if (Request.Cookies["odabrano"] == null && Request.Cookies["ponuda"] == null)
            {
                PrikaziPonudjeneArtikle();
            }
            else
            {
                UpdateajArtikleKorisnika();
            }
        }
    }

    private void UpdateajArtikleKorisnika()
    {
        HttpCookie ponuda = Request.Cookies["ponuda"];
        HttpCookie odabrano = Request.Cookies["odabrano"];

        int brojPonuda = ponuda.Values.Count;
        int brojOdabranog = odabrano.Values.Count;

        for (int i = 0; i < brojPonuda; i++)
        {
            lbPonuda.Items.Add(ponuda["artikl" + i]);
        }

        for (int i = 0; i < brojOdabranog; i++)
        {
            lbKosarica.Items.Add(odabrano["artikl" + i]);
        }
    }

    private void PrikaziPonudjeneArtikle()
    {
        lbPonuda.Items.Add("1");
        lbPonuda.Items.Add("2");
        lbPonuda.Items.Add("3");
        lbPonuda.Items.Add("4");
        lbPonuda.Items.Add("5");
        lbPonuda.Items.Add("6");
    }

    protected void btnDesno_Click(object sender, EventArgs e)
    {
        if (lbPonuda.SelectedIndex != -1)
        {
            lbKosarica.Items.Add(lbPonuda.SelectedItem);
            lbPonuda.Items.Remove(lbPonuda.SelectedItem);
            lbPonuda.SelectedIndex = -1;
            UpdateajCookie();
        }
    }

    private void UpdateajCookie()
    {
        HttpCookie ponuda = new HttpCookie("ponuda");
        HttpCookie odabrano = new HttpCookie("odabrano");

        for (int i = 0; i < lbPonuda.Items.Count; i++)
        {
            ponuda["artikl" + i] = lbPonuda.Items[i].Text;
        }

        for (int i = 0; i < lbKosarica.Items.Count; i++)
        {
            odabrano["artikl" + i] = lbKosarica.Items[i].Text;
        }

        ponuda.Expires = DateTime.Now.AddMonths(1);
        odabrano.Expires = DateTime.Now.AddMonths(1);
    }

    protected void btnLijevo_Click(object sender, EventArgs e)
    {
        if (lbKosarica.SelectedIndex != -1)
        {
            lbPonuda.Items.Add(lbKosarica.SelectedItem);
            lbKosarica.Items.Remove(lbKosarica.SelectedItem);
            lbKosarica.SelectedIndex = -1;
            UpdateajCookie();
        }
    }
}