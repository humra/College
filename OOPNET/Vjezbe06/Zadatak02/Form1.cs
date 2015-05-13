using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        private Random _rnd;
        private Point _mouseDownPoint;
        private Panel _oznaceniPanel;

        public Form1()
        {
            InitializeComponent();
            _rnd = new Random();
            _mouseDownPoint = Point.Empty;
            _oznaceniPanel = null;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            kreirajPanele(1);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            kreirajPanele(5);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            kreirajPanele(10);
        }

        private void kreirajPanele(int kolicina)
        {
            for (int i = 1; i <= kolicina; i++)
            {
                kreirajNoviPanel();
            }
        }

        private void kreirajNoviPanel()
        {
            Panel panel = new Panel();
            panel.BackColor = SlucajnaBoja();
            panel.Size = SlucajnaVelicina();
            panel.Location = SlucajnaLokacija(panel.Width, panel.Height);
            panel.MouseDown += new MouseEventHandler(panel_MouseDown);
            this.Controls.Add(panel);
        }

        private Color SlucajnaBoja()
        {
            int min = 0;
            int max = 256;

            return Color.FromArgb(_rnd.Next(min, max), _rnd.Next(min, max), _rnd.Next(min, max));
        }

        private Size SlucajnaVelicina()
        {
            int min = 30;
            int max = 70;

            int s = _rnd.Next(min, max);

            return new Size(s, s);
        }

        private Point SlucajnaLokacija(int width, int height)
        {
            return new Point(_rnd.Next(0, this.ClientSize.Width - width), _rnd.Next(0, this.ClientSize.Height - height));
        }

        void panel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel p = sender as Panel;

            OznaciPanel(p);

            _mouseDownPoint = p.PointToScreen(e.Location);

            this.DoDragDrop(42 /* bezveze */, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void OznaciPanel(Panel panel)
        {
            _oznaceniPanel = panel;

            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    ((Panel)c).BorderStyle = BorderStyle.None;
                }
            }

            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void ocistiPaneleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Control> ukloniti = new List<Control>();

            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    ukloniti.Add(c);
                }
            }

            foreach (Control c in ukloniti)
            {
                this.Controls.Remove(c);
            }

            _oznaceniPanel = null;
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
            else if (e.KeyState == 2)
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Point delta = IzracunajDeltu(_mouseDownPoint, e.X, e.Y);

            if (e.Effect == DragDropEffects.Move)
            {
                PomakniPanel(_oznaceniPanel, delta);
            }
            else
            {
                KopirajPanel(_oznaceniPanel, delta);
            }
        }

        private void PomakniPanel(Panel oznaceniPanel, Point delta)
        {
            oznaceniPanel.Location = new Point(
                oznaceniPanel.Location.X + delta.X,
                oznaceniPanel.Location.Y + delta.Y);
        }

        private void KopirajPanel(Panel oznaceniPanel, Point delta)
        {
            Panel p = new Panel();
            p.Location = new Point(
                oznaceniPanel.Location.X + delta.X,
                oznaceniPanel.Location.Y + delta.Y);

            p.BackColor = oznaceniPanel.BackColor;
            p.Size = oznaceniPanel.Size;
            p.MouseDown += new MouseEventHandler(panel_MouseDown);
            this.Controls.Add(p);

            OznaciPanel(p);
        }

        private Point IzracunajDeltu(Point originalMouseDownPoint, int mousex, int mousey)
        {
            Point down = originalMouseDownPoint;
            Point up = new Point(mousex, mousey);

            int razlikax = up.X - down.X;
            int razlikay = up.Y - down.Y;

            return new Point(razlikax, razlikay);
        }
    }
}
