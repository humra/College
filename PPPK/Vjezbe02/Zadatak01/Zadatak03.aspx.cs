using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak03 : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["PPPK"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            napuniDrzave();
        }
    }

    private void napuniDrzave()
    {
        ddlDrzave.Items.Clear();

        try
        {
            ddlDrzave.AppendDataBoundItems = true;
            ddlDrzave.Items.Insert(0, new ListItem("--- Odaberi drzavu ---", "0"));
            ddlDrzave.DataSource = dohvatiDrzave();
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

    private List<Drzava> dohvatiDrzave()
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
                            drzave.Add(new Drzava
                            {
                                IDDrzava = (int)rdr["IDDrzava"],
                                Naziv = rdr["Naziv"].ToString()
                            });
                        }
                    }
                }
            }
        }

        return drzave;
    }

    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        prikaziOdabranuDrzavu();
        prikaziGradoveDrzave();
        lblInfo.Text = "";
    }

    private void prikaziGradoveDrzave()
    {
        try
        {
            lbGradovi.DataSource = dohvatiGradove();
            lbGradovi.DataValueField = "IDGrad";
            lbGradovi.DataTextField = "Naziv";
            lbGradovi.DataBind();
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

    private List<Grad> dohvatiGradove()
    {
        List<Grad> gradovi = new List<Grad>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Grad WHERE DrzavaID = " + ddlDrzave.SelectedValue;
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            gradovi.Add(new Grad
                            {
                                DrzavaID = (int)r["DrzavaID"],
                                IDGrad = (int)r["IDGrad"],
                                Naziv = r["Naziv"].ToString()
                            });
                        }
                    }
                }
            }
        }

        return gradovi;
    }

    private void prikaziOdabranuDrzavu()
    {
        if (ddlDrzave.SelectedValue != "0")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Grad WHERE DrzavaID = " + ddlDrzave.SelectedValue;
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.HasRows)
                        {
                            while (r.Read())
                            {
                                txtDrzava.Text = r["Naziv"].ToString();
                            }
                        }
                    }
                }
            }
        }
        else
        {
            txtDrzava.Text = "";
        }
    }

    protected void lbGradovi_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtGrad.Text = lbGradovi.SelectedItem.Text;
    }

    protected void btnUrediDrzava_Click(object sender, EventArgs e)
    {
        urediDrzavu();
    }

    private void urediDrzavu()
    {
        int index = ddlDrzave.SelectedIndex;

        if (txtDrzava.Text != "" && ddlDrzave.SelectedValue != "0")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Drzava SET Naziv = '" + txtDrzava.Text + "' WHERE IDDrzava = " + ddlDrzave.SelectedValue;
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        lblInfo.Text = "Uspjesno izvrsena naredba";
                    }
                    else
                    {
                        lblInfo.Text = "Naredba se nije izvrsila";
                    }
                }
            }

            txtDrzava.Text = "";
            napuniDrzave();
            ddlDrzave.SelectedIndex = index;
            prikaziGradoveDrzave();
        }
        else
        {
            lblInfo.Text = "Niste upisali naziv drzave!";
        }
    }

    protected void btnObrisiDrzava_Click(object sender, EventArgs e)
    {
        obrisiOdabranuDrzavu();
    }

    private void obrisiOdabranuDrzavu()
    {
        int index = ddlDrzave.SelectedIndex;

        if (ddlDrzave.SelectedValue != "0")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Drzava WHERE Naziv = '" + txtDrzava.Text + "'";
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        lblInfo.Text = "Naredba uspjesno izvedena";
                    }
                    else
                    {
                        lblInfo.Text = "Naredba se nije izvela";
                    }
                }
            }
            txtDrzava.Text = "";
            napuniDrzave();
        }
        else
        {
            lblInfo.Text = "Niste upisali naziv drzave";
        }
    }

    protected void btnDodajGrad_Click(object sender, EventArgs e)
    {
        dodajNoviGrad();
    }

    private void dodajNoviGrad()
    {
        if (txtGrad.Text != "")
        {
            string naziv = txtGrad.Text;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Grad (Naziv, DrzavaID) VALUES ('" + naziv + "', " + ddlDrzave.SelectedValue + ")";
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        lblInfo.Text = "Uspjesno izvrsena naredba";
                    }
                    else
                    {
                        lblInfo.Text = "Naredba se nije izvrsila";
                    }
                }
            }
            txtGrad.Text = "";
        }
        else
        {
            lblInfo.Text = "Niste upisali ime grada";
        }
    }

    protected void btnObrisiGrad_Click(object sender, EventArgs e)
    {
        izbrisiGrad();
    }

    private void izbrisiGrad()
    {
        if (txtGrad.Text != "")
        {
            string naziv = txtGrad.Text;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Grad WHERE Naziv = '" + naziv + "'";
                    cmd.CommandType = System.Data.CommandType.Text;

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        lblInfo.Text = "Uspjesno izvrsena naredba";
                    }
                    else
                    {
                        lblInfo.Text = "Naredba se nije izvrsila";
                    }
                }
            }
        }
        else
        {
            lblInfo.Text = "Niste unjeli naziv grada";
        }
    }
}