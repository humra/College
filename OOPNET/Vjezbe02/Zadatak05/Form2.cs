using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak05
{
    public partial class Form2 : Form
    {
        Form1 mainForm;

        public Form2(Form1 mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            this.Text = "Unesite tekst";
        }

        private void btnPrihvati_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string vratiTekst()
        {
            return this.txtbxUnos.Text;
        }
    }
}
