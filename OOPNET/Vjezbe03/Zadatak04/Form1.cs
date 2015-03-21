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

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            this.label2.Text = this.trackBar1.Value + "%";

            double temp = this.trackBar1.Value;
            temp = temp / 100;

            this.pictureBox1.Width = Convert.ToInt32(300 * temp);
            this.pictureBox1.Height = Convert.ToInt32(200 * temp);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label2.Text = "";
        }
    }
}
