using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        public Form2 drugaForma;
        Random r;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            forma.Show();
            drugaForma = forma;
        }

        private void btnBoja_Click(object sender, EventArgs e)
        {
            drugaForma.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
        }

        private void btnStanje_Click(object sender, EventArgs e)
        {
            int stanje = r.Next(1, 4);

            switch (stanje)
            {
                case 1:
                    drugaForma.WindowState = FormWindowState.Maximized;
                    break;
                case 2:
                    drugaForma.WindowState = FormWindowState.Minimized;
                    break;
                case 3:
                    drugaForma.WindowState = FormWindowState.Normal;
                    break;
                default:
                    break;

            }
        }

        private void btnGumb_Click(object sender, EventArgs e)
        {
            drugaForma.dodajGumb();
        }
    }
}
