using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02 : System.Web.UI.Page
{
    private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DodajOpcijeSortiranja();
            PrikaziDrzave();
            PrikaziGradoveDrzave();
        }
    }

    private void DodajOpcijeSortiranja()
    {
        ddlSortiranje.Items.Add(new ListItem("Abecedno", "1"));
        ddlSortiranje.Items.Add(new ListItem("Po broju stanovnika", "2"));
    }

    private void PrikaziGradoveDrzave()
    {
        blGradovi.Items.Clear();

        DataSet ds = new DataSet("DrzaveGradovi");
        vratiDataAdapter().Fill(ds);

        DataView dvGradovi = ds.Tables[1].DefaultView;
        if (ddlSortiranje.SelectedValue == "1")
        {
            dvGradovi.Sort = "Naziv";
        }
        else
        {
            dvGradovi.Sort = "BrStanovnika DESC";
        }

        foreach (DataRowView row in dvGradovi)
        {
            if (row["DrzavaID"].ToString().Equals(ddlDrzava.SelectedValue))
            {
                blGradovi.Items.Add(new ListItem(row["Naziv"].ToString() + " " + row["BrStanovnika"].ToString(), row["BrStanovnika"].ToString()));
            }
        }
    }

    private void PrikaziDrzave()
    {
        DataSet ds = new DataSet("DrzaveGradovi");
        vratiDataAdapter().Fill(ds);

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            ddlDrzava.Items.Add(new ListItem(row["Naziv"].ToString(), row["IDDrzava"].ToString()));
        }
    }

    private SqlDataAdapter vratiDataAdapter()
    {
        SqlConnection con = new SqlConnection(cs);
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Drzava; SELECT * FROM Grad", con);
        return adapter;
    }

    protected void ddlDrzava_SelectedIndexChanged(object sender, EventArgs e)
    {
        PrikaziGradoveDrzave();
    }

    protected void ddlSortiranje_SelectedIndexChanged(object sender, EventArgs e)
    {
        PrikaziGradoveDrzave();
    }
}