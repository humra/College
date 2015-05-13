using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak01
{
    public partial class Form1 : Form
    {
        private Button zapoceoDnD;
        private bool uspjesnoZavrsio = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            zapocniDnD(sender as Button);
        }

        private void zapocniDnD(Button btn)
        {
            label1.Text = "Zapoceo drag and drop";
            zapoceoDnD = btn;

            btn.DoDragDrop(btn.BackColor, DragDropEffects.Move);

            if (uspjesnoZavrsio == true)
            {
                zapoceoDnD = null;
                uspjesnoZavrsio = false;
                btn.BackColor = SystemColors.Control;
                label1.Text = "";
            }
        }

        private void btn_DragEnter(object sender, DragEventArgs e)
        {
            usaoDnD(sender as Button, e);
        }

        private void usaoDnD(Button btn, DragEventArgs e)
        {
            if (btn == zapoceoDnD)
            {
                return;
            }

            e.Effect = DragDropEffects.Move;
            label1.Text = "Drag and drop je nad mogucim ciljem";
        }

        private void btn_DragLeave(object sender, EventArgs e)
        {
            izasaoIzDnD();
        }

        private void izasaoIzDnD()
        {
            label1.Text = "Drag and Drop je izasao iz moguceg cilja";
        }

        private void btn_DragDrop(object sender, DragEventArgs e)
        {
            zavrsioDnD(sender as Button, e);
        }

        private void zavrsioDnD(Button btn, DragEventArgs e)
        {
            btn.BackColor = (Color)e.Data.GetData(typeof(Color));
            uspjesnoZavrsio = true;
        }
    }
}
