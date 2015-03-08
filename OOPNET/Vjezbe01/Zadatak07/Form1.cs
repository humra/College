using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak07
{
    public partial class Form1 : Form
    {
        Form zadnjaNapravljenaForma = new Form();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            zadnjaNapravljenaForma.Location = new Point(zadnjaNapravljenaForma.Location.X + 10, zadnjaNapravljenaForma.Location.Y);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form f = new Form();
            Random r = new Random();

            f.Width = 100;
            f.Height = 100;

            f.Location = new Point(r.Next(0, Screen.PrimaryScreen.WorkingArea.Width - 100), r.Next(0, Screen.PrimaryScreen.WorkingArea.Height - 100));

            f.Show();
            zadnjaNapravljenaForma = f;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            zadnjaNapravljenaForma.Location = new Point(zadnjaNapravljenaForma.Location.X - 10, zadnjaNapravljenaForma.Location.Y);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            zadnjaNapravljenaForma.Location = new Point(zadnjaNapravljenaForma.Location.X, zadnjaNapravljenaForma.Location.Y + 10);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            zadnjaNapravljenaForma.Location = new Point(zadnjaNapravljenaForma.Location.X, zadnjaNapravljenaForma.Location.Y - 10);
        }
    }
}
