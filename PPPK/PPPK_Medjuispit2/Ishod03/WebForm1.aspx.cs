using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ishod03
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private String cs = @"Server=.\SQLEXPRESS;Integrated security=true;Initial catalog=AdventureWorksOBP";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                napuniDrzave();
            }
        }

        private void napuniDrzave()
        {
            DataSet ds = new DataSet();
            drzavaAdapter().Fill(ds);

            lbDrzava.Items.Clear();
            lbDrzava.DataSource = ds.Tables[0];
            lbDrzava.DataTextField = "Naziv";
            lbDrzava.DataValueField = "IDDrzava";
            lbDrzava.DataBind();

            lbDrzava.SelectedIndex = 0;
            prikaziGradove();
        }

        private SqlDataAdapter drzavaAdapter()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Drzava", cs);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            return da;
        }

        protected void lbDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikaziGradove();
        }

        private void prikaziGradove()
        {
            DataSet ds = new DataSet();
            gradoviAdapter().Fill(ds);

            lbGrad.Items.Clear();
            lbGrad.DataSource = ds.Tables[0];
            lbGrad.DataValueField = "IDGrad";
            lbGrad.DataTextField = "Naziv";
            lbGrad.DataBind();


        }

        private SqlDataAdapter gradoviAdapter()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Grad WHERE DrzavaID = " + lbDrzava.SelectedValue, cs);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            return da;
        }
    }
}