using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    SqlDataAdapter adapter = new SqlDataAdapter();
    SqlConnection con;
    DataSet ds = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            KonfigurirajAdapter();
            NapuniDataSet();
            PrikaziDrzave();
        }
    }

    private void PrikaziDrzave()
    {
        ddlDrzave.Items.Clear();
        ddlDrzave.AppendDataBoundItems = true;
        ddlDrzave.Items.Add(new ListItem("--- ODABERI DRZAVU ---", "0"));
        ddlDrzave.DataSource = VratiDrzave();
        ddlDrzave.DataTextField = "Naziv";
        ddlDrzave.DataValueField = "IDDrzava";
        ddlDrzave.DataBind();
    }

    private List<Drzava> VratiDrzave()
    {
        List<Drzava> drzave = new List<Drzava>();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            Drzava temp = new Drzava();
            temp.IDDrzava = (int)row["IDDrzava"];
            temp.Naziv = row["Naziv"].ToString();

            drzave.Add(temp);
        }

        return drzave;
    }

    private void NapuniDataSet()
    {
        adapter.Fill(ds);
    }

    private void KonfigurirajAdapter()
    {
        con = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);

        adapter.SelectCommand = con.CreateCommand();
        adapter.SelectCommand.CommandText = "SELECT * FROM Drzava; SELECT * FROM Grad";
        adapter.SelectCommand.CommandType = CommandType.Text;
    }

    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        KonfigurirajAdapter();
        NapuniDataSet();
        NapuniGradove();
    }

    private void NapuniGradove()
    {
        try
        {
            lbGradovi.AppendDataBoundItems = true;
            lbGradovi.DataSource = VratiGradove();
            lbGradovi.DataValueField = "IDGrad";
            lbGradovi.DataTextField = "Naziv";
            lbGradovi.DataBind();
        }
        catch (Exception ex)
        {
            lblInfo.Text = ex.Message;
        }
    }

    private List<Grad> VratiGradove()
    {
        List<Grad> gradovi = new List<Grad>();

        foreach (DataRow row in ds.Tables[1].Rows)
        {
            if (row["DrzavaID"].ToString() == ddlDrzave.SelectedValue)
            {
                Grad temp = new Grad();
                temp.DrzavaID = (int)row["DrzavaID"];
                temp.IDGrad = (int)row["IDGrad"];
                temp.Naziv = row["Naziv"].ToString();

                gradovi.Add(temp);
            }
        }

        return gradovi;
    }
}