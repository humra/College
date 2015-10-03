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

namespace Zadatak06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            StackPanel temp = new StackPanel();
            SolidColorBrush brushy = new SolidColorBrush(Color.FromRgb((byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
            temp.Background = brushy;
            temp.Width = 20;
            temp.Height = 20;
            temp.LayoutTransform = new RotateTransform(r.Next(0, 360));

            stcPanel.Children.Add(temp);
        }

        private void btnBrisi_Click(object sender, RoutedEventArgs e)
        {
            stcPanel.Children.Clear();
        }
    }
}
