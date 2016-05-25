using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe03
{
    public partial class Artikli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if(Request.Cookies["ponuda"] != null & Request.Cookies["odabrano"] != null)
                {
                    updateListe();
                }
                else
                {
                    prikaziArtikle();
                }
            }
        }

        private void updateListe()
        {
            HttpCookie ponuda = Request.Cookies["ponuda"];
            HttpCookie odabrano = Request.Cookies["odabrano"];

            int brojPonuda = ponuda.Values.Count;
            int brojOdabrano = odabrano.Values.Count;

            for(int i = 0; i < brojPonuda; i++)
            {
                lbPonuda.Items.Add(ponuda["artikl" + i]);
            }

            for(int i = 0; i < brojOdabrano; i++)
            {
                lbOdabrano.Items.Add(odabrano["artikl" + i]);
            }
        }

        private void prikaziArtikle()
        {
            lbPonuda.Items.Add("1");
            lbPonuda.Items.Add("2");
            lbPonuda.Items.Add("3");
            lbPonuda.Items.Add("4");
            lbPonuda.Items.Add("5");
            lbPonuda.Items.Add("6");
            lbPonuda.Items.Add("7");
        }

        protected void btnOdaberi_Click(object sender, EventArgs e)
        {
            if (lbPonuda.SelectedIndex != -1)
            {
                ListItem odabrani = lbPonuda.SelectedItem;

                lbOdabrano.Items.Add(odabrani);
                lbPonuda.Items.Remove(odabrani);

                lbPonuda.SelectedIndex = -1;

                updateCookies();
            }
        }

        private void updateCookies()
        {
            HttpCookie ponuda = new HttpCookie("ponuda");
            HttpCookie odabrano = new HttpCookie("odabrano");

            for(int i = 0; i < lbPonuda.Items.Count; i++)
            {
                ponuda["artikl" + i] = lbPonuda.Items[i].Text;
            }

            for(int i = 0; i < lbOdabrano.Items.Count; i++)
            {
                odabrano["artikl" + i] = lbOdabrano.Items[i].Text;
            }

            ponuda.Expires = DateTime.Now.AddMonths(1);
            odabrano.Expires = DateTime.Now.AddMonths(1);

            Response.Cookies.Add(ponuda);
            Response.Cookies.Add(odabrano);
        }

        protected void btnMakni_Click(object sender, EventArgs e)
        {
            if (lbOdabrano.SelectedIndex != -1)
            {
                ListItem odabrano = lbOdabrano.SelectedItem;

                lbPonuda.Items.Add(odabrano);
                lbOdabrano.Items.Remove(odabrano);

                lbOdabrano.SelectedIndex = -1;

                updateCookies();
            }
        }
    }
}