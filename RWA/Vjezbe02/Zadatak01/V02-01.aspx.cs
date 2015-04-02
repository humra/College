using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01_V02_01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            PopuniPodatke();
    }

    private void PopuniPodatke()
    {
        rbSpol.Items.Add(new ListItem("M"));
        rbSpol.Items.Add(new ListItem("F"));

        ddlGrad.Items.Add(new ListItem("Zagreb"));
        ddlGrad.Items.Add(new ListItem("Rijeka"));
        ddlGrad.Items.Add(new ListItem("Osijek"));
    }

    protected void btnIspisi_Click(object sender, EventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append("<p><b>Ime: </b>");
        sb.Append(txtIme.Text);
        sb.Append("<br/><b>Prezime: </b>");
        sb.Append(txtPrezime.Text);
        sb.Append("<br/><b>Grad: </b>");
        sb.Append(ddlGrad.SelectedItem.Text);
        sb.Append("<br/><b>Spol: </b>");
        sb.Append(rbSpol.SelectedItem.Text);
        sb.Append("<br/><b>Vozačka dozvola: </b>");

        if (cbVozacka.Checked)
        {
            sb.Append("Ima vozačku dozvolu</p>");
        }
        else
        {
            sb.Append("Nema vozačku dozvolu</p>");
        }

        LiteralControl ispis = new LiteralControl(sb.ToString());

        Panel2.Controls.Add(ispis);
    }
}