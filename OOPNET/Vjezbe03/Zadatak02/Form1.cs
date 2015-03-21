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

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnesiIgrace();
        }

        private void UnesiIgrace()
        {
            StreamReader sr = new StreamReader("igraci.txt", Encoding.GetEncoding(1250));

            while (!sr.EndOfStream)
            {
                this.comboBox1.Items.Add(sr.ReadLine());
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.textBox1.AppendText(DateTime.Now + " " + this.comboBox1.SelectedItem + "\n");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.AppendText(DateTime.Now.ToString("HH:mm:ss") + " " + this.comboBox1.SelectedItem + "\n");
        }
    }
}
