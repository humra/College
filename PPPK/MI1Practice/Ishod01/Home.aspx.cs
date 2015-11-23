using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Home : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        PrvihDesetOsoba();
    }

    private void PrvihDesetOsoba()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT TOP 10 Ime, Prezime FROM Kupac";
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            lbPrvihDeset.Items.Add(r["Ime"].ToString() + " " + r["Prezime"].ToString());
                        }
                    }
                }
            }
        }
    }

    protected void btnPrikaziDetalje_Click(object sender, EventArgs e)
    {
        lblInfo.Text = "";

        if (txtIdOsobe.Text != "")
        {
            try
            {
                int idOsoba;
                int.TryParse(txtIdOsobe.Text, out idOsoba);

                UcitajDetaljeOsobe(idOsoba);
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }
        else
        {
            lblInfo.Text = "Morate unjeti ID osobe!";
        }
    }

    private void UcitajDetaljeOsobe(int idOsoba)
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM Kupac WHERE IDKupac = " + idOsoba;
                cmd.CommandType = System.Data.CommandType.Text;

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (r.HasRows)
                    {
                        while (r.Read())
                        {
                            Osoba temp = new Osoba();
                            temp.Ime = r["Ime"].ToString();
                            temp.Prezime = r["Prezime"].ToString();
                            temp.Email = r["Email"].ToString();
                            temp.Telefon = r["Telefon"].ToString();

                            lblDetalji.Text = temp.ToString();
                        }
                    }
                }
            }
        }
    }
}