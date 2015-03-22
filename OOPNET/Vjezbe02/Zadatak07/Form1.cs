using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak07
{
    public partial class Form1 : Form
    {
        Random r;
        int remainingTime;
        int points;
        Panel[] panels;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
            remainingTime = 30000;
            points = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreatePanels();
            Reposition();
        }

        private void Reposition()
        {
            for (int i = 0; i < 5; i++)
            {
                panels[i].Location = new Point(r.Next(0, placeholder.Width - panels[i].Width), r.Next(0, placeholder.Height - panels[i].Height));
            }
        }

        private void CreatePanels()
        {
            int redInitialSize = 20;
            int pointsInitialValue = 200;
            int tempSize;
            int tempPoints;

            panels = new Panel[5];

            for (int i = 0; i < 4; i++)
            {
                tempSize = redInitialSize + (redInitialSize * i);
                tempPoints = pointsInitialValue + (pointsInitialValue * i);

                MakePanel(i, tempSize, tempPoints, Color.Red);
            }

            MakePanel(4, 50, -1000, Color.Green);

            placeholder.Controls.AddRange(panels);
        }

        private void MakePanel(int i, int tempSize, int tempPoints, Color color)
        {
            Panel temp = new Panel();
            temp.Height = tempSize;
            temp.Width = tempSize;
            temp.BackColor = color;
            temp.Tag = tempPoints;
            temp.Click += PanelClick;

            panels[i] = temp;
        }

        private void PanelClick(object sender, EventArgs e)
        {
            Panel clicked = sender as Panel;
            points += (int)clicked.Tag;
            bodovi.Text = points.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainingTime -= timer1.Interval;

            if (remainingTime <= 0)
            {
                GameOver();
            }

            Reposition();
        }

        private void GameOver()
        {
            timer1.Stop();

            MessageBox.Show(string.Format("Game over! You have collected {0} points!", bodovi));

            Application.Exit();
        }

    }
}
