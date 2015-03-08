using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovaFormaFix_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();

            temp.Height = 150;
            temp.Width = 150;
            temp.FormBorderStyle = FormBorderStyle.FixedDialog;

            temp.Show();
        }

        private void btnNovaFormaCrvena_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();

            temp.Width = 100;
            temp.Height = 100;
            temp.BackColor = Color.Red;

            temp.Show();
        }

        private void btnNovaFormaNoCtrl_Click(object sender, EventArgs e)
        {
            Form2 temp = new Form2();

            temp.Width = 200;
            temp.Height = 200;
            temp.ControlBox = false;

            temp.Show();
        }
    }
}
