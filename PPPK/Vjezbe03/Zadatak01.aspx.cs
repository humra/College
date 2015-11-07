using System;
using System.Activities.Statements;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01 : System.Web.UI.Page
{
    private string cs = ConfigurationManager.ConnectionStrings["PPPK"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            napuniDdlDrzave();
        }
    }

    private void napuniDdlDrzave()
    {
        try
        {
            ddlDrzave.Items.Clear();
            ddlDrzave.AppendDataBoundItems = true;
            ddlDrzave.Items.Add(new ListItem("--- Odaberi drzavu ---", "0"));
            ddlDrzave.DataSource = vratiDrzave();
            ddlDrzave.DataTextField = "Naziv";
            ddlDrzave.DataValueField = "IDDrzava";
            ddlDrzave.DataBind();
        }
        catch (SqlException e)
        {
            lblInfo.Text = e.Message;
        }
        catch (Exception e)
        {
            lblInfo.Text = e.Message;
        }
    }

    private List<Drzava> vratiDrzave()
    {
        List<Drzava> drzave = new List<Drzava>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DohvatiDrzave";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            drzave.Add(new Drzava { IDDrzava = (int)r["IDDrzava"],
                                 Naziv = r["Naziv"].ToString() });
                        }
                    }
                }
            }
        }

        return drzave;
    }

    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            blGradoviDrzave.AppendDataBoundItems = false;
            blGradoviDrzave.DataSource = vratiGradoveZadaneDrzave();
            blGradoviDrzave.DataValueField = "IDGrad";
            blGradoviDrzave.DataTextField = "Naziv";
            blGradoviDrzave.DataBind();
        }
        catch (SqlException ex)
        {
            lblInfo.Text = ex.Message;
        }
        catch (Exception ex)
        {
            lblInfo.Text = ex.Message;
        }
    }

    private List<Grad> vratiGradoveZadaneDrzave()
    {
        List<Grad> gradovi = new List<Grad>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DohvatiGradove";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter();
                p.SqlDbType = System.Data.SqlDbType.Int;
                p.ParameterName = "@DrzavaID";
                p.Value = ddlDrzave.SelectedValue;

                cmd.Parameters.Add(p);

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            gradovi.Add(new Grad
                            {
                                Naziv = r["Naziv"].ToString(),
                                DrzavaID = (int)r["DrzavaID"],
                                IDGrad = (int)r["IDGrad"]
                            });
                        }
                    }
                }
            }
        }

        return gradovi;
    }

    protected void btnDodajGrad_Click(object sender, EventArgs e)
    {
        string nazivGrada = txtGrad.Text;

        if (nazivGrada != "")
        {
            blGradoviZaDodati.Items.Add(new ListItem(nazivGrada));

            lblInfo.Text = "";
            txtGrad.Text = "";
        }
        else
        {
            lblInfo.Text = "Morate unjeti ime grada i drzave!";
        }
    }

    protected void btnSpremiUBazu_Click(object sender, EventArgs e)
    {
        if (txtDrzava.Text == "" || blGradoviZaDodati.Items.Count < 1)
        {
            lblInfo.Text = "Morate unjeti naziv drzave i barem jedan grad!";
        }
        else
        {
            unesiNovuDrzavuGradove();
        }
    }

    private void unesiNovuDrzavuGradove()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            SqlCommand cmdDrzava = con.CreateCommand();
            SqlCommand cmdGradovi = con.CreateCommand();

            int idDrzave = 0;

            using (cmdDrzava)
            {
                cmdDrzava.CommandType = System.Data.CommandType.StoredProcedure;
                cmdDrzava.CommandText = "UnesiDrzavu";

                SqlParameter p = new SqlParameter();
                p.Value = txtDrzava.Text;
                p.SqlDbType = System.Data.SqlDbType.NVarChar;
                p.ParameterName = "@Naziv";

                cmdDrzava.Parameters.Add(p);

                cmdDrzava.ExecuteNonQuery();
            }

            using (cmdGradovi)
            {
                using (SqlCommand cmdDrzavaID = con.CreateCommand())
                {
                    cmdDrzavaID.CommandType = System.Data.CommandType.Text;
                    cmdDrzavaID.CommandText = "SELECT Drzava.IDDrzava FROM Drzava WHERE Naziv = '" + txtDrzava.Text + "'";

                    using (SqlDataReader r = cmdDrzavaID.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                idDrzave = (int)r["IDDrzava"];
                            }
                        }
                    }

                    foreach (ListItem li in blGradoviZaDodati.Items)
                    {
                        cmdGradovi.Parameters.Clear();
                        cmdGradovi.CommandText = "UnesiGrad";
                        cmdGradovi.CommandType = System.Data.CommandType.StoredProcedure;

                        SqlParameter pNaziv = new SqlParameter();
                        pNaziv.ParameterName = "@Naziv";
                        pNaziv.Value = li.Text;
                        pNaziv.SqlDbType = System.Data.SqlDbType.NVarChar;

                        SqlParameter pDrzavaID = new SqlParameter();
                        pDrzavaID.Value = idDrzave;
                        pDrzavaID.SqlDbType = System.Data.SqlDbType.Int;
                        pDrzavaID.ParameterName = "@DrzavaID";

                        cmdGradovi.Parameters.Add(pNaziv);
                        cmdGradovi.Parameters.Add(pDrzavaID);

                        cmdGradovi.ExecuteNonQuery();
                    }
                }
            }
        }

        txtDrzava.Text = "";
        txtGrad.Text = "";
        blGradoviZaDodati.Items.Clear();
        lblInfo.Text = "";
        napuniDdlDrzave();
    }
}