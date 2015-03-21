using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak06
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        internal string vratiPodatke()
        {
            return string.Format("{0} {1} {2} {3}", this.txtIme.Text, this.txtPrezime.Text, this.txtTelefon.Text, this.txtMobitel.Text);
        }
    }
}
