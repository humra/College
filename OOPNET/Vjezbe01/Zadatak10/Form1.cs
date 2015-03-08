using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTheThing_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));

            this.Opacity = r.NextDouble();

            GraphicsPath gp = new GraphicsPath();
            Point[] points = new Point[3];

            int temp = r.Next(1, 500);

            points[0] = new Point(0, 0);
            points[1] = new Point(0, temp);
            points[2] = new Point(r.Next(1, 500), temp);

            gp.AddPolygon(points);

            this.Region = new Region(gp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath gp = new GraphicsPath();
            Point[] points = new Point[3];

            points[0] = new Point(0, 0);
            points[1] = new Point(0, 300);
            points[2] = new Point(300, 300);

            gp.AddPolygon(points);
            this.AllowTransparency = true;

            this.Region = new Region(gp);
        }
    }
}
