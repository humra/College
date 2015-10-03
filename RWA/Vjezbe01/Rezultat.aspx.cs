using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rezultat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string brojA = Request.QueryString["brojA"];
        string brojB = Request.QueryString["brojB"];
        string operacija = Request.QueryString["operacija"];

        if (brojA == "" || brojB == "")
        {
            Response.Redirect("Kalkulator.aspx");
        }
        else
        {
            int a = 0;
            int b = 0;

            try
            {
                a = int.Parse(brojA);
                b = int.Parse(brojB);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

            float rez = 0;

            switch (operacija)
            {
                case "+":
                    rez = a + b;
                    break;
                case "-":
                    rez = a - b;
                    break;
                case "*":
                    rez = a * b;
                    break;
                case "/":
                    rez = (float)a / b;
                    break;
                default:
                    break;
            }

            StringBuilder sb = new StringBuilder();
            sb.Append("<h1>");
            sb.Append(a.ToString());
            sb.Append(operacija);
            sb.Append(b.ToString());
            sb.Append("=");
            sb.Append(rez.ToString());
            sb.Append("</h1>");

            Response.Write(sb.ToString());
            Response.Write("<br/><a href='Kalkulator.aspx'>Natrag</a>");
        }
    }
}