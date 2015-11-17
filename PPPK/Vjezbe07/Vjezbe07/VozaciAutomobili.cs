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
    public partial class VozaciAutomobili : Form
    {
        private string cs { get { return ConfigurationManager.ConnectionStrings["cs"].ConnectionString; } }

        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection con;
        DataSet ds = new DataSet();

        DataTable dtVozac;
        DataTable dtBolid;

        public VozaciAutomobili()
        {
            InitializeComponent();
        }

        private void VozaciAutomobili_Load(object sender, EventArgs e)
        {
            ConfigureDataAdapter();
            FillDataSet();
            GetDrivers();
        }

        private void GetDrivers()
        {
            cbVozaci.DisplayMember = "PunoIme";

            foreach (DataRow row in dtVozac.Rows)
            {
                Vozac tempVozac = new Vozac();
                tempVozac.ID = (int)row["ID"];
                tempVozac.Ime = row["Ime"].ToString();
                tempVozac.Prezime = row["Prezime"].ToString();

                cbVozaci.Items.Add(tempVozac);
            }
            cbVozaci.SelectedIndex = 0;
        }

        private void FillDataSet()
        {
            adapter.Fill(ds);

            dtVozac = ds.Tables[0];
            dtVozac.TableName = "Vozac";
            dtBolid = ds.Tables[1];
            dtBolid.TableName = "Bolid";

            dtVozac.PrimaryKey = new DataColumn[] { dtVozac.Columns["ID"] };
            dtBolid.PrimaryKey = new DataColumn[] { dtBolid.Columns["ID"] };

            DataRelation relacija = new DataRelation("Relacija_VozacBolid", dtVozac.Columns["ID"], dtBolid.Columns["IDVozac"]);
            ds.Relations.Add(relacija);

            dtBolid.Columns["ID"].AutoIncrement = true;
            dtBolid.Columns["ID"].AutoIncrementSeed = 100;
            dtBolid.Columns["ID"].AutoIncrementStep = 1;
        }

        private void ConfigureDataAdapter()
        {
            con = new SqlConnection(cs);

            adapter.SelectCommand = con.CreateCommand();
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.CommandText = "DohvatiSveTablice";

            adapter.InsertCommand = con.CreateCommand();
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;
            adapter.InsertCommand.CommandText = "DodajBolid";

            SqlParameter paramIDVozac = new SqlParameter();
            paramIDVozac.ParameterName = "@IDVozac";
            paramIDVozac.SqlDbType = SqlDbType.Int;
            paramIDVozac.SourceColumn = "IDVozac";
            SqlParameter paramNaziv = new SqlParameter();
            paramNaziv.ParameterName = "@Naziv";
            paramNaziv.SqlDbType = SqlDbType.NVarChar;
            paramNaziv.SourceColumn = "Naziv";

            adapter.InsertCommand.Parameters.Add(paramIDVozac);
            adapter.InsertCommand.Parameters.Add(paramNaziv);

            adapter.UpdateCommand = con.CreateCommand();
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;
            adapter.UpdateCommand.CommandText = "UpdateBolid";

            SqlParameter paramUpdateID = new SqlParameter();
            paramUpdateID.ParameterName = "@ID";
            paramUpdateID.SqlDbType = SqlDbType.Int;
            paramUpdateID.SourceColumn = "ID";
            SqlParameter paramUpdateNaziv = new SqlParameter();
            paramUpdateNaziv.ParameterName = "@Naziv";
            paramUpdateNaziv.SqlDbType = SqlDbType.NVarChar;
            paramUpdateNaziv.SourceColumn = "Naziv";

            adapter.UpdateCommand.Parameters.Add(paramUpdateNaziv);
            adapter.UpdateCommand.Parameters.Add(paramUpdateID);

            adapter.DeleteCommand = con.CreateCommand();
            adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;
            adapter.DeleteCommand.CommandText = "BrisiBolid";

            SqlParameter paramDeleteID = new SqlParameter();
            paramDeleteID.ParameterName = "@ID";
            paramDeleteID.SqlDbType = SqlDbType.Int;
            paramDeleteID.SourceColumn = "ID";

            adapter.DeleteCommand.Parameters.Add(paramDeleteID);
        }

        private void cbVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowBolids();
        }

        private void ShowBolids()
        {
            Vozac tempVozac = (Vozac)cbVozaci.SelectedItem;

            lbBolidi.Items.Clear();

            DataRow[] rows = dtVozac.Rows.Find(tempVozac.ID).GetChildRows("Relacija_VozacBolid");

            foreach (DataRow row in rows)
            {
                Bolid b = new Bolid();
                b.ID = (int)row["ID"];
                b.IDVozac = (int)row["IDVozac"];
                b.Naziv = row["Naziv"].ToString();

                lbBolidi.Items.Add(b);
            }
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            NoviUredi temp = new NoviUredi(ds.Tables["Vozac"], null, cbVozaci.SelectedIndex);

            if (temp.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataRow noviRedBolid = dtBolid.NewRow();
                noviRedBolid["IDVozac"] = temp.IDVozac;
                noviRedBolid["Naziv"] = temp.Naziv;

                dtBolid.Rows.Add(noviRedBolid);

                ShowBolids();
            }
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            if (adapter.Update(dtBolid) > 0)
            {
                MessageBox.Show("Uspjesno spremljeno!!!");
            }
            else
            {
                MessageBox.Show("Niste unjeli nikakve promjene!");
            }
        }
    }
}
