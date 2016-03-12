using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe01
{
    public partial class Rezultat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string brojA = Request.Form["brojA"];
            string brojB = Request.Form["brojB"];
            string operacija = Request.Form["operacija"];

            if(brojA == "" || brojB == "")
            {
                Response.Redirect("Kalkulator.html");
            }

            else
            {
                prikaziRezultat(brojA, brojB, operacija);
            }
        }

        private void prikaziRezultat(string brojA, string brojB, string operacija)
        {
            try
            {
                int a = int.Parse(brojA);
                int b = int.Parse(brojB);

                double rez = izracunaj(a, b, operacija);

                Response.Write(a + " " + operacija + " " + b + " = " + rez + "<br/><a href='Kalkulator.html'>Natrag</a>");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        private double izracunaj(int a, int b, string operacija)
        {
            switch(operacija)
            {
                case "+":
                    return a + b;
                case "-":
                    return a - b;
                case "*":
                    return a * b;
                case "/":
                    return a / b;
                default:
                    return 0;
            }
        }
    }
}