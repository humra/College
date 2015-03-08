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

        private void btnDoTheThing_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            this.Location = new Point(r.Next(0, Screen.PrimaryScreen.WorkingArea.Width - this.Width), r.Next(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height));
        }
    }
}
