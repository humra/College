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

namespace Zadatak08
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        string currentBrush = "brushyGreen";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string newBrush = string.Empty;

            if (currentBrush.Equals("brushyGreen"))
            {
                currentBrush = "brushyRed";
            }
            else
            {
                currentBrush = "brushyGreen";
            }

            LinearGradientBrush temp = (LinearGradientBrush)Gumb1.FindResource(currentBrush);

            Gumb1.Background = temp;
            Gumb2.Background = temp;
            Gumb3.Background = temp;
        }
    }
}
