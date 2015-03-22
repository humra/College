using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void konjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postaviKonj();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            postaviNilski();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            postaviSlon();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            postaviKonj();
        }

        private void nilskiKonjToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postaviNilski();
        }

        private void slonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postaviSlon();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.K)
            {
                postaviKonj();
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                postaviNilski();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                postaviSlon();
            }
        }

        private void postaviSlon()
        {
            this.pictureBox1.Image = MojiResursi.slon;
        }

        private void postaviNilski()
        {
            this.pictureBox1.Image = MojiResursi.nilski;
        }

        private void postaviKonj()
        {
            this.pictureBox1.Image = MojiResursi.konj;
        }
    }
}
