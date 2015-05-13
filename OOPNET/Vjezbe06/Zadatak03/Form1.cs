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

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            statusLabel.Text = string.Format("Na formi: {0}", e.Location.ToString());
        }

        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            logiraj("MouseDown_start");
            btn1.DoDragDrop(sender as Button, DragDropEffects.Move);
            logiraj("MouseDown_end");
        }

        private void logiraj(string text)
        {
            txtLog.AppendText(text);
            txtLog.AppendText("\n");
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            logiraj("DragEntered");
        }


        private void panel1_DragLeave(object sender, EventArgs e)
        {
            logiraj("DragExited");
        }

        private void panel1_DragOver(object sender, DragEventArgs e)
        {
            logiraj("DragOver");
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            Button button = (Button)e.Data.GetData(typeof(Button));
            button.Location = new Point(0, 0);
            panel1.Controls.Add(button);

            logiraj("DragDrop");
        }
    }
}
