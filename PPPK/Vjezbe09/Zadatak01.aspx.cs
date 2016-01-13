using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01 : System.Web.UI.Page
{
    private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            prikaziMarke();
        }
    }

    private void prikaziMarke()
    {
        ddlMarke.DataSource = SqlHelper.ExecuteReader(cs, System.Data.CommandType.StoredProcedure, "DohvatiSveAutomobile");
        ddlMarke.DataTextField = "Tip";
        ddlMarke.DataValueField = "idAutomobil";
        ddlMarke.DataBind();

        prikaziPodatke();
    }

    private void prikaziPodatke()
    {
        int idAuto = int.Parse(ddlMarke.SelectedValue);
        DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiAuto", idAuto);

        DataRow dr = ds.Tables[0].Rows[0];

        txtGodina.Text = dr["Godina"].ToString();
        txtKS.Text = dr["Ks"].ToString();
        txtMarka.Text = dr["Tip"].ToString();
        txtProizvodjac.Text = dr["Proizvodjac"].ToString();

        lblUpisano.Text = SqlHelper.ExecuteScalar(cs, "DohvatiBrojUpisanihAutomobila").ToString();
    }

    protected void ddlMarke_SelectedIndexChanged(object sender, EventArgs e)
    {
        prikaziPodatke();
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int idAuta = int.Parse(ddlMarke.SelectedValue);
        SqlHelper.ExecuteNonQuery(cs, "DeleteAuto", idAuta);

        prikaziMarke();
    }

    protected void btnInsert_Click(object sender, EventArgs e)
    {
        string tip = txtMarka.Text;
        string proizvodjac = txtProizvodjac.Text;
        int godina = int.Parse(txtGodina.Text);
        int ks = int.Parse(txtKS.Text);

        if (SqlHelper.ExecuteNonQuery(cs, "InsertAuto", tip, proizvodjac, godina, ks) > 0)
        {
            lblInfo.Text = "Auto unesen";
            prikaziMarke();
        }
        else
        {
            lblInfo.Text = "Auto vec postoji";
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        string tip = txtMarka.Text;
        string proizvodjac = txtProizvodjac.Text;
        int godina = int.Parse(txtGodina.Text);
        int ks = int.Parse(txtKS.Text);

        if (SqlHelper.ExecuteNonQuery(cs, "UpdateAuto", ddlMarke.SelectedValue, tip, proizvodjac, godina, ks) > 0)
        {
            lblInfo.Text = "Auto updatean";
            prikaziMarke();
        }
        else
        {
            lblInfo.Text = "Podatke nije bilo moguce updateati";
        }
    }
}