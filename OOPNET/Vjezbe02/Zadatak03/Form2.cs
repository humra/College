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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int brojGumbi = 0;

        public void dodajGumb()
        {
            brojGumbi++;
            Button b = new Button();
            b.Text = "Gumb" + brojGumbi.ToString();
            this.root.Controls.Add(b);
        }
    }
}
