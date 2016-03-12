using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe01
{
    public partial class Prima : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Osoba o = new Osoba();

            if(Request.QueryString.Count > 0)
            {
                //GET
                o.ime = Request.QueryString["ime"];
                o.prezime = Request.QueryString["prezime"];
                o.grad = Request.QueryString["grad"];
                PrikaziPodatke(o, "get");
            }
            else if (Request.Form.Count > 0)
            {
                o.ime = Request.Form["postIme"];
                o.prezime = Request.Form["postPrezime"];
                o.grad = Request.Form["postGrad"];
                PrikaziPodatke(o, "post");
            }
            else
            {
                Response.Write("<h1>Niste upisali podatke</h1><br/><a href='Salje.aspx'>Natrag</a>");
            }
        }

        private void PrikaziPodatke(Osoba o, string metoda)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<h1>Podaci su poslani ");
            sb.Append(metoda.ToUpper());
            sb.Append(" metodom</h1><br/<br/>");

            sb.Append("Ime: ");
            sb.Append(o.ime);
            sb.Append("<br/>");

            sb.Append("Prezime: ");
            sb.Append(o.prezime);
            sb.Append("<br/>");

            sb.Append("Grad: ");
            sb.Append(o.grad);
            sb.Append("<br/>");

            Response.Write(sb.ToString());
        }
    }
}