using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe07
{
    public partial class NoviUredi : Form
    {
        public string Naziv { get { return txtNaziv.Text; } }
        public int IDVozac { get; set; }

        public NoviUredi(DataTable dtVozac, string nazivBolida, int indexVozaca)
        {
            InitializeComponent();
            txtNaziv.Text = nazivBolida;
            PrikaziVozace(dtVozac, indexVozaca);
        }

        private void PrikaziVozace(DataTable dtVozac, int indexVozaca)
        {
            foreach (DataRow row in dtVozac.Rows)
            {
                Vozac v = new Vozac() { ID=int.Parse(row["id"].ToString()), Ime = row["ime"].ToString(), Prezime = row["prezime"].ToString()};
                cbVozac.Items.Add(v);
            }
            cbVozac.SelectedIndex = indexVozaca;
            IDVozac = ((Vozac)cbVozac.SelectedItem).ID;
        }

        private void cbVozac_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDVozac = ((Vozac)cbVozac.SelectedItem).ID;
        }
    }
}
