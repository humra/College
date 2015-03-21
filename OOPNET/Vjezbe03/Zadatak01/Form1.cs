using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadatak01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("igraci.txt", Encoding.GetEncoding(1250));

            while (!sr.EndOfStream)
            {
                this.lbUIgri.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        private void Prebaci(ListBox iz, ListBox u, List<string> igraci)
        {
            foreach (string igrac in igraci)
            {
                iz.Items.Remove(igrac);
                u.Items.Add(igrac);
            }
        }

        private void btnLijevoDesnoSve_Click(object sender, EventArgs e)
        {
            this.Prebaci(lbUIgri, lbNaKlupi, this.lbUIgri.Items.Cast<string>().ToList());
        }

        private void btnLijevoDesnoOdabrani_Click(object sender, EventArgs e)
        {
            this.Prebaci(lbUIgri, lbNaKlupi, this.lbUIgri.SelectedItems.Cast<string>().ToList());
        }

        private void btnDesnoLijevoOdabrani_Click(object sender, EventArgs e)
        {
            this.Prebaci(lbNaKlupi, lbUIgri, this.lbNaKlupi.SelectedItems.Cast<string>().ToList());
        }

        private void btnDesnoLijevoSvi_Click(object sender, EventArgs e)
        {
            this.Prebaci(lbNaKlupi, lbUIgri, this.lbNaKlupi.Items.Cast<string>().ToList());
        }

        private void cbSortiraj_CheckedChanged(object sender, EventArgs e)
        {
            this.lbNaKlupi.Sorted = this.cbSortiraj.Checked;
            this.lbUIgri.Sorted = this.cbSortiraj.Checked;
        }
    }
}
