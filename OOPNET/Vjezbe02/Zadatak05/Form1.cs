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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2(this);

            temp.ShowDialog();

            if(temp.DialogResult == System.Windows.Forms.DialogResult.OK) 
            {
                this.textBox1.AppendText(temp.vratiTekst() + "\n");
            }
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
    }
}
