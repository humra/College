using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe07
{
    public partial class Popis : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataTable dtVozac;
        DataTable dtBolid;
        SqlConnection con;

        public Popis()
        {
            InitializeComponent();
        }

        private void Popis_Load(object sender, EventArgs e)
        {
            KonfigurirajDataAdapter();
            PuniDataSet();
            NadjiVozace();
        }

        private void NadjiVozace()
        {
            foreach (DataRow dr in ds.Tables["Vozac"].Rows)
            {
                Vozac temp = new Vozac();

                temp.ID = (int)dr["ID"];
                temp.Ime = dr["Ime"].ToString();
                temp.Prezime = dr["Prezime"].ToString();

                cbVozac.Items.Add(temp);
            }
            cbVozac.SelectedIndex = 0;
        }

        private void PuniDataSet()
        {
            da.Fill(ds);
            dtVozac = ds.Tables[0];
            dtVozac.TableName = "Vozac";
            dtBolid = ds.Tables[1];
            dtBolid.TableName = "Bolid";

            dtVozac.PrimaryKey = new DataColumn[] { dtVozac.Columns["ID"] };
            dtBolid.PrimaryKey = new DataColumn[] { dtBolid.Columns["ID"] };

            DataRelation rel = new DataRelation("Relacija", dtVozac.Columns["ID"], dtBolid.Columns["IDVozac"]);
            ds.Relations.Add(rel);

            dtBolid.Columns["ID"].AutoIncrement = true;
            dtBolid.Columns["ID"].AutoIncrementSeed = 100;
            dtBolid.Columns["ID"].AutoIncrementStep = 1;
        }

        private void KonfigurirajDataAdapter()
        {
            con = new SqlConnection(cs);
            da = new SqlDataAdapter();

            da.SelectCommand = con.CreateCommand();
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = "DohvatiSveTablice";

            da.InsertCommand = con.CreateCommand();
            da.InsertCommand.CommandType = CommandType.StoredProcedure;
            da.InsertCommand.CommandText = "DodajBolid";

            SqlParameter paramInsertIDVozac = new SqlParameter("@IDVozac", SqlDbType.Int);
            paramInsertIDVozac.SourceColumn = "IDVozac";
            SqlParameter paramInsertNaziv = new SqlParameter("@Naziv", SqlDbType.NVarChar);
            paramInsertNaziv.SourceColumn = "Naziv";

            da.InsertCommand.Parameters.Add(paramInsertIDVozac);
            da.InsertCommand.Parameters.Add(paramInsertNaziv);

            da.UpdateCommand = con.CreateCommand();
            da.UpdateCommand.CommandType = CommandType.StoredProcedure;
            da.UpdateCommand.CommandText = "UpdateBolid";

            SqlParameter paramUpdateID = new SqlParameter("@ID", SqlDbType.Int);
            paramUpdateID.SourceColumn = "IDBolid";
            SqlParameter paramUpdateNaziv = new SqlParameter("@Naziv", SqlDbType.NVarChar);
            paramUpdateNaziv.SourceColumn = "Naziv";

            da.UpdateCommand.Parameters.Add(paramUpdateID);
            da.UpdateCommand.Parameters.Add(paramUpdateNaziv);

            da.DeleteCommand = con.CreateCommand();
            da.DeleteCommand.CommandType = CommandType.StoredProcedure;
            da.DeleteCommand.CommandText = "BrisiBolid";

            SqlParameter paramDeleteID = new SqlParameter("@ID", SqlDbType.Int);
            paramDeleteID.SourceColumn = "IDBolid";

            da.DeleteCommand.Parameters.Add(paramDeleteID);
        }

        private void cbVozac_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vozac temp = (Vozac)cbVozac.SelectedItem;
            PrikaziBolideVozaca(temp);
        }

        private void PrikaziBolideVozaca(Vozac temp)
        {
            lbBolidi.Items.Clear();
            DataRow[] rowVozacaVozila = dtVozac.Rows.Find(temp.ID).GetChildRows("Relacija");

            foreach (DataRow r in rowVozacaVozila)
            {
                Bolid b = new Bolid();
                b.ID = (int)r["ID"];
                b.IDVozac = (int)r["IDVozac"];
                b.Naziv = r["Naziv"].ToString();

                lbBolidi.Items.Add(b);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            DodajUredi tempForma = new DodajUredi(ds.Tables["Vozac"], null, cbVozac.SelectedIndex);

            if (tempForma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow bolidNoviRedak = dtBolid.NewRow();
                bolidNoviRedak["IDVozac"] = tempForma.IDVozaca;
                bolidNoviRedak["Naziv"] = tempForma.naziv;

                dtBolid.Rows.Add(bolidNoviRedak);

                PrikaziBolideVozaca((Vozac)cbVozac.SelectedItem);
            }
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lbBolidi.SelectedIndex != -1)
            {
                int indexVozaca = cbVozac.SelectedIndex;
                DodajUredi tempForma = new DodajUredi(ds.Tables["Vozac"], lbBolidi.SelectedItem.ToString(), indexVozaca);

                if (tempForma.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    int idBolid = ((Bolid)lbBolidi.SelectedItem).ID;

                    DataRow redZaUrediti = dtBolid.Rows.Find(idBolid);
                    redZaUrediti["Naziv"] = tempForma.naziv;
                    redZaUrediti["IDVozac"] = tempForma.IDVozaca;

                    PrikaziBolideVozaca((Vozac)cbVozac.SelectedItem);
                }
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            int idBolid = ((Bolid)lbBolidi.SelectedItem).ID;

            DataRow redZaBrisati = (DataRow)dtBolid.Rows.Find(idBolid);
            redZaBrisati.Delete();

            PrikaziBolideVozaca((Vozac)cbVozac.SelectedItem);
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (da.Update(dtBolid) > 0)
            {
                MessageBox.Show("Podaci uspješno spremljeni u bazu!", "Obavijest", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Nije bilo nikakvih promjena!", "Obavijest", MessageBoxButtons.OK);
            }
        }
    }
}
