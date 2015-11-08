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
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

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
            ddlDrzave.DataValueField = "IDDrzava";
            ddlDrzave.DataTextField = "Naziv";
            ddlDrzave.DataBind();
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

    private List<Drzava> vratiDrzave()
    {
        List<Drzava> drzave = new List<Drzava>();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Drzava";
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            drzave.Add(new Drzava { IDDrzava = (int)r["IDDrzava"], Naziv = r["Naziv"].ToString() });
                        }
                    }
                }
            }
        }

        return drzave;
    }

    protected void ddlDrzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        unesiGradove();
        btnBrisiDrzavu.Visible = true;
        btnDodajGrad.Visible = true;
    }

    private void unesiGradove()
    {
        string idDrzava = ddlDrzave.SelectedValue;
        lbGradovi.Items.Clear();

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Grad WHERE IDDrzava = " + idDrzava;
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            lbGradovi.Items.Add(new ListItem(r["Naziv"].ToString(), r["IDGrad"].ToString()));
                        }
                    }
                }
            }
        }
    }

    protected void lbGradovi_SelectedIndexChanged(object sender, EventArgs e)
    {
        btnBrisiGrad.Visible = true;
        btnUrediGrad.Visible = true;
    }

    protected void btnBrisiDrzavu_Click(object sender, EventArgs e)
    {
        obrisiGradoveDrzave();
        obrisiDrzavu();
    }

    private void obrisiGradoveDrzave()
    {
        string id = ddlDrzave.SelectedValue;

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Grad WHERE IDDrzava = " + id;
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.ExecuteNonQuery();
            }
        }
    }

    private void obrisiDrzavu()
    {
        string naziv = ddlDrzave.SelectedItem.Text;

        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Drzava WHERE Naziv = '" + naziv + "'";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.ExecuteNonQuery();
            }
        }

        napuniDdlDrzave();
    }

    protected void btnDodajGrad_Click(object sender, EventArgs e)
    {
        dodajNoviGrad();
    }

    private void dodajNoviGrad()
    {
        if (txtGrad.Text != "")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = "INSERT INTO Grad (Naziv, IDDrzava) VALUES ('" + txtGrad.Text + "', " + ddlDrzave.SelectedValue + ")";
                    cmd.ExecuteNonQuery();
                }
            }
            unesiGradove();
            txtGrad.Text = "";
        }
        else
        {
            lblInfo.Text = "Morate unjeti naziv grada!";
        }
    }

    protected void btnBrisiGrad_Click(object sender, EventArgs e)
    {
        obrisiGrad();
    }

    private void obrisiGrad()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM Grad WHERE Naziv = '" + lbGradovi.SelectedItem.Text + "'";
                cmd.CommandType = System.Data.CommandType.Text;

                cmd.ExecuteNonQuery();
            }
        }

        unesiGradove();
        txtGrad.Text = "";
    }

    protected void btnUrediGrad_Click(object sender, EventArgs e)
    {
        urediGrad();
    }

    private void urediGrad()
    {
        if (txtGrad.Text != "")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Grad SET Naziv = '" + txtGrad.Text + "' WHERE Naziv = '" + lbGradovi.SelectedItem.Text + "'";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.ExecuteNonQuery();
                }
            }

            unesiGradove();
            txtGrad.Text = "";
        }
        else
        {
            lblInfo.Text = "Morate unjeti ime grada!";
        }
    }
}