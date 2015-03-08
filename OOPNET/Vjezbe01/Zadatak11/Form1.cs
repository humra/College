using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadatak11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder();

            s.Append(this.Location.ToString());
            s.Append(" ");
            s.Append(this.Width.ToString());
            s.Append(" ");
            s.Append(this.Height.ToString());
            s.Append(" ");
            s.Append(this.WindowState.ToString());

            File.WriteAllText("test.txt", s.ToString());
        }
    }
}
