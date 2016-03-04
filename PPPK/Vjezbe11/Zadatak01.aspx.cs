using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
            napuniGridView();
        }
    }

    private void napuniGridView()
    {
        DataTable dtPodaci = new DataTable();

        try
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DohvatiSveOsobe";
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            dtPodaci.Load(r);
                            gvPodaci.DataSource = dtPodaci;
                            gvPodaci.DataBind();
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            lblInfo.Text = ex.Message;
        }
    }
    protected void gvPodaci_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        dvOsoba.DataSource = vratiDetaljeOsobe(e.NewSelectedIndex);
        dvOsoba.DataBind();
    }

    private DataTable vratiDetaljeOsobe(int p)
    {
        DataTable dt = new DataTable();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DohvatiOsobu";
                cmd.Parameters.AddWithValue("@id", p);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        dt.Load(r);
                    }
                }
            }
        }

        return dt;
    }

    protected void gvPodaci_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        gvPodaci.PageIndex = e.NewPageIndex;
        napuniGridView();
    }
}