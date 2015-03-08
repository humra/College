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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            this.Size = new Size(r.Next(50, 300), r.Next(50, 300));
            this.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), r.Next(0, 256));

            this.btnDoTheThing.Location = new Point((ClientSize.Width - btnDoTheThing.Width) / 2, (ClientSize.Height - btnDoTheThing.Height) / 2);
        }
    }
}
