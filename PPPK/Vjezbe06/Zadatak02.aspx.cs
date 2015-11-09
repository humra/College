using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zadatak02 : System.Web.UI.Page
{
    DataSet ds;

    protected void Page_Load(object sender, EventArgs e)
    {
        KreirajDataSet();
        UnesiPodatke();
        IspisiPodatke();
    }

    private void IspisiPodatke()
    {
        DataTable dtOsoba = ds.Tables["Osoba"];
        DataTable dtVozilo = ds.Tables["Vozilo"];
        lblIspis.Text = "";

        foreach (DataRow row in dtOsoba.Rows)
        {
            lblIspis.Text += "<b>" + row["Ime"].ToString() + " " + row["Prezime"].ToString() + "</b>";

            int osobaID = (int)row["IDOsoba"];
            DataRow[] vozilaOsobe = dtOsoba.Rows.Find(osobaID).GetChildRows("relacija");

            foreach (DataRow r in vozilaOsobe)
            {
                lblIspis.Text += "<br/>   - " + r["Naziv"].ToString();
            }
            lblIspis.Text += "<br/><br/>";
        }
    }

    private void UnesiPodatke()
    {
        DataTable dtOsoba = ds.Tables["Osoba"];

        DataRow r1 = dtOsoba.NewRow();
        r1["Ime"] = "Ana";
        r1["Prezime"] = "Anic";

        DataRow r2 = dtOsoba.NewRow();
        r2["Ime"] = "Marko";
        r2["Prezime"] = "Maric";

        DataRow r3 = dtOsoba.NewRow();
        r3["Ime"] = "Maja";
        r3["Prezime"] = "Majic";

        dtOsoba.Rows.Add(r1);
        dtOsoba.Rows.Add(r2);
        dtOsoba.Rows.Add(r3);

        DataTable dtVozilo = ds.Tables["Vozilo"];

        DataRow r4 = dtVozilo.NewRow();
        DataRow r5 = dtVozilo.NewRow();
        DataRow r6 = dtVozilo.NewRow();
        DataRow r7 = dtVozilo.NewRow();
        DataRow r8 = dtVozilo.NewRow();

        r4["Naziv"] = "Audi";
        r4["IDOsoba"] = 1;

        r5["Naziv"] = "VW";
        r5["IDOsoba"] = 1;

        r6["Naziv"] = "Mazda";
        r6["IDOsoba"] = 2;

        r7["Naziv"] = "Mazda";
        r7["IDOsoba"] = 2;

        r8["Naziv"] = "Honda";
        r8["IDOsoba"] = 3;

        dtVozilo.Rows.Add(r4);
        dtVozilo.Rows.Add(r5);
        dtVozilo.Rows.Add(r6);
        dtVozilo.Rows.Add(r7);
        dtVozilo.Rows.Add(r8);
    }

    private void KreirajDataSet()
    {
        ds = new DataSet("MojDB");

        DataTable dtOsoba = new DataTable("Osoba");

        DataColumn dcOsoba_IDOsoba = new DataColumn("IDOsoba", typeof(int));
        DataColumn dcOsoba_Ime = new DataColumn("Ime");
        DataColumn dcOsoba_Prezime = new DataColumn("Prezime");

        dcOsoba_IDOsoba.AutoIncrement = true;
        dcOsoba_IDOsoba.AutoIncrementSeed = 1;
        dcOsoba_IDOsoba.AutoIncrementStep = 1;
        dcOsoba_IDOsoba.AllowDBNull = false;
        dcOsoba_IDOsoba.Unique = true;

        dtOsoba.Columns.Add(dcOsoba_IDOsoba);
        dtOsoba.Columns.Add(dcOsoba_Ime);
        dtOsoba.Columns.Add(dcOsoba_Prezime);

        dtOsoba.PrimaryKey = new DataColumn[] { dcOsoba_IDOsoba };


        DataTable dtVozilo = new DataTable("Vozilo");

        DataColumn dcVozilo_IDVozilo = new DataColumn("IDVozilo", typeof(int));
        DataColumn dcVozilo_IDOsoba = new DataColumn("IDOsoba", typeof(int));
        DataColumn dcVozilo_Naziv = new DataColumn("Naziv");

        dcVozilo_IDVozilo.Unique = true;
        dcVozilo_IDVozilo.AllowDBNull = false;
        dcVozilo_IDVozilo.AutoIncrement = true;
        dcVozilo_IDVozilo.AutoIncrementSeed = 1;
        dcVozilo_IDVozilo.AutoIncrementStep = 1;

        dtVozilo.Columns.Add(dcVozilo_IDVozilo);
        dtVozilo.Columns.Add(dcVozilo_IDOsoba);
        dtVozilo.Columns.Add(dcVozilo_Naziv);

        dtVozilo.PrimaryKey = new DataColumn[] { dcVozilo_IDVozilo };

        ds.Tables.Add(dtVozilo);
        ds.Tables.Add(dtOsoba);

        DataRelation rel = new DataRelation("Relacija", dcOsoba_IDOsoba, dcVozilo_IDOsoba);
        rel.Nested = true;

        ds.Relations.Add(rel);
    }
}