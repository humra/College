using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak01 : System.Web.UI.Page
{
    private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSpremiXML_Click(object sender, EventArgs e)
    {
        try
        {
            SpremiXML();
        }
        catch (Exception ex)
        {
            lblInfo.Text = ex.Message;
        }
    }

    private void SpremiXML()
    {
        SqlConnection con = new SqlConnection(cs);
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Drzava; SELECT * FROM Grad", con);

        DataSet ds = new DataSet("DrzaveGradovi");
        da.Fill(ds);

        ds.Tables[0].TableName = "Drzava";
        ds.Tables[1].TableName = "Grad";

        DataRelation rel = new DataRelation("Relacija", ds.Tables[0].Columns["IDDrzava"], ds.Tables[1].Columns["DrzavaID"]);
        rel.Nested = true;
        ds.Relations.Add(rel);

        ds.WriteXml("C:/Users/Matija/Documents/GitHub/Practice/PPPK/Vjezbe08/zadatak1.xml");
        lblInfo.Text = "XML zapisan";
    }

    protected void btnUcitaj_Click(object sender, EventArgs e)
    {
        DataSet ds = new DataSet();
        ds.ReadXml(MapPath("zadatak1.xml"));

        StringBuilder sb = new StringBuilder();

        foreach (DataRow rowDrzava in ds.Tables[0].Rows)
        {
            int IDDrzava = int.Parse(rowDrzava["IDDrzava"].ToString());
            sb.Append(rowDrzava["Naziv"].ToString() + "<br/>");

            foreach(DataRow rowGrad in ds.Tables[1].Rows) 
            {
                int DrzavaID = int.Parse(rowGrad["DrzavaID"].ToString());
                if (DrzavaID == IDDrzava)
                {
                    sb.Append(rowGrad["Naziv"].ToString() + " ");
                }
            }
            sb.Append("<br/><br/>");
        }

        lblPodaci.Text = sb.ToString();
    }
}