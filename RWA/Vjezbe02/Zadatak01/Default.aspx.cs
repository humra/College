using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PrikaziGradove();
            PrikaziSpolove();
        }
    }

    private void PrikaziGradove()
    {
        ddlGrad.Items.Add(new ListItem("Zagreb"));
        ddlGrad.Items.Add(new ListItem("Rijeka"));
        ddlGrad.Items.Add(new ListItem("Zadar"));
        ddlGrad.Items.Add(new ListItem("Split"));
        ddlGrad.Items.Add(new ListItem("Dubrovnik"));
    }

    private void PrikaziSpolove()
    {
        rblSpol.Items.Add(new ListItem("M"));
        rblSpol.Items.Add(new ListItem("Ž"));
        rblSpol.SelectedIndex = 0;
    }

    protected void btnIspis_Click(object sender, EventArgs e)
    {
        PanelIspis.Visible = true;
        string vozackaDozvola = "";

        if (cbVozacka.Checked)
            vozackaDozvola = "Ima vozačku dozvolu";
        else
            vozackaDozvola = "Nema vozačku dozvolu";

        StringBuilder sb = new StringBuilder();
        sb.Append("<b>Ime:</b> ");
        sb.Append(txtIme.Text);
        sb.Append("<br/>");
        sb.Append("<b>Prezime:</b> ");
        sb.Append(txtPrezime.Text);
        sb.Append("<br/>");
        sb.Append("<b>Grad:</b> ");
        sb.Append(ddlGrad.SelectedItem.Text);
        sb.Append("<br/>");
        sb.Append("<b>Spol:</b> ");
        sb.Append(rblSpol.SelectedItem.Text);
        sb.Append("<br/>");
        sb.Append("<b>Vozačka dozvola:</b> ");
        sb.Append(vozackaDozvola);

        LiteralControl ispis = new LiteralControl(sb.ToString());

        PanelIspis.Controls.Add(ispis);
    }
}