using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Obradi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count != 0 || Request.Form.Count != 0)
        {
            if (Request.QueryString.Count > 0)
            {
                IspisiGetPodatke();
            }
            else if (Request.Form.Count > 0)
            {
                IspisiPostPodatke();
            }
        }
    }

    private void IspisiPostPodatke()
    {
        string a = Request.Form["txtA"];
        string b = Request.Form["txtB"];

        PrikaziParametre("Parametri su poslani POST metodom", a, b);
    }

    private void PrikaziParametre(string p, string a, string b)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(p);
        sb.Append("<br/>");
        sb.Append("Parametar A: " + a);
        sb.Append("<br/>");
        sb.Append("Parametar B: " + b);
        sb.Append("<a href='Index.aspx'>Nazad</a><br/>");

        Response.Write(sb.ToString());
    }

    private void IspisiGetPodatke()
    {
        string a = Request.QueryString["txtA"];
        string b = Request.QueryString["txtB"];

        PrikaziParametre("Parametri su poslani GET metodom", a, b);
    }


}