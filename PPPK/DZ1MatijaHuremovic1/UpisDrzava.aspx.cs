using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpisDrzava : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnDodaj_Click(object sender, EventArgs e)
    {
        string naziv = txtNaziv.Text;

        if (naziv != "")
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "DodajDrzavu";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p = new SqlParameter();
                    p.ParameterName = "@Naziv";
                    p.Value = naziv;
                    p.SqlDbType = System.Data.SqlDbType.NVarChar;

                    cmd.Parameters.Add(p);

                    int counter = cmd.ExecuteNonQuery();

                    lblInfo.Text = counter + " rows affected";
                }
            }

            txtNaziv.Text = "";
        }
        else
        {
            lblInfo.Text = "Morate unjeti ime drzave!";
        }
    }
}