using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01_02
{
    public partial class Form1 : Form
    {
        private int isprintano;

        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show("Printanje je zavrseno");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;

            Font f = new Font("Arial", 22, FontStyle.Regular, GraphicsUnit.Pixel);

            g.DrawString("Hello, world!", f, Brushes.Green, new PointF(e.MarginBounds.X, e.MarginBounds.Y));

            isprintano++;

            if (isprintano < numericUpDown1.Value)
            {
                e.HasMorePages = true;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                isprintano = 0;

                printDocument1.Print();
            }
        }

        private void btnMargine_Click(object sender, EventArgs e)
        {
            if (pageSetupDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Uspjeh");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
