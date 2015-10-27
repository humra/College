using System;
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
            napuniDdlDrzava();
        }
    }

    private void napuniDdlDrzava()
    {
        try
        {
            ddlDrzave.AppendDataBoundItems = true;
            ddlDrzave.Items.Insert(0, new ListItem("ODABERI DRZAVU", "0"));
            ddlDrzave.DataSource = dohvatiListuDrzavaProc();
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

    private List<Drzava> dohvatiListuDrzavaProc()
    {
        List<Drzava> drzave = new List<Drzava>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DohvatiDrzave";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            drzave.Add(new Drzava { IDDrzava = (int)rdr["IDDrzava"], Naziv = rdr["Naziv"].ToString() });
                        }
                    }
                }
            }
        }

        return drzave;
    }

    private List<Drzava> dohvatiListuDrzava()
    {
        List<Drzava> drzave = new List<Drzava>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Drzava";
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            drzave.Add(new Drzava { Naziv = rdr["Naziv"].ToString(), IDDrzava = (int)rdr["IDDrzava"] });
                        }
                    }
                }
            }
        }

        return drzave;
    }

    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        prikaziDrzavu();
    }

    private void prikaziDrzavu()
    {
        try
        {
            blGradovi.DataSource = odabreiGradoveDrzaveProc();
            blGradovi.DataTextField = "Naziv";
            blGradovi.DataValueField = "IDGrad";
            blGradovi.DataBind();
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

    private List<Grad> odabreiGradoveDrzaveProc()
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
                p.Value = ddlDrzave.SelectedValue;
                p.SqlDbType = System.Data.SqlDbType.Int;
                p.ParameterName = "@DrzavaID";

                cmd.Parameters.Add(p);

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            gradovi.Add(new Grad { DrzavaID = (int)rdr["DrzavaID"], IDGrad = (int)rdr["IDGrad"], Naziv = rdr["Naziv"].ToString() });
                        }
                    }
                }
            }
        }

        return gradovi;
    }

    private List<Grad> odabreiGradoveDrzave()
    {
        List<Grad> gradovi = new List<Grad>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Grad WHERE DrzavaID=" + ddlDrzave.SelectedValue;
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            gradovi.Add(new Grad
                            {
                                DrzavaID = (int)rdr["DrzavaID"],
                                Naziv = rdr["Naziv"].ToString(),
                                IDGrad = (int)rdr["IDGrad"]
                            });
                        }
                    }
                }
            }
        }

        return gradovi;
    }
}