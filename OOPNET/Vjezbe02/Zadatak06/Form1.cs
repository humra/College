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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();

            forma.ShowDialog();

            if (forma.DialogResult == DialogResult.OK)
            {
                String temp = forma.vratiPodatke();

                this.textBox1.AppendText(temp + "\n");
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Form3 forma = new Form3();

            forma.ShowDialog();

            if (forma.DialogResult == DialogResult.OK)
            {
                this.textBox1.Clear();
            }
        }
    }
}
