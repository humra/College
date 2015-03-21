using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            this.checkedListBox1.Items.Clear();
            UcitajIgrace();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UcitajIgrace();
        }

        private void UcitajIgrace()
        {
            StreamReader sr = new StreamReader("igraci.txt", Encoding.GetEncoding(1250));

            while (!sr.EndOfStream)
            {
                this.checkedListBox1.Items.Add(sr.ReadLine());
            }

            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string o in this.checkedListBox1.CheckedItems.Cast<string>().ToList())
            {
                this.checkedListBox1.Items.Remove(o);
            }
        }
    }
}
