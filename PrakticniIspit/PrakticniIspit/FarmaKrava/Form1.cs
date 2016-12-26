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
    public partial class Form1 : Form
    {
        FarmaKravaEntity db = new FarmaKravaEntity();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            prikaziKrave();
        }

        public void prikaziKrave()
        {
            List<Krava> krave = db.Kravas.ToList();

            lbKrave.DataSource = krave;
            lbKrave.DisplayMember = "Ime";
            lbKrave.ValueMember = "ID";
        }

        private void btnIzmjena_Click(object sender, EventArgs e)
        {
            int idKrave = int.Parse(lbKrave.SelectedValue.ToString());
            Krava tempKrava = db.Kravas.Find(idKrave);

            Izmjena izmjenaForma = new Izmjena();
            izmjenaForma.krava = tempKrava;
            izmjenaForma.db = db;
            izmjenaForma.Show();

            izmjenaForma.FormClosed += zatvaranjeIzmjene;
        }

        private void zatvaranjeIzmjene(object sender, FormClosedEventArgs e)
        {
            prikaziKrave();
        }
    }
}
