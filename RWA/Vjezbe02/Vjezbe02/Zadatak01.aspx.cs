using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vjezbe02
{
    public partial class Zadatak01 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                napuniListu();
                napuniRadioButton();
            }
        }

        private void napuniRadioButton()
        {
            RadioButtonList1.Items.Add(new ListItem("M", "M"));
            RadioButtonList1.Items.Add(new ListItem("F", "F"));
        }

        private void napuniListu()
        {
            ddlGrad.Items.Add(new ListItem("Zagreb"));
            ddlGrad.Items.Add(new ListItem("Rijeka"));
            ddlGrad.Items.Add(new ListItem("Split"));

        }

        protected void btnIspisi_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<p>Ime: " + txtIme.Text);
            sb.Append("<br/>Prezime: " + txtPrezime.Text);
            sb.Append("<br/>Grad: " + ddlGrad.SelectedValue);
            sb.Append("<br/>Spol: " + RadioButtonList1.SelectedValue);
            sb.Append("<br/>Vozacka: ");

            if (cbVozacka.Checked)
            {
                sb.Append("Ima<br/></p>");
            }
            else
            {
                sb.Append("Nema<br/></p>");
            }

            LiteralControl ispis = new LiteralControl(sb.ToString());

            panelInfo.Controls.Add(ispis);
        }
    }
}