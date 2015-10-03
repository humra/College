using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            UnesiGradove();
            UnesiSpolove();
        }
    }

    private void UnesiSpolove()
    {
        rbSpol.Items.Add(new ListItem("M"));
        rbSpol.Items.Add(new ListItem("Ž"));
    }

    private void UnesiGradove()
    {
        ddlGrad.Items.Add(new ListItem("Zagreb"));
        ddlGrad.Items.Add(new ListItem("Osijek"));
        ddlGrad.Items.Add(new ListItem("Rijeka"));
    }
    protected void btnIspisi_Click(object sender, EventArgs e)
    {
        string ime = txtIme.Text;
        string prezime = txtPrezime.Text;
        string grad = ddlGrad.SelectedItem.Text;
        string spol = rbSpol.SelectedItem.Text;
        bool vozacka = chkVozacka.Checked;

        StringBuilder sb = new StringBuilder();

        sb.Append("<b>Ime: </b>");
        sb.Append(ime);
        sb.Append("<br/><b>Prezime: </b>");
        sb.Append(prezime);
        sb.Append("<br/><b>Grad: </b>");
        sb.Append(grad);
        sb.Append("<br/><b>Spol: </b>");
        sb.Append(spol);
        sb.Append("<br/><b>Vozacka dozvola: </b>");

        if (vozacka)
        {
            sb.Append("ima vozacku dozvolu");
        }
        else
        {
            sb.Append("nema vozacku dozvolu");
        }

        LiteralControl l = new LiteralControl(sb.ToString());
        panelShow.Controls.Add(l);
    }
}