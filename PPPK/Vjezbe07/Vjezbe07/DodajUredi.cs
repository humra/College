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
    public partial class DodajUredi : Form
    {
        public int IDVozaca { get; set; }
        public string naziv { get; return txtNaziv.Text }

        public DodajUredi()
        {
            InitializeComponent();
        }

        public DodajUredi(DataTable dtVozac, string nazivBolida, int indexVozaca)
        {
            InitializeComponent();
            txtNaziv.Text = nazivBolida;
            PrikaziVozace(dtVozac, indexVozaca);
        }

        private void PrikaziVozace(DataTable dtVozac, int indexVozaca)
        {
            foreach (DataRow dr in dtVozac.Rows)
            {
                Vozac temp = new Vozac();
                temp.ID = (int)dr["ID"];
                temp.Ime = dr["Ime"].ToString();
                temp.Prezime = dr["Prezime"].ToString();

                cbVozac.Items.Add(temp);
            }

            IDVozaca = ((Vozac)cbVozac.SelectedItem).ID;
            cbVozac.SelectedIndex = indexVozaca;
        }

        private void cbVozac_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDVozaca = ((Vozac)cbVozac.SelectedItem).ID;
        }
    }
}
