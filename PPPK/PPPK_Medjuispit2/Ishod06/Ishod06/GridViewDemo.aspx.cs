using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ishod06
{
    public partial class GridViewDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;

            using (SqlConnection con = new SqlConnection("Data Source=SARUMAN\\SQLEXPRESS;Initial Catalog=GridViewExample;Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Osoba (Ime, Prezime) VALUES ('" + ime + "', '" + prezime + "')";
                    cmd.CommandType = System.Data.CommandType.Text;

                    cmd.ExecuteNonQuery();
                }
            }

            gvGrid.DataBind();
        }
    }
}