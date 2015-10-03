using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadatak03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Point> _points = new List<Point>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cnvCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _points.Add(e.GetPosition(cnvCanvas));

            DrawLines();
        }

        private void DrawLines()
        {
            for (int i = 0; i < _points.Count - 1; i++)
            {
                Line l = new Line();
                l.Stroke = (Brush)this.FindResource("brushy");
                l.StrokeThickness = 3;
                l.X1 = _points[i].X;
                l.X2 = _points[i + 1].X;
                l.Y1 = _points[i].Y;
                l.Y2 = _points[i + 1].Y;

                cnvCanvas.Children.Add(l);
            }
        }

        private void cnvCanvas_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Point p = e.GetPosition(cnvCanvas);

            Label l = new Label();
            l.Content = "X";
            l.SetValue(Canvas.LeftProperty, p.X);
            l.SetValue(Canvas.TopProperty, p.Y);

            cnvCanvas.Children.Add(l);
        }
    }
}
