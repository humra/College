using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PopisDrzava : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            napuniDrzave();
        }
    }

    private void napuniDrzave()
    {
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
                            lbDrzave.Items.Add(new ListItem(r["Naziv"].ToString(), r["IDDrzava"].ToString()));
                        }
                    }
                }
            }
        }
    }

    protected void btnBrisi_Click(object sender, EventArgs e)
    {
        using(SqlConnection con = new SqlConnection(cs)) 
        {
            con.Open();

            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter p = new SqlParameter();
                p.SqlDbType = System.Data.SqlDbType.NVarChar;
                p.ParameterName = "@Naziv";

                int counter = 0;

                foreach (ListItem l in lbDrzave.Items)
                {
                    if (l.Selected)
                    {
                        cmd.CommandText = "BrisiDrzavu";
                        p.Value = l.Text;
                        cmd.Parameters.Add(p);
                        counter += cmd.ExecuteNonQuery();
                    }
                }

                lblInfo.Text = counter + " rows affected";
            }
        }

        lbDrzave.Items.Clear();
        napuniDrzave();
    }
}