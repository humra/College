using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaKrava
{
    public partial class Izmjena : Form
    {
        public FarmaKravaEntity db;

        public Krava krava { get; set; }

        public Izmjena()
        {
            InitializeComponent();
        }

        private void Izmjena_Load(object sender, EventArgs e)
        {
            prikaziDetalje();
        }

        private void prikaziDetalje()
        {
            txtIme.Text = krava.Ime;

            pripremiListuPasmina();
            int index = pronadjiIndexPasmine();
            ddlPasmina.SelectedIndex = index;

            txtJVB.Text = krava.VeterinarskiBroj;

            numBrojTeladi.Value = krava.BrojTeladi;
            
            String[] datum = krava.DatumRodjenja.ToString().Split('/');

            dateDatumRodjenja.Value = new DateTime(int.Parse(datum[2].Substring(0, 4)), int.Parse(datum[1]), int.Parse(datum[0]));
        }

        private int pronadjiIndexPasmine()
        {
            List<Pasmina> pasmine = db.Pasminas.ToList();
            foreach(Pasmina p in pasmine)
            {
                if(p.ID == krava.Pasmina)
                {
                    return ddlPasmina.FindString(p.Naziv);
                }
            }

            return 1;
        }

        private void pripremiListuPasmina()
        {
            List<Pasmina> pasmine = db.Pasminas.ToList();
            ddlPasmina.DataSource = pasmine;
            ddlPasmina.ValueMember = "ID";
            ddlPasmina.DisplayMember = "Naziv";
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            krava.Ime = txtIme.Text;
            krava.VeterinarskiBroj = txtJVB.Text;
            krava.BrojTeladi = (int)numBrojTeladi.Value;

            krava.Pasmina = int.Parse(ddlPasmina.SelectedValue.ToString());

            krava.DatumRodjenja = dateDatumRodjenja.Value;

            db.Entry(krava).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();
            this.Close();
        }
    }
}
