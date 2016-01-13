using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe10
{
    public partial class Form1 : Form
    {
        private PPPKVjezbe10DataSet ds;
        private PPPKVjezbe10DataSetTableAdapters.DrzavaTableAdapter taDrzava;
        private PPPKVjezbe10DataSetTableAdapters.GradTableAdapter taGrad;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NapuniDataSet();
            PrikaziDrzave();
        }

        private void PrikaziDrzave()
        {
            lbDrzave.Items.Clear();
            lbDrzave.ValueMember = "IDDrzava";
            lbDrzave.DisplayMember = "Naziv";

            foreach (PPPKVjezbe10DataSet.DrzavaRow row in ds.Drzava.Rows)
            {
                lbDrzave.Items.Add(row);
            }

            if (lbDrzave.Items.Count > 0)
            {
                lbDrzave.SelectedIndex = 0;
            }
        }

        private void NapuniDataSet()
        {
            ds = new PPPKVjezbe10DataSet();
            taDrzava = new PPPKVjezbe10DataSetTableAdapters.DrzavaTableAdapter();
            taDrzava.Fill(ds.Drzava);
            taGrad = new PPPKVjezbe10DataSetTableAdapters.GradTableAdapter();
            taGrad.Fill(ds.Grad);
        }

        private void lbDrzave_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziGradoveOdabraneDrzave();
            txtDrzava.Text = ((PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem).Naziv;
        }

        private void PrikaziGradoveOdabraneDrzave()
        {
            lbGrad.Items.Clear();
            lbGrad.DisplayMember = "Naziv";
            lbGrad.ValueMember = "IDGrad";

            PPPKVjezbe10DataSet.DrzavaRow odabranaDrzava = (PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem;
            PPPKVjezbe10DataSet.GradRow[] gradoviDrzave = (PPPKVjezbe10DataSet.GradRow[])odabranaDrzava.GetChildRows(ds.Relations["relacija"]);

            foreach (PPPKVjezbe10DataSet.GradRow row in gradoviDrzave)
            {
                lbGrad.Items.Add(row);
            }

            if (lbGrad.Items.Count > 0)
            {
                lbGrad.SelectedIndex = 0;
            }
        }

        private void lbGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtGrad.Text = ((PPPKVjezbe10DataSet.GradRow)lbGrad.SelectedItem).Naziv;
        }

        private void btnDrzavaDodaj_Click(object sender, EventArgs e)
        {
            if (txtDrzava.Text.Equals(((PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem).Naziv))
            {
                lblInfo.Text = "Drzava vec postoji";
            }
            else
            {
                PPPKVjezbe10DataSet.DrzavaRow novaDrzava = ds.Drzava.NewDrzavaRow();
                novaDrzava.Naziv = txtDrzava.Text;
                ds.Drzava.Rows.Add(novaDrzava);

                UpdateDrzavaNaBazi();

                lblInfo.Text = "";
                PrikaziDrzave();
            }
        }

        private void UpdateDrzavaNaBazi()
        {
            try
            {
                taDrzava.Update(ds.Drzava);
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        private void btnDrzavaUredi_Click(object sender, EventArgs e)
        {
            ((PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem).Naziv = txtDrzava.Text;

            UpdateDrzavaNaBazi();

            PrikaziDrzave();
        }

        private void btnBrisiDrzavu_Click(object sender, EventArgs e)
        {
            PPPKVjezbe10DataSet.DrzavaRow drzava = (PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem;
            PPPKVjezbe10DataSet.GradRow[] gradovi = (PPPKVjezbe10DataSet.GradRow[])drzava.GetChildRows("relacija");

            foreach (PPPKVjezbe10DataSet.GradRow row in gradovi)
            {
                row.Delete();
            }

            drzava.Delete();

            UpdateGradNaBazi();
            UpdateDrzavaNaBazi();

            PrikaziDrzave();
        }

        private void UpdateGradNaBazi()
        {
            try
            {
                taGrad.Update(ds.Grad);
            }
            catch (Exception ex)
            {
                lblInfo.Text = ex.Message;
            }
        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {

            PPPKVjezbe10DataSet.GradRow noviGrad = ds.Grad.NewGradRow();
            noviGrad.Naziv = txtGrad.Text;
            PPPKVjezbe10DataSet.DrzavaRow odabranaDrzava = (PPPKVjezbe10DataSet.DrzavaRow)lbDrzave.SelectedItem;
            noviGrad.DrzavaID = odabranaDrzava.IDDrzava;

            ds.Grad.Rows.Add(noviGrad);

            UpdateGradNaBazi();

            PrikaziGradoveOdabraneDrzave();
        }

        private void btnBrisiGrad_Click(object sender, EventArgs e)
        {
            PPPKVjezbe10DataSet.GradRow odabrana = (PPPKVjezbe10DataSet.GradRow)lbGrad.SelectedItem;
            odabrana.Delete();

            UpdateGradNaBazi();

            PrikaziGradoveOdabraneDrzave();
        }

        private void btnUrediGrad_Click(object sender, EventArgs e)
        {
            PPPKVjezbe10DataSet.GradRow odabraniGrad = (PPPKVjezbe10DataSet.GradRow)lbGrad.SelectedItem;

            odabraniGrad.Naziv = txtGrad.Text;

            UpdateGradNaBazi();

            PrikaziGradoveOdabraneDrzave();
        }
    }
}
