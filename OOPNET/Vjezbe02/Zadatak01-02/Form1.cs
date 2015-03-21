using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezbe02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        Random r;
        int redniBrojPanela = 1;
        int redniBrojGumba = 1;
        FlowLayoutPanel zadnjiPanel;

        private void btnDodajPanel_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.Size = new Size(200, 200);
            panel.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));
            panel.FlowDirection = FlowDirection.TopDown;
            panel.Name = "Panel" + redniBrojPanela.ToString();

            panel.AutoScroll = true;
            panel.WrapContents = false;

            redniBrojPanela++;
            zadnjiPanel = panel;
            this.redniBrojGumba = 1;

            this.root.Controls.Add(panel);
        }

        private void btnDodajGumb_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Text = "Gumb" + this.redniBrojGumba.ToString();
            this.redniBrojGumba++;
            btn.Size = new Size(90, 30);
            btn.Name = "Gumb" + this.redniBrojGumba.ToString();

            this.zadnjiPanel.Controls.Add(btn);
        }

        private void btnHijerarhija_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Control c in this.root.Controls)
            {
                FlowLayoutPanel flp = c as FlowLayoutPanel;

                if (flp == null)
                {
                    continue;
                }

                sb.AppendFormat("-{0}\r\n", flp.Name);

                foreach (Button b in flp.Controls)
                {
                    sb.AppendFormat("---{0}\r\n", b.Name);
                }
            }

            MessageBox.Show(sb.ToString());
        }
    }
}
