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
    public partial class Automobili : Form
    {
        private string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        private DataSet ds;
        private DataTable dtAutomobil;
        SqlDataAdapter da;
        SqlConnection cn;

        public Automobili()
        {
            InitializeComponent();
        }

        private void KonfigurirajAdapter()
        {
            cn = new SqlConnection(cs);
            da = new SqlDataAdapter("select * from Automobil", cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.RowUpdated += new SqlRowUpdatedEventHandler(da_RowUpdated);
        }

        private void NapuniDS()
        {
            ds = new System.Data.DataSet();
            da.Fill(ds);
            dtAutomobil = ds.Tables[0];
            dtAutomobil.PrimaryKey = new System.Data.DataColumn[] { dtAutomobil.Columns["IDAutomobil"] };
            dtAutomobil.Columns["IDAutomobil"].AutoIncrement = true;
            dtAutomobil.Columns["IDAutomobil"].AutoIncrementSeed = IDSeed();
            dtAutomobil.Columns["IDAutomobil"].AutoIncrementStep = 1;

            dtAutomobil.ColumnChanging += new System.Data.DataColumnChangeEventHandler(dtAutomobil_ColumnChanging);
        }

        private int IDSeed()
        {
            List<int> kolekcijaID = new List<int>();
            foreach (DataRow row in dtAutomobil.Rows)
            {
                kolekcijaID.Add((int)row["IDAutomobil"]);
            }
            int maxID = kolekcijaID.Max();
            return maxID + 1;
        }

        private void PrikaziAutomobile()
        {
            ResetForm();
            cbAutomobili.Items.Clear();

            foreach (DataRow row in dtAutomobil.Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Automobil a = new Automobil();
                    a.IDAutomobil = (int)row["IDAutomobil"];
                    a.Proizvodjac = row["Proizvodjac"].ToString();
                    a.Tip = row["Tip"].ToString();
                    a.GodinaProizvodnje = (short)row["Godina"];

                    if (row.IsNull("KS"))
                        a.Snaga = 0;
                    else
                        a.Snaga = (short)row["KS"];

                    cbAutomobili.Items.Add(a);
                }
            }
            cbAutomobili.SelectedIndex = 0;
        }

        private void ResetForm()
        {
            txtGodinaProizvodnje.Text = "";
            txtProizvodjac.Text = "";
            txtSnaga.Text = "";
            txtTip.Text = "";
        }

        void dtAutomobil_ColumnChanging(object sender, System.Data.DataColumnChangeEventArgs e)
        {
            if (e.Column.ColumnName == "Godina")
            {
                short novaGodina = (short)e.ProposedValue;
                if (novaGodina > DateTime.Now.Year)
                {
                    throw new Exception("Godina nije u dobrom rasponu!!!");
                }
            }
        }

        void da_RowUpdated(object sender, SqlRowUpdatedEventArgs e)
        {
            if (e.Status == System.Data.UpdateStatus.ErrorsOccurred && e.Errors.GetType() == typeof(DBConcurrencyException))
            {
                DataSet dsKonfliktni = new System.Data.DataSet();

                SqlDataAdapter daKonfliktni = new SqlDataAdapter("SELECT * FROM Automobil WHERE IDAutomobil = @ID", cn);
                daKonfliktni.SelectCommand.Parameters.AddWithValue("@ID", e.Row["IDAutomobil"]);

                int brojKonfliktnihRedaka = daKonfliktni.Fill(dsKonfliktni);

                if (brojKonfliktnihRedaka == 1)
                {
                    e.Row.RowError = "Automobil ID:" + e.Row["IDAutomobil"] + " je izmijenjen od strane drugog korisnika";
                    MessageBox.Show(e.Row.RowError + "\nForma će se refreshat podacima iz baze!");
                    StartApp();
                }
                else
                {
                    e.Row.RowError = "Redak je u međuvremenu izbrisan iz DB";

                    if (MessageBox.Show("Dodati kao novi redak u bazu?", "OBAVIJEST", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        e.Row.AcceptChanges();
                        e.Row.SetAdded();
                        e.Row.RowError = "";
                        da.Update(new System.Data.DataRow[] { e.Row });
                    }
                    else
                        dtAutomobil.Rows.Remove(e.Row);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartApp();
        }

        private void StartApp()
        {
            KonfigurirajAdapter();
            NapuniDS();
            PrikaziAutomobile();
        }

        private void cbAutomobili_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziDetaljeOdabranogAutomobila();
        }

        private void PrikaziDetaljeOdabranogAutomobila()
        {
            Automobil a = (Automobil)cbAutomobili.SelectedItem;
            DataRow redakOdabranogAutomobila = dtAutomobil.Rows.Find(a.IDAutomobil);

            txtGodinaProizvodnje.Text = redakOdabranogAutomobila["Godina"].ToString();
            txtProizvodjac.Text = redakOdabranogAutomobila["Proizvodjac"].ToString();
            txtSnaga.Text = redakOdabranogAutomobila["KS"].ToString();
            txtTip.Text = redakOdabranogAutomobila["Tip"].ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAutomobil(cbAutomobili.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateAutomobil(int indexOdabranogAuta)
        {
            Automobil a = (Automobil)cbAutomobili.SelectedItem;
            DataRow row = dtAutomobil.Rows.Find(a.IDAutomobil);

            row["Proizvodjac"] = txtProizvodjac.Text;
            row["Tip"] = txtTip.Text;
            row["Godina"] = short.Parse(txtGodinaProizvodnje.Text);

            short ks;
            if (short.TryParse(txtSnaga.Text, out ks))
                row["KS"] = ks;
            else
                row["KS"] = DBNull.Value;

            PrikaziAutomobile();
            cbAutomobili.SelectedIndex = indexOdabranogAuta;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DeleteOdabraniAutomobil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteOdabraniAutomobil()
        {
            Automobil a = (Automobil)cbAutomobili.SelectedItem;
            DataRow row = dtAutomobil.Rows.Find(a.IDAutomobil);
            row.Delete();

            string proizvodjacOriginal = row["Proizvodjac", System.Data.DataRowVersion.Original].ToString();
            string tipOriginal = row["Tip", System.Data.DataRowVersion.Original].ToString();
            string godinaOriginal = row["Godina", System.Data.DataRowVersion.Original].ToString();
            string snagaOriginal = row["KS", System.Data.DataRowVersion.Original].ToString();

            MessageBox.Show(String.Format("Originalni podaci obrisanog retka:\n\nProizvođač: {0}\nTip: {1}\nGodina proizvodnje: {2}\nSnaga: {3}", proizvodjacOriginal, tipOriginal, godinaOriginal, snagaOriginal));

            ResetForm();
            PrikaziAutomobile();
            cbAutomobili.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDB()
        {
            da.Update(dtAutomobil);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                InsertNoviAutomobil();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertNoviAutomobil()
        {
            DataRow noviRedak = dtAutomobil.NewRow();
            noviRedak["Proizvodjac"] = txtProizvodjac.Text;
            noviRedak["Tip"] = txtTip.Text;
            noviRedak["Godina"] = short.Parse(txtGodinaProizvodnje.Text);

            short snaga;
            if (short.TryParse(txtSnaga.Text, out snaga))
                noviRedak["KS"] = snaga;
            else
                noviRedak["KS"] = DBNull.Value;

            dtAutomobil.Rows.Add(noviRedak);
            ResetForm();
            PrikaziAutomobile();
        }
    }
}
