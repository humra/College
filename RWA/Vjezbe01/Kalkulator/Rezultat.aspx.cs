using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Rezultat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string prvi = Request.QueryString["prvi"];
        string drugi = Request.QueryString["drugi"];
        string operacija = Request.QueryString["operacija"];

        float rezultat = 0f;
        int a = 0;
        int b = 0;

        if (prvi != "" && drugi != "")
        {
            try
            {
                a = int.Parse(prvi);
                b = int.Parse(drugi);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

            switch (operacija)
            {
                case "+":
                    rezultat = a + b;
                    break;
                case "-":
                    rezultat = a - b;
                    break;
                case "*":
                    rezultat = a * b;
                    break;
                case "/":
                    rezultat = a / b;
                    break;
                default:
                    break;
            }
        }
        else
        {
            Response.Redirect("Calc.aspx");
        }

        Response.Write(String.Format("<h1>{0} {1} {2} = {3}</h1>", a, operacija, b, rezultat));
        Response.Write("<a href='Calc.aspx'>Ponovi unos</a>");
    }
}