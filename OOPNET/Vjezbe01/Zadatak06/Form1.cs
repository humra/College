using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak06
{
    public partial class Form1 : Form
    {
        public Panel zadnjiPanel;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajPanel_Click(object sender, EventArgs e)
        {
            Panel temp = new Panel();
            Random r = new Random();

            temp.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            temp.Width = 200;
            temp.Height = 200;

            temp.Location = new Point(r.Next(1, this.Width - 200), r.Next(1, this.Height - 200));

            this.Controls.Add(temp);
            this.zadnjiPanel = temp;
        }

        private void btnUkloniSvePanele_Click(object sender, EventArgs e)
        {
            List<Panel> paneli = new List<Panel>();

            foreach (var v in this.Controls)
            {
                if (v is Panel)
                {
                    paneli.Add((Panel)v);
                }
            }

            for (int i = 0; i < paneli.Count; i++)
            {
                this.Controls.Remove(paneli[i]);
            }
        }

        private void btnDodajGumb_Click(object sender, EventArgs e)
        {
            Button tempBtn = new Button();
            Random r = new Random();

            tempBtn.Text = "GUMB";
            tempBtn.Location = new Point(r.Next(0, zadnjiPanel.Width - tempBtn.Width), r.Next(0, zadnjiPanel.Height - tempBtn.Height));
            zadnjiPanel.Controls.Add(tempBtn);
        }

        private void btnUkloniSveGumbe_Click(object sender, EventArgs e)
        {
            foreach (var v in this.Controls)
            {
                if (v is Panel)
                {
                    ukloniGumbeIzPanela((Panel)v);
                }
            }
        }

        private void ukloniGumbeIzPanela(Panel p)
        {
            List<Button> sviGumbi = new List<Button>();

            foreach (var v in p.Controls)
            {
                if (v is Button)
                {
                    sviGumbi.Add((Button)v);
                }
            }

            for (int i = 0; i < sviGumbi.Count; i++)
            {
                p.Controls.Remove(sviGumbi[i]);
            }
        }
    }
}
