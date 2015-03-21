using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btnBlue.BackColor = Color.Blue;
            this.btnGreen.BackColor = Color.Green;
            this.btnRed.BackColor = Color.Red;
            this.txtbxTekst.Multiline = true;
            this.txtbxTekst.ScrollBars = ScrollBars.Vertical;
            this.txtbxTekst.Height = 300;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            this.txtbxTekst.AppendText("CLICK on red button\n");
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.txtbxTekst.AppendText("CLICK on blue button\n");
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.txtbxTekst.AppendText("CLICK on green button\n");
        }

        private void btnRed_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText("MOUSE CLICK on red button\n");
        }

        private void btnBlue_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText("MOUSE CLICK on blue button\n");
        }

        private void btnGreen_MouseClick(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText("MOUSE CLICK on green button\n");
        }

        private void btnRed_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText(e.Button.ToString() + " mouse button on red button\n");
        }

        private void btnBlue_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText(e.Button.ToString() + " mouse button on blue button\n");
        }

        private void btnGreen_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtbxTekst.AppendText(e.Button.ToString() + " mouse button on green button\n");
        }
    }
}
